using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Virtual
{
    public partial class frmCatalogo : Form
    {
        public frmCatalogo(int id_Usuario_Recivido)
        {
            InitializeComponent();
            id_Usuario = id_Usuario_Recivido;
        }  //Obtenemos id del usuario

        #region Variables importante
        Declaraciones decla = new Declaraciones();  
        frmDescripcion frm;
        PictureBox[] arrayPicture;
        Panel[] arrayPanel;
        Label[] etiquetasPrecio;
        Label[] etiquetasNombre;
        string[] descripciones = new string[20];
        string categoria="";
        double[] precios = new double[20];
        int idCategoria = 5, id_Usuario, cuantosHay;
        bool Encontrado = false;
        #endregion

        private void Form2_Load(object sender, EventArgs e)
        {
            arrayPicture = new PictureBox[20]{ptb1, ptb2, ptb3, ptb4, ptb5, ptb6, ptb7, ptb8, ptb9, ptb10, ptb11, ptb12, ptb13, ptb14, ptb15, ptb16, ptb17, ptb18, ptb19, ptb20};
            etiquetasPrecio = new Label[20] {lblPre1, lblPre2, lblPre3, lblPre4, lblPre5, lblPre6, lblPre7, lblPre8, lblPre9, lblPre10, lblPre11, lblPre12, lblPre13, lblPre14, lblPre15, lblPre16, lblPre17, lblPre18, lblPre19, lblPre20};
            etiquetasNombre = new Label[20] {lblNom1, lblNom2, lblNom3, lblNom4, lblNom5, lblNom6, lblNom7, lblNom8, lblNom9, lblNom10, lblNom11, lblNom12, lblNom13, lblNom14, lblNom15, lblNom16, lblNom17, lblNom18, lblNom19, lblNom20};
            arrayPanel = new Panel[20] {pnl1, pnl2, pnl3, pnl4, pnl5, pnl6, pnl7, pnl8, pnl9, pnl10, pnl11, pnl12, pnl13, pnl14, pnl15, pnl16, pnl17, pnl18, pnl19, pnl20};
            rdbPre_Bajo.Select();
            cuantosProducto();
            txtBuscar.Select();
        }

        #region seteos
        public void setImage(PictureBox pictu, string directorio)
        {
            pictu.ImageLocation = Environment.CurrentDirectory + @"\" + directorio;
        }

        public void setPrecios(Label precio, string cuantoCuesta)
        {
            precio.Text = "$" + cuantoCuesta;
        }

        public void setNombre(Label descripcion, string queEs)
        {
            descripcion.Text = queEs;
        }

        public void setCatalogo(string q)
        {
            try
            {
                decla.Instruccion.CommandText = q;  //Se pasa como una instruccion
                decla.Conexion.Open();  //Se habre la conexion
                decla.Lector = decla.Instruccion.ExecuteReader(); //Se pasa la instruccion para leer
                if (decla.Lector.HasRows) //Si tiene filas
                {
                    int i = 0;
                    while (decla.Lector.Read() && i<20)  //Mientras existan filas
                    {
                        setNombre(etiquetasNombre[i], decla.Lector[0].ToString());
                        descripciones[i] = decla.Lector[1].ToString();
                        setPrecios(etiquetasPrecio[i], decla.Lector[2].ToString());
                        precios[i] = Convert.ToDouble(decla.Lector[2].ToString());
                        setImage(arrayPicture[i], decla.Lector[3].ToString());
                        i++;
                    }
                }
                decla.Lector.Close();  //Se cierra Lector
                decla.Conexion.Close();  //Se cierra conexion
            }
            catch (Exception ex)  //Si hay error
            {
                MessageBox.Show(ex.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Se muestra el error
            }
        }

        public void setConsulta(int idCategoria, string ordenacion)
        {
            setCatalogo("SELECT t1.Nombre, t1.Descripcion, t1.Precio, t1.RutaImagen FROM productos t1 INNER JOIN categorias t2 ON t1.Categoria = t2.id_Categoria WHERE t1.Categoria = '"+idCategoria+"' ORDER BY t1."+ordenacion+"");  //Se establece una accion
        }

        public void setOrdenacion()
        {
            if (rdbPre_Bajo.Checked == true)
            {
                tssl1.Text = "..::Producutos de la categoria " + categoria + " ordenados del precio mas bajo al mas alto::..";
                setConsulta(idCategoria, "Precio ASC");
            }
            else if (rdbPre_Alto.Checked == true)
            {
                tssl1.Text = "..::Producutos de la categoria " + categoria + " ordenados del precio mas alto al mas bajo::..";
                setConsulta(idCategoria, "Precio DESC");
            }
            else if (rdbAZ.Checked == true)
            {
                tssl1.Text = "..::Producutos de la categoria " + categoria + " ordenados de la A a la Z::..";
                setConsulta(idCategoria, "Nombre ASC");
            }
            else if (rdbZA.Checked == true)
            {
                tssl1.Text = "..::Producutos de la categoria " + categoria + " ordenados de la Z a la A::..";
                setConsulta(idCategoria, "Nombre DESC");
            }
        }
        #endregion

        #region Categoarias
        private void tecnologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idCategoria = 4;
            categoria = "Tecnologia";
            setOrdenacion();
        }

        private void joyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idCategoria = 3;
            categoria = "Comic";
            setOrdenacion();
        }

        private void ropaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idCategoria = 2;
            categoria = "Figma";
            setOrdenacion();
        }

        private void vinosLicoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idCategoria = 5;
            categoria = "Manga";
            setOrdenacion();
        }

        private void comidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idCategoria = 1;
            categoria = "Anime";
            setOrdenacion();
        }
        #endregion

        #region Ver productos
        private void btn1_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom1.Text))
            {
                frm = new frmDescripcion(ptb1, lblNom1.Text, descripciones[0], precios[0], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom2.Text))
            {
                frm = new frmDescripcion(ptb2, lblNom2.Text, descripciones[1], precios[1], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom3.Text))
            {
                frm = new frmDescripcion(ptb3, lblNom3.Text, descripciones[2], precios[2], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom4.Text))
            {
                frm = new frmDescripcion(ptb4, lblNom4.Text, descripciones[3], precios[3], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom5.Text))
            {
                frm = new frmDescripcion(ptb5, lblNom5.Text, descripciones[4], precios[4], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom6.Text))
            {
                frm = new frmDescripcion(ptb6, lblNom6.Text, descripciones[5], precios[5], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom7.Text))
            {
                frm = new frmDescripcion(ptb7, lblNom7.Text, descripciones[6], precios[6], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom8.Text))
            {
                frm = new frmDescripcion(ptb8, lblNom8.Text, descripciones[7], precios[7], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom9.Text))
            {
                frm = new frmDescripcion(ptb9, lblNom9.Text, descripciones[8], precios[8], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom10.Text))
            {
                frm = new frmDescripcion(ptb10, lblNom10.Text, descripciones[9], precios[9], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom11.Text))
            {
                frm = new frmDescripcion(ptb11, lblNom11.Text, descripciones[10], precios[10], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom12.Text))
            {
                frm = new frmDescripcion(ptb12, lblNom12.Text, descripciones[11], precios[11], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom13.Text))
            {
                frm = new frmDescripcion(ptb13, lblNom13.Text, descripciones[12], precios[12], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom14.Text))
            {
                frm = new frmDescripcion(ptb14, lblNom14.Text, descripciones[13], precios[13], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom15.Text))
            {
                frm = new frmDescripcion(ptb15, lblNom15.Text, descripciones[14], precios[14], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom16.Text))
            {
                frm = new frmDescripcion(ptb16, lblNom16.Text, descripciones[15], precios[15], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom17.Text))
            {
                frm = new frmDescripcion(ptb17, lblNom17.Text, descripciones[16], precios[16], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom18.Text))
            {
                frm = new frmDescripcion(ptb18, lblNom18.Text, descripciones[17], precios[17], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom19.Text))
            {
                frm = new frmDescripcion(ptb19, lblNom19.Text, descripciones[18], precios[18], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (!existe(lblNom20.Text))
            {
                frm = new frmDescripcion(ptb20, lblNom20.Text, descripciones[19], precios[19], id_Usuario);
                frm.ShowDialog();
                cuantosProducto();
            }
            else
                MessageBox.Show("Ya agregaste este articulo", "Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Muestra error);
        }
#endregion

        #region Filtros
        private void radioButton1_Click(object sender, EventArgs e)
        {
            setConsulta(idCategoria, "Precio ASC");
            tssl1.Text = "..::Producutos de la categoria " + categoria + " ordenados del precio mas bajo al mas alto::..";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            setConsulta(idCategoria, "Precio DESC");
            tssl1.Text = "..::Producutos de la categoria " + categoria + " ordenados del precio mas alto al mas bajo::..";
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            setConsulta(idCategoria, "Nombre ASC");
            tssl1.Text = "..::Producutos de la categoria " + categoria + " ordenados de la A a la Z::..";
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            setConsulta(idCategoria, "Nombre DESC");
            tssl1.Text = "..::Producutos de la categoria " + categoria + " ordenados de la Z a la A::..";
        }
        #endregion
        #region ProductosExistentes
        public void cuantosProducto()
        {
            cuantosHay = 0;
            try
            {
                decla.Instruccion.CommandText = "select id_Carrito from carrito where id_Cliente = '" + id_Usuario + "';";  //Se pasa como una instruccion
                decla.Conexion.Open();  
                decla.Lector = decla.Instruccion.ExecuteReader(); 
                if (decla.Lector.HasRows) 
                    while (decla.Lector.Read())  
                        cuantosHay++;
                decla.Conexion.Close();  
            }
            catch (Exception ex)  
            {
                decla.Conexion.Close();  
                MessageBox.Show(ex.Message.ToString(), "Error Love laivu", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Se muestra el error
            }
            lblCuantosProductos.Text = "Tienes " + cuantosHay.ToString() + " productos";
        }  //Conocer cuantos productos hay en el carrito por usuarios
        #endregion
        private void ptbVenta_Click(object sender, EventArgs e)
        {
            frmVenta frm = new frmVenta(id_Usuario);
            this.Hide();
            frm.ShowDialog();
            cuantosProducto();
            this.Show();
        }  //Vamos a ventas

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltroBuscar();
        }  //Boton para pedir metodo buscar segun textbox

        public void FiltroBuscar()
        {
            if (txtBuscar.Text != "")
            {
                for (int i = 0; i < 20; i++)
                {
                    arrayPicture[i].ImageLocation = "";
                    etiquetasPrecio[i].Text = "";
                    etiquetasNombre[i].Text = "";
                }
                setCatalogo("SELECT Nombre, Descripcion, Precio, RutaImagen FROM productos WHERE Nombre LIKE '" + txtBuscar.Text + "%'ORDER BY Precio ASC");
                for (int i = 0; i < 20; i++)
                    if (arrayPicture[i].ImageLocation == "")
                        arrayPanel[i].Visible = false;
                tssl1.Text = "..::Producutos de todas las categorias segun tu filtro por letras::..";
            }
            else
            {
                setOrdenacion();
                for (int i = 0; i < 20; i++)
                    arrayPanel[i].Visible = true;
            }
        }  //Metodo para buscar segun textbox

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) //Si la tecla presionada es enter
                FiltroBuscar(); //Llamar al metodo Buscar
        }  //Si enter pedir metodo buscar segun textbox

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssl2.Text = DateTime.Now.ToString();
        }
        
        public bool existe(string nombre)
        {
            try
            {
                decla.Instruccion.CommandText = "select Nombre from carrito where Nombre = '" + nombre + "' and id_Cliente = '" + id_Usuario + "'";  //Se pasa como una instruccion
                decla.Conexion.Open();  //Se habre la conexion
                decla.Lector = decla.Instruccion.ExecuteReader(); //Se pasa la instruccion para leer
                if (decla.Lector.HasRows) //Si tiene filas
                    Encontrado = true;  //Se establece bool a true
                else  //Si no
                    Encontrado = false; //Se establece bool a false
                decla.Lector.Close();  //Se cierra Lector
                decla.Conexion.Close();  //Se cierra conexion
            }
            catch (Exception e)  //Si hay error
            {
                decla.Conexion.Close();  //Se cierra conexion
                MessageBox.Show(e.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Se muestra el error
            }
            if (Encontrado == false)  //Si no se encontro usuario
                return false;  //Muestra error
            else
                return true;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            idCategoria = 6;
            categoria = "Figma";
            setOrdenacion();
        }
    }
}

