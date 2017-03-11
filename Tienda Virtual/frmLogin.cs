using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tienda_Virtual
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region Variables importante
        bool Encontrado = false; 
        Declaraciones decla = new Declaraciones();  
        int id_Cliente = 0;
        #endregion

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Cerrar el formulario cuando se presiona la tecla Esc
            if (keyData == Keys.Escape)
                this.Close();

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #region InicioSesión
        public void Buscar()
        { 
            try
            {
                decla.Instruccion.Parameters.AddWithValue("Correo", txtCorreo.Text);
                decla.Instruccion.Parameters.AddWithValue("Contra", txtContra.Text);
                decla.Instruccion.CommandText = "select id_Usuario from usuario where Correo = @Correo and Contra = @Contra";  //Se pasa como una instruccion
                decla.Conexion.Open();  //Se habre la conexion
                decla.Lector = decla.Instruccion.ExecuteReader(); //Se pasa la instruccion para leer
                if (decla.Lector.HasRows) //Si tiene filas
                    while (decla.Lector.Read())
                    {
                        id_Cliente = Convert.ToInt32(decla.Lector[0]);
                        Encontrado = true;  //Se establece bool a true
                    }
                decla.Lector.Close();  //Se cierra Lector
                decla.Conexion.Close();  //Se cierra conexion
                if (Encontrado)
                {
                    timer1.Stop();
                    frmCatalogo frm = new frmCatalogo(id_Cliente);
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                else if (Encontrado == false)  //Si no se encontro usuario
                {
                    MessageBox.Show("Correo de usuario o contraseña incorrecta.\nPor favor, inténtelo de nuevo", "Error de inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);  //Muestra error
                    txtCorreo.Clear();  //Se limpia textbox usuario
                    txtCorreo.Select();  //Se pone el cursos sobre el textbox usuario
                    txtContra.Clear();  //Se limpia textbox password
                }
               
            }
            catch (MySqlException e)  //Si hay error
            {
                decla.Conexion.Close();  //Se cierra conexion
                MessageBox.Show(e.Message.ToString(), "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Se muestra el error
            }
        }
        #endregion
        #region TextboxEnter
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
                Buscar(); 
        }
        #endregion
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmNuevoCliente frm = new frmNuevoCliente();  
            this.Hide();  
            frm.ShowDialog();  
            this.Show();
            txtCorreo.Select();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmResetearContra frm = new frmResetearContra();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            txtCorreo.Select();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }
    }
}
