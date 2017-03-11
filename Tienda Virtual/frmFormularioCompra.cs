using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Design;
using MySql.Data.MySqlClient;
using System.Web.Services;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Tienda_Virtual
{
    interface Pago
    {
        void pagar(frmFormularioCompra fr);
    }


    public partial class frmFormularioCompra : Form
    {

        #region ConstructorInformaciondelCarrito
        public frmFormularioCompra(DataGridView dtg_get, string correo_get, string subtotal_get, string iva_get, string total_get, string nombre_get, int idCliente_get)
        {
            InitializeComponent();
            dtgVentas = dtg_get;
            email.correoTo = correo_get;
            correo_cliente = correo_get;

            IVA = iva_get;
            Subtotal = subtotal_get;
            TotalVenta = total_get;
            Nombre = nombre_get;
            idCliente = idCliente_get;
            btnComprarEfectivo.Enabled = false;
            btnCancelar.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
           
        }
        #endregion


        #region Variables importantes
        Declaraciones decla = new Declaraciones();  //Objeto del tipo de la clase Declaraciones
        DataGridView dtgVentas;
        SendEmail email = new SendEmail();
        //Pago metodo_pago = new Pago();

        string TotalVenta, Subtotal, IVA, Nombre, tabla, correo_cliente;
        public bool compraRealizada = false;
        public bool pago_previo;
        int idCliente;
        #endregion

        public bool AccesoInternet()
        {
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        #region CompraconTarjeta

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Estas Seguro de Comprar los Articulos Seleccionados?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    for (int i = 0; i < dtgVentas.Rows.Count - 1; i++)
                    {
                        tabla += "<tr>";
                        tabla += "<td align=center>" + dtgVentas.Rows[i].Cells[1].Value.ToString() + "</td><td>" + dtgVentas.Rows[i].Cells[2].Value.ToString() + "</td><td>$" + dtgVentas.Rows[i].Cells[3].Value.ToString() + "</td><td align=center>" + dtgVentas.Rows[i].Cells[4].Value.ToString() + "</td>";
                        try
                        {
                            decla.dosomething("UPDATE almacen SET Productos = (Productos -'" + Convert.ToInt32(dtgVentas.Rows[i].Cells[4].Value) + "') WHERE Nombre = '" + dtgVentas.Rows[i].Cells[1].Value.ToString() + "'");  //Llama al metodo que ejecuta acciones en la base de datos
                        }
                        catch (Exception ex)  //Si hay error
                        {
                            decla.Conexion.Close();  //Se cierra conexion
                            MessageBox.Show(ex.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Se muestra el error
                        }
                        tabla += "</tr>";
                    }
                    decla.Instruccion.Parameters.AddWithValue("idCliente", idCliente);
                    if (decla.dosomething("Delete from carrito where id_Cliente = @idCliente"))  //Llama al metodo que ejecuta acciones en la base de datos
                    {
                        if (AccesoInternet())
                        {
                            MessageBox.Show("Espere un momento, enviando datos de la compra", "Espere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            email.subject = "Detalles de su compra";
                            email.body = "<html>" +
                            "<body>" +
                                "<h3>Gracias por tu compra.</h3><br>" +
                                "<h4>" + txtNombre.Text + ".</h4><br>" +
                                "Tu transaccion ha finalizado y te hemos enviado un recibo de tu compra por correo" +
                                "electronico.<br>Un operario de nuestra tienda de contactara contigo<br>" +
                                "Saludos cordiales<br><br>" +
                                "<div id='cuerpo'>" +
                                    "<h1>Detalles de su compra ( " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss") + " )</h1><br>" +
                                    "<table border=1>" +
                                        "<tr>" +
                                            "<td>Nombre</td>" +
                                            "<td>Descripci&oacute;n</td>" +
                                            "<td>Precio</td>" +
                                            "<td>Cantidad</td>" +
                                        "</tr>" + tabla +
                                    "</table>" +
                                    "<h2>El subtotal de su compra es: " + Subtotal + "<br>" +
                                    "El IVA de su compra es: " + IVA + "<br>" +
                                    "El total de su compra es: " + TotalVenta + "</h2><br>" +
                                    "<center><h3>Atte: Departamento de ventas</h3></center><br>" +
                                    "<center><img src='http://i.imgur.com/1xTe5hG.png'</center>" +
                                "</div>" +
                                "<style>" +
                                    "h3{font-size:15px;}" +
                                    "#cuerpo{background-color:#E6E6E6;}" +
                                "</style>" +
                            "</body></html>";
                            email.CreateEmail();
                            if (email.enviado)
                                MessageBox.Show("Datos de compra enviados satisfactoriamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            //Mandar correo
                        }
                        else
                            MessageBox.Show("No estas conectado a internet, aun asi tu compra se realizara", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        MessageBox.Show("Gracias " + Nombre + " tu compra fue realizada satisfactoriamente", "Compra realizada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);  //Se muestra mensaje de que se realizo todo
                        this.Close();
                        compraRealizada = true;
                    }
                    else  //Si existe algun problema
                        MessageBox.Show("Existe algun tipo de problema, cierre y abra otra ves el programa", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Stop);  //Se muestra mensaje de error
                }
            }
            catch (Exception ex)  
            {
                decla.Conexion.Close();  
                MessageBox.Show(ex.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Se muestra el error
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        #region Validaciones
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Length == 0)
                this.ValidarErrores.SetError(this.txtNombre, "Porfavor, Ingrese el Nombre del Socio.");
            else
                this.ValidarErrores.SetError(this.txtNombre, "");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Length == 0)
                this.ValidarErrores.SetError(this.txtEmail, "Porfavor, Ingrese un número de tarjeta valido.");
            else
                this.ValidarErrores.SetError(this.txtEmail, "");
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text.Length == 0)
                this.ValidarErrores.SetError(this.textBox3, "Porfavor, Ingrese un mes.");
            else
                this.ValidarErrores.SetError(this.textBox3, "");
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text.Length == 0)
                this.ValidarErrores.SetError(this.textBox4, "Porfavor, Ingrese un año.");
            else
                this.ValidarErrores.SetError(this.textBox4, "");
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (textBox5.Text.Length == 0)
                this.ValidarErrores.SetError(this.textBox5, "Porfavor, Ingrese un codigo de seguridad.");
            else
                this.ValidarErrores.SetError(this.textBox5, "");
        }
        #endregion

        #region Solo numeros
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si es Cualquier otro Digito
            if (Char.IsDigit(e.KeyChar))  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Espacio
            else if (e.KeyChar == 255)  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Cualquier tecla de Control
            else if (Char.IsControl(e.KeyChar))  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Separador
            else if (Char.IsSeparator(e.KeyChar))  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Número
            else  //Entra
                e.Handled = true;    // indica que el evento de KeyPress si se controló.
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si es Cualquier otro Digito
            if (Char.IsDigit(e.KeyChar))  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Espacio
            else if (e.KeyChar == 255)  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Cualquier tecla de Control
            else if (Char.IsControl(e.KeyChar))  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Separador
            else if (Char.IsSeparator(e.KeyChar))  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Número
            else  //Entra
                e.Handled = true;    // indica que el evento de KeyPress si se controló.
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si es Cualquier otro Digito
            if (Char.IsDigit(e.KeyChar))  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Espacio
            else if (e.KeyChar == 255)  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Cualquier tecla de Control
            else if (Char.IsControl(e.KeyChar))  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Separador
            else if (Char.IsSeparator(e.KeyChar))  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Número
            else  //Entra
                e.Handled = true;    // indica que el evento de KeyPress si se controló.
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si es Cualquier otro Digito
            if (Char.IsDigit(e.KeyChar))  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Espacio
            else if (e.KeyChar == 255)  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Cualquier tecla de Control
            else if (Char.IsControl(e.KeyChar))  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Separador
            else if (Char.IsSeparator(e.KeyChar))  //Entra
                e.Handled = false;    // indica que el evento de KeyPress no se controló.
            //Si es Número
            else  //Entra
                e.Handled = true;    // indica que el evento de KeyPress si se controló.
        }
        #endregion

        private void btnFactura_Click(object sender, EventArgs e)
        {
            /*frmFactura factura = new frmFactura();
            this.Hide();
            factura.ShowDialog();
            this.Show();*/
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        #region EscogerTipoPago
        private void cbmMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
            if (cbmMetodoPago.SelectedItem == "Efectivo")
            {
                pago_previo=false;
                PagoEfectivo efectivo = new PagoEfectivo();
                efectivo.pagar(this);
                /*if (pago_previo)
                {
                    txtCliente.Text = "";
                    txtSubtotal.Text = "";
                    txtIva.Text = "";
                    txtTotal.Text = "";
                    txtCambio.Text = "";
                }*/
                
                
            }
            else if (cbmMetodoPago.SelectedItem == "TarjetaCredito")
            {
                PagoTarjeta pagar_con_tarjeta = new PagoTarjeta();
                 pagar_con_tarjeta.pagar(this);
             }
            else if (cbmMetodoPago.SelectedItem == "Payplay")
            {
                PagoPayPlay pagar_pay_play = new PagoPayPlay();
                pagar_pay_play.pagar(this);
            }

        }
        #endregion
        #region ImplementaciónPatronStrategy
        public class PagoEfectivo : Pago
        {
            public void pagar(frmFormularioCompra fr)
            {
                fr.btnComprarEfectivo.Enabled = true;
                fr.btnCancelar.Enabled = true;
                fr.txtPago.Enabled = true;
                fr.txtCambio.Enabled = true;
                fr.txtCliente.Text = fr.Nombre;
                fr.txtSubtotal.Text = fr.Subtotal;
                fr.txtIva.Text =fr. IVA;
                fr.txtTotal.Text = fr.TotalVenta;
                fr.pago_previo = true;
              }
        }
        public class PagoTarjeta:Pago
        {
           
            public void pagar(frmFormularioCompra fr)
            {
               
                fr.textBox3.Enabled = true;
                fr.textBox4.Enabled = true;
                fr.textBox5.Enabled = true;
                fr.txtNombre.Text = fr.Nombre;
                fr.button1.Enabled = true;
                fr.button2.Enabled = true;
                
            }
        }
        public class PagoPayPlay : Pago
        {
            public void pagar(frmFormularioCompra fr)
            {
                fr.txtClientePayPlay.Text =fr.Nombre;
                fr.txtEmail.Text=fr.correo_cliente;
                fr.txtIvaPayPlay.Text = fr.IVA;
                fr.txtTarjetaPayPlay.Enabled = true;
                fr.txtSubtotalPayPlay.Text = fr.Subtotal;
                fr.txtTotalPayPlay.Text = fr.TotalVenta;
                fr.btnCancelarPayPlay.Enabled = true;
                fr.btnPayPlay.Enabled = true;
            }
        }
        #endregion

        #region PatronState
        public class PedidoEntregado: EstadoPedido
        {  

            public void estado_actual(frmVenta fr)
            {
                
                MessageBox.Show("Su compra se efectuo ahora su pedido fue entregado","Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }
        #endregion


        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (Char.IsDigit(e.KeyChar))  //Entra
                 e.Handled = false;    // indica que el evento de KeyPress no se controló.
             //Si es Espacio
             else if (e.KeyChar == 255)  //Entra
                 e.Handled = false;    // indica que el evento de KeyPress no se controló.
             //Si es Cualquier tecla de Control
             else if (Char.IsControl(e.KeyChar))  //Entra
                 e.Handled = false;    // indica que el evento de KeyPress no se controló.
             //Si es Separador
             else if (Char.IsSeparator(e.KeyChar))  //Entra
                 e.Handled = false;    // indica que el evento de KeyPress no se controló.
             //Si es Número
             else  //Entra
                 e.Handled = true;    // indica que el evento de KeyPress si se controló.
         }
         #region CompraEfectivo
         private void btnComprarEfectivo_Click(object sender, EventArgs e)
         {
             DialogResult resultado = MessageBox.Show("¿Estas Seguro de Comprar los Articulos Seleccionados?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

             if(resultado==DialogResult.Yes)
             {
                
                 //Factura fac = new Factura();
                 //TextObject texto = (TextObject)fac.ReportDefinition.Sections["Section2"].ReportObjects["Cliente"];
                 //TextObject sub_total = (TextObject)fac.ReportDefinition.Sections["Section2"].ReportObjects["subtotal"];
                 //TextObject total = (TextObject)fac.ReportDefinition.Sections["Section2"].ReportObjects["total"];
               
                 if (txtPago.Text == "")
                 {
                     MessageBox.Show("Debes ingresar la denomicación del pago","Pago",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                 }
                 else
                 {
                     txtPago.Enabled = true;
                     txtCambio.Enabled = true;
                     string pago_relizado = txtPago.Text;
                   
                     txtPago.Text = pago_relizado;
                     double pago = Convert.ToDouble(pago_relizado);
                     string total_pagar = txtTotal.Text;
                   
                     double tot = Convert.ToDouble(total_pagar);
                     frmVenta frm=new frmVenta(idCliente);
                     PedidoEntregado entregar_producto = new PedidoEntregado();
                     entregar_producto.estado_actual(frm);
                     double cambio = pago - tot;
                     txtCambio.Text = cambio.ToString();
                     FileStream fs = new FileStream("Factura.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
                     PdfPTable pdfTable = new PdfPTable(dtgVentas.ColumnCount-1);
                     PdfPCell cell=new PdfPCell(new Phrase("Compras realizadas"));
                     cell.Colspan = 3;
                     cell.HorizontalAlignment = 1;
                     pdfTable.DefaultCell.Padding = 3;
                     pdfTable.WidthPercentage = 100;
                     pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                     pdfTable.DefaultCell.BorderWidth = 1;
                     for(int i = 0; i < dtgVentas.Rows.Count - 1; i++)
                     {

                    
                         pdfTable.AddCell(new Phrase("Producto"+"  "+dtgVentas.Rows[i].Cells[1].Value.ToString()));//Nombre
                         pdfTable.AddCell(new Phrase("Descripción"+"  "+dtgVentas.Rows[i].Cells[2].Value.ToString()));//Descripcion
                         pdfTable.AddCell(new Phrase("Precio"+"  " +dtgVentas.Rows[i].Cells[3].Value.ToString()));//Precio
                         pdfTable.AddCell(new Phrase("Total Producto"+"  "+dtgVentas.Rows[i].Cells[4].Value.ToString()));//Total
                         try
                         {
                             decla.dosomething("UPDATE almacen SET Productos = (Productos -'" + Convert.ToInt32(dtgVentas.Rows[i].Cells[4].Value) + "') WHERE Nombre = '" + dtgVentas.Rows[i].Cells[1].Value.ToString() + "'");  
                             decla.Instruccion.Parameters.AddWithValue("idCliente", idCliente);
                             decla.dosomething("Delete from carrito where id_Cliente = @idCliente");
                         }


                         catch (Exception ex)  
                         {
                             decla.Conexion.Close();  
                             MessageBox.Show(ex.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                         }
                                                                        
                     }
                     Document doc = new Document();
                     PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                     String appPath = System.IO.Directory.GetCurrentDirectory(); 
                     doc.Open();
                     iTextSharp.text.Image logoImage = iTextSharp.text.Image.GetInstance(appPath + "\\logo.jpg");
                     logoImage.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                     doc.Add(logoImage);
                     logoImage = null;
                     doc.AddTitle("Factura");
                     doc.AddAuthor("AnimeStore");
                      
                     doc.Add(pdfTable);
                     doc.Add(new Phrase("\nCliente:"+" "+this.txtCliente.Text.Trim()));
                     doc.Add(new Phrase("\nSubtotal:"+" "+this.txtSubtotal.Text.Trim()));
                     doc.Add(new Phrase("\nIva:"+""+txtIva.Text.Trim()));
                     doc.Add(new Phrase("\nTotal a Pagar:"+" "+this.txtTotal.Text.Trim()));
                     doc.Add(new Phrase("\nSu pago: "+" "+this.txtPago.Text.Trim()));
                     doc.Add(new Phrase("\nSu cambio:" + " " + this.txtCambio.Text.Trim()));
                     doc.Close();
                     
                    /* for (int i = 0; i < dtgVentas.Rows.Count - 1; i++)
                     {
                         
                         ds.Tables[0].Rows.Add
                             (new  object[] 
                             {
                                  dtgVentas.Rows[i].Cells[1].Value.ToString(),
                                   dtgVentas.Rows[i].Cells[2].Value.ToString(),
                                    dtgVentas.Rows[i].Cells[3].Value.ToString(),
                                     dtgVentas.Rows[i].Cells[4].Value.ToString()
                             });
                       
                         try
                         {
                           
                            // fac.SetDataSource(ds);
                             //crear_factura.crystalReportViewer1.ReportSource = fac;
                         }catch(CrystalReportsException ex)
                         {
                             MessageBox.Show(ex.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         }
                         try
                         {
                             decla.dosomething("UPDATE almacen SET Productos = (Productos -'" + Convert.ToInt32(dtgVentas.Rows[i].Cells[4].Value) + "') WHERE Nombre = '" + dtgVentas.Rows[i].Cells[1].Value.ToString() + "'");  //Llama al metodo que ejecuta acciones en la base de datos
                              decla.Instruccion.Parameters.AddWithValue("idCliente", idCliente);
                              decla.dosomething("Delete from carrito where id_Cliente = @idCliente");  
                               
                              
                              
                         
                         }


                         catch (Exception ex)  //Si hay error
                         {
                             decla.Conexion.Close();  //Se cierra conexion
                             MessageBox.Show(ex.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Se muestra el error
                         }
                  
                     }*/
               
                   
                  
                     /*texto.Text = txtCliente.Text;
                     sub_total.Text = txtSubtotal.Text;
                     total.Text = txtTotal.Text;
                     crear_factura.crystalReportViewer1.ReportSource = fac;
                     crear_factura.Show();*/
                   
                     MessageBox.Show("Gracias " + Nombre + " tu compra fue realizada satisfactoriamente", "Compra realizada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);  //Se muestra mensaje de que se realizo todo
                   
                     this.Close();
                   //  frmFactura fr = new frmFactura();
                    // fr.Show();
                     compraRealizada = true;
                 }
             }
            
         }
#endregion
         #region CacmelarCompraEfectivo
         private void btnCancelar_Click(object sender, EventArgs e)
         {
             DialogResult resultado = MessageBox.Show("¿Estas Seguro de Cancelar su compra?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if(resultado.Equals(DialogResult.Yes))
             {
                 this.Close();
             }
             else
             {
                 return;
             }
         }
#endregion

         private void btnPayPlay_Click(object sender, EventArgs e)
         {
             CompraPayPplay();
         }

         private void btnCancelarPayPlay_Click(object sender, EventArgs e)
         {
             cancelar_pago_PayPlay();
         }


        #region CompraPayPlay

         public void CompraPayPplay()
         {
             try
             {
                 DialogResult resultado = MessageBox.Show("¿Estas Seguro de Comprar los Articulos Seleccionados?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (resultado == DialogResult.Yes)
                 {
                     for (int i = 0; i < dtgVentas.Rows.Count - 1; i++)
                     {
                         tabla += "<tr>";
                         tabla += "<td align=center>" + dtgVentas.Rows[i].Cells[1].Value.ToString() + "</td><td>" + dtgVentas.Rows[i].Cells[2].Value.ToString() + "</td><td>$" + dtgVentas.Rows[i].Cells[3].Value.ToString() + "</td><td align=center>" + dtgVentas.Rows[i].Cells[4].Value.ToString() + "</td>";
                         try
                         {
                             decla.dosomething("UPDATE almacen SET Productos = (Productos -'" + Convert.ToInt32(dtgVentas.Rows[i].Cells[4].Value) + "') WHERE Nombre = '" + dtgVentas.Rows[i].Cells[1].Value.ToString() + "'");  //Llama al metodo que ejecuta acciones en la base de datos
                         }
                         catch (Exception ex)  //Si hay error
                         {
                             decla.Conexion.Close();  //Se cierra conexion
                             MessageBox.Show(ex.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Se muestra el error
                         }
                         tabla += "</tr>";
                     }
                     decla.Instruccion.Parameters.AddWithValue("idCliente", idCliente);
                     if (decla.dosomething("Delete from carrito where id_Cliente = @idCliente"))  //Llama al metodo que ejecuta acciones en la base de datos
                     {
                         if (AccesoInternet())
                         {
                             MessageBox.Show("Espere un momento, enviando datos de la compra", "Espere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             email.subject = "Detalles de su compra";
                             email.body = "<html>" +
                             "<body>" +
                                 "<h3>Gracias por tu compra.</h3><br>" +
                                 "<h4>" + txtNombre.Text + ".</h4><br>" +
                                 "Tu transaccion ha finalizado y te hemos enviado un recibo de tu compra por correo" +
                                 "electronico.<br>Un operario de nuestra tienda de contactara contigo<br>" +
                                 "Saludos cordiales<br><br>" +
                                 "<div id='cuerpo'>" +
                                     "<h1>Detalles de su compra ( " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss") + " )</h1><br>" +
                                     "<table border=1>" +
                                         "<tr>" +
                                             "<td>Nombre</td>" +
                                             "<td>Descripci&oacute;n</td>" +
                                             "<td>Precio</td>" +
                                             "<td>Cantidad</td>" +
                                         "</tr>" + tabla +
                                     "</table>" +
                                     "<h2>El subtotal de su compra es: " + Subtotal + "<br>" +
                                     "El IVA de su compra es: " + IVA + "<br>" +
                                     "El total de su compra es: " + TotalVenta + "</h2><br>" +
                                     "<center><h3>Atte: Departamento de ventas</h3></center><br>" +
                                     "<center><img src='http://i.imgur.com/1xTe5hG.png'</center>" +
                                 "</div>" +
                                 "<style>" +
                                     "h3{font-size:15px;}" +
                                     "#cuerpo{background-color:#E6E6E6;}" +
                                 "</style>" +
                             "</body></html>";
                             email.CreateEmail();
                             if (email.enviado)
                                 MessageBox.Show("Datos de compra enviados satisfactoriamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                             //Mandar correo
                         }
                         else
                             MessageBox.Show("No estas conectado a internet, aun asi tu compra se realizara", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                         MessageBox.Show("Gracias " + Nombre + " tu compra fue realizada satisfactoriamente", "Compra realizada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);  //Se muestra mensaje de que se realizo todo
                         this.Close();
                         compraRealizada = true;
                     }
                     else  //Si existe algun problema
                         MessageBox.Show("Existe algun tipo de problema, cierre y abra otra ves el programa", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Stop);  //Se muestra mensaje de error
                 }
             }
             catch (Exception ex)
             {
                 decla.Conexion.Close();
                 MessageBox.Show(ex.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Se muestra el error
             }
         
         }
        #endregion



        #region CancelarPagoPayPlay
        public void cancelar_pago_PayPlay()
         {

             DialogResult resultado = MessageBox.Show("¿Estas Seguro de Cancelar su compra?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (resultado.Equals(DialogResult.Yes))
             {
                 this.Close();
             }
             else
             {
                 return;
             }
         }
        #endregion

    }

}