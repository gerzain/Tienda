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
    public partial class frmDescripcion : Form
    {
        public frmDescripcion(PictureBox imagen_Recivida, string nombre_Recivido, string descripcion_Recivida, double precio_Recivido, int id_Cliente_Recivido)
        {
            InitializeComponent();
            descripcionform = descripcion_Recivida;
            precioformn = precio_Recivido;
            id_Usuario = id_Cliente_Recivido;
            nombre = nombre_Recivido;
            imagen = imagen_Recivida;
        }

        #region Variables importantes
        Declaraciones decla = new Declaraciones();  //Objeto del tipo de la clase Declaraciones
        PictureBox imagen;
        bool enRango;
        string descripcionform, nombre;
        double precioformn;
        int id_Usuario, piesas;
        #endregion

        private void frmDescripcion_Load(object sender, EventArgs e)
        {
            lblDescripcion.Text = descripcionform;
            this.Width = (lblDescripcion.Size.Width+90);
            //pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
            //lblNombre.Left = (this.ClientSize.Width - lblNombre.Width) / 2;
            //lblPrecio.Left = (this.ClientSize.Width - lblPrecio.Width) / 2;
           // lblDescripcion.Left = (this.ClientSize.Width - lblDescripcion.Width) / 2;
            //panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            btnAgregar.Left = (this.ClientSize.Width - btnAgregar.Width) / 2;
            lblPrecio.Text = '$'+precioformn.ToString();
            lblNombre.Text = nombre;
            pictureBox1.ImageLocation = imagen.ImageLocation;
            txtCantidad.Select();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();            
        }
      #region VisualizarProducto
        public void agregar()
        {
            try
            {
                decla.Conexion.Close();  //Se habre la conexion
                decla.Instruccion.CommandText = "select Productos from almacen WHERE Nombre = '" + nombre + "'";  //Se pasa como una instruccion
                decla.Conexion.Open();  //Se habre la conexion
                decla.Lector = decla.Instruccion.ExecuteReader(); //Se pasa la instruccion para leer
                if (decla.Lector.HasRows) //Si tiene filas
                {
                    while (decla.Lector.Read())  //Mientras existan filas
                    {
                        //MessageBox.Show(Convert.ToString(decla.Lector["Cantidad"]));
                        if ((Convert.ToInt32(decla.Lector[0])) > Convert.ToInt32(txtCantidad.Text))
                            enRango = true;
                        else if ((Convert.ToInt32(decla.Lector[0]) - 1) <= Convert.ToInt32(txtCantidad.Text))
                        {
                            piesas = (Convert.ToInt32(decla.Lector[0]) - 1);
                            enRango = false;
                        }
                    }
                }
                decla.Lector.Close();  //Se cierra Lector
                decla.Conexion.Close();  //Se cierra conexion
                if (enRango)
                {
                    decla.Instruccion.Parameters.AddWithValue("Nombre", nombre);
                    decla.Instruccion.Parameters.AddWithValue("Descripcion", descripcionform);
                    decla.Instruccion.Parameters.AddWithValue("Precio", precioformn);
                    decla.Instruccion.Parameters.AddWithValue("Cantidad", txtCantidad.Text);
                    decla.Instruccion.Parameters.AddWithValue("Usuario", id_Usuario);
                    if (decla.dosomething("INSERT INTO carrito(Nombre, Descripcion, Precio, TotalProducto, id_Cliente) VALUES (@Nombre,@Descripcion,@Precio,@Cantidad,@Usuario)"))  //Llama al metodo que ejecuta acciones en la base de datos
                        MessageBox.Show("Producto agregado al carrito", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);  //Se muestra mensaje de que se realizo todo
                    else  //Si existe algun problema
                        MessageBox.Show("Existe algun tipo de problema, cierre y abra otra ves el programa", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Stop);  //Se muestra mensaje de error
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Puede comprar hasta " + piesas.ToString() + " piesas de este producto", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);  //Muestra error);
                    txtCantidad.Clear();
                    txtCantidad.Select();
                }
            }
            catch (Exception ex)  //Si hay error
            {
                decla.Conexion.Close();  //Se cierra conexion
                MessageBox.Show(ex.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Se muestra el error
            }

        }
#endregion
      #region ValidarCantidadProductoNumerica
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar == (char)Keys.Enter)
                agregar();
        }
    }
        #endregion
}
