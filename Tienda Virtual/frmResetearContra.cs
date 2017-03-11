using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace Tienda_Virtual
{
    public partial class frmResetearContra : Form
    {
        public frmResetearContra()
        {
            InitializeComponent();
        }

        Declaraciones decla = new Declaraciones();  //Objeto del tipo de la clase Declaraciones
        Captcha cap;
        SpeechSynthesizer reader = new SpeechSynthesizer();
        bool Encontrado = false;

        private void btnResetear_Click(object sender, EventArgs e)
        {
            try
            {
                buscar();
                if (Encontrado)
                {
                    if (txtNewPassword.Text == txtRepeatPassword.Text)
                    {
                        if (txtCaptcha.Text == cap.code)
                        {
                            decla.Instruccion.Parameters.AddWithValue("Contra", txtNewPassword.Text);
                            decla.Instruccion.Parameters.AddWithValue("TelefonoActualiza", txtNumero.Text);
                            if (decla.dosomething("Update usuario set Contra = SHA2(@Contra,512)Where Telefono = @TelefonoActualiza"))  //Llama al metodo que ejecuta acciones en la base de datos
                            {
                                MessageBox.Show("Sus datos fueron actualizados, ahora ya puede comprar", "Contraseña actualizada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);  //Se muestra mensaje de que se realizo todo
                                this.Close();
                            }
                            else  //Si existe algun problema
                                MessageBox.Show("Existe algun tipo de problema, cierre y abra otra ves el programa", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Stop);  //Se muestra mensaje de error
                        }
                        else
                            MessageBox.Show("Lo sentimos, pero la captcha es incorrecto, vuelve a escribirla", "Captcha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Lo sentimos, pero las contraseñas no coinciden, vuelve a escribirlas", "Contraseñas incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Lo setimos, el numero no se encuentra registrado", "Numero no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)  //Si hay error
            {
                this.Close();
                MessageBox.Show(ex.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Se muestra el error
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
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

        public void buscar()
        {
            try
            {
                decla.Instruccion.Parameters.AddWithValue("TelefonoBusca", txtNumero.Text);
                decla.Instruccion.CommandText = "select Correo from usuario where Telefono = @TelefonoBusca";  //Se pasa como una instruccion
                decla.Conexion.Open();  //Se habre la conexion
                decla.Lector = decla.Instruccion.ExecuteReader(); //Se pasa la instruccion para leer
                if (decla.Lector.HasRows) //Si tiene filas
                    Encontrado = true;
                decla.Lector.Close();  //Se cierra Lector
                decla.Conexion.Close();  //Se cierra conexion
            }
            catch (Exception ex)  //Si hay error
            {
                decla.Conexion.Close();
                MessageBox.Show(ex.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Se muestra el error
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void frmResetearContra_Load(object sender, EventArgs e)
        {
            txtCaptcha.CharacterCasing = CharacterCasing.Upper;
            CargarCaptchaImage();
        }

        private void CargarCaptchaImage()
        {
            cap = new Captcha();
            pictureBox2.Image = cap.bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarCaptchaImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reader.Dispose();
            reader = new SpeechSynthesizer();
            for (int i = 0; i < 7; i++)
            {
                reader.SpeakAsync(cap.captcha2[i]);
            }
        }

        private void lnlObtenerNumeroCel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmObtenerNumeroCel frm = new frmObtenerNumeroCel();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
