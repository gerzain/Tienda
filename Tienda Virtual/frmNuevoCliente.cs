using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tienda_Virtual
{
    public partial class frmNuevoCliente : Form
    {
        public frmNuevoCliente()
        {
            InitializeComponent();
        }

        #region Variables importante
        bool Encontrado = false;
        Declaraciones decla = new Declaraciones();  //Objeto del tipo de la clase Declaraciones
        #endregion

        private void frmNuevoCliente_Load(object sender, EventArgs e)
        {
            txtCurp.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                buscar();
                if (Regex.IsMatch(txtCorreo.Text, "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*"))
                {
                    if (!Encontrado)
                    {
                        if (txtTelefono.Text.Length == 10)
                        {
                            if (txtCurp.Text.Length == 18)
                            {
                                if (txtNewPassword.Text == txtRepeatPassword.Text)
                                {
                                    if (ckbTerminos.Checked)
                                    {
                                        decla.Instruccion.Parameters.AddWithValue("Nombre", txtNombre.Text);
                                        decla.Instruccion.Parameters.AddWithValue("CURP", txtCurp.Text);
                                        decla.Instruccion.Parameters.AddWithValue("Direccion", txtDireccion.Text);
                                        decla.Instruccion.Parameters.AddWithValue("Telefono", txtTelefono.Text);
                                        decla.Instruccion.Parameters.AddWithValue("Correo", txtCorreo.Text);
                                        decla.Instruccion.Parameters.AddWithValue("Contra", txtNewPassword.Text);
                                        if (decla.dosomething("INSERT INTO usuario(Nombre, CURP, Direccion, Telefono, Correo, Contra) VALUES (@Nombre,@CURP,@Direccion,@Telefono,@Correo,@Contra)"))  //Llama al metodo que ejecuta acciones en la base de datos
                                        {
                                            MessageBox.Show("Sus datos fueron guardado, ahora ya puede comprar", "Cliente guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);  //Se muestra mensaje de que se realizo todo
                                            this.Close();
                                        }
                                        else  //Si existe algun problema
                                            MessageBox.Show("Existe algun tipo de problema, cierre y abra otra ves el programa", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Stop);  //Se muestra mensaje de error
                                    }
                                    else
                                        MessageBox.Show("Lo sentimos, tienes que aceptar terminos y condiciones", "Acepta terminos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                    MessageBox.Show("Lo sentimos, pero las contraseñas no coinciden, vuelve a escribirlas", "Contraseñas incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                                MessageBox.Show("De favor ingresa una CURP validad", "CURP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                            MessageBox.Show("De favor ingresa un numero de telefono valido", "Telefono", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Lo setimos, el correo ya esta utilizado", "Correo inutilizable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Lo setimos, lo ingresado no es un correo valido", "Correo icorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)  //Si hay error
            {
                this.Close();
                MessageBox.Show(ex.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Se muestra el error
            }
        }

        public void buscar()
        {
            try
            {
                decla.Instruccion.CommandText = "select Correo from usuario where Correo = '"+txtCorreo.Text+"'";  //Se pasa como una instruccion
                decla.Conexion.Open();  //Se habre la conexion
                decla.Lector = decla.Instruccion.ExecuteReader(); //Se pasa la instruccion para leer
                if (decla.Lector.HasRows) //Si tiene filas
                    Encontrado = true;
                decla.Lector.Close();  //Se cierra Lector
                decla.Conexion.Close();  //Se cierra conexion
            }
            catch (Exception ex)  //Si hay error
            {
                this.Close();
                MessageBox.Show(ex.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Se muestra el error
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void lnklTerminos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCondiciones frm = new frmCondiciones();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        #region Validaciones
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Length == 0)
                this.ValidarErrores.SetError(this.txtNombre, "Porfavor, Ingrese un nombre valido.");
            else
                this.ValidarErrores.SetError(this.txtNombre, "");
        }

        private void txtCurp_Validating(object sender, CancelEventArgs e)
        {
            if (txtCurp.Text.Length < 18)
                this.ValidarErrores.SetError(this.txtCurp, "Porfavor, Ingresa una CURP valida.");
            else
                this.ValidarErrores.SetError(this.txtCurp, "");
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (txtDireccion.Text.Length == 0)
                this.ValidarErrores.SetError(this.txtDireccion, "Porfavor, Ingrese una dirección valida.");
            else
                this.ValidarErrores.SetError(this.txtDireccion, "");
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelefono.Text.Length <10)
                this.ValidarErrores.SetError(this.txtTelefono, "Porfavor, Ingresa un numero de celular valido.");
            else
                this.ValidarErrores.SetError(this.txtTelefono, "");
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCorreo.Text.Length == 0)
                this.ValidarErrores.SetError(this.txtCorreo, "Porfavor, Ingrese un correo valido.");
            else
                this.ValidarErrores.SetError(this.txtCorreo, "");
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPassword.Text.Length == 0)
                this.ValidarErrores.SetError(this.txtNewPassword, "Porfavor, Ingrese una contraseña.");
            else
                this.ValidarErrores.SetError(this.txtNewPassword, "");
        }

        private void txtRepeatPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtRepeatPassword.Text.Length == 0)
                this.ValidarErrores.SetError(this.txtRepeatPassword, "Porfavor, Repita la contraseña.");
            else
                this.ValidarErrores.SetError(this.txtRepeatPassword, "");
        }
        #endregion
    }
}
