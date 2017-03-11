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
    public partial class frmObtenerNumeroCel : Form
    {
        public frmObtenerNumeroCel()
        {
            InitializeComponent();
        }

        Declaraciones decla = new Declaraciones();
        SendEmail email = new SendEmail();
        string numero;

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            try
            {
                decla.Instruccion.Parameters.AddWithValue("Correo", txtCorreo.Text);
                decla.Instruccion.CommandText = "select Telefono from usuario where Correo = @Correo";  //Se pasa como una instruccion
                decla.Conexion.Open();  //Se habre la conexion
                decla.Lector = decla.Instruccion.ExecuteReader(); //Se pasa la instruccion para leer
                if (decla.Lector.HasRows) //Si tiene filas
                    while (decla.Lector.Read())
                    {
                        numero = decla.Lector[0].ToString();
                    }
                decla.Lector.Close();  //Se cierra Lector
                decla.Conexion.Close();  //Se cierra conexion
                if (AccesoInternet())
                {
                    MessageBox.Show("Espere un momento, enviando su número de celular", "Espere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    email.subject = "Detalles de su numero de celular ";
                    email.correoTo = txtCorreo.Text;
                    email.body = "<html>" +
                    "<body>" +
                        "<div id='cuerpo'>" +
                            "<h1>Envio de n&uacute;mero de celular ( " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss") + " )</h1><br>" +
                            "<h2>El numero de su celular es: " + numero + "<br></h2><br>" +
                            "<center><h3>Atte: Departamento de informatica</h3></center><br>" +
                            "<center><img src='http://i.imgur.com/1xTe5hG.png'</center>" +
                        "</div>" +
                        "<style>" +
                            "h3{font-size:15px;}" +
                            "#cuerpo{background-color:#E6E6E6;}" +
                        "</style>" +
                    "</body></html>";
                    email.CreateEmail();
                    if (email.enviado)
                        MessageBox.Show("Te hemos enviado el número de celular a tu correo", "Número enviado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);  //Se muestra mensaje de que se realizo todo
                        //Mandar correo
                }
                else
                    MessageBox.Show("No estas conectado a internet, intentalo mas tarde", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
            catch (Exception ex)  //Si hay error
            {
                decla.Conexion.Close();  //Se cierra conexion
                MessageBox.Show(ex.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Se muestra el error
            }
        }

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
    }
}
