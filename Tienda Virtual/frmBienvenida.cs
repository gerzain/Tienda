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
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (ProgressBar1.Value == 100)
            {
                this.Opacity -= 0.07;
                if (this.Opacity == 0.0)
                {
                    timer1.Stop();
                   // frmFactura frm = new frmLogin();
                    frmLogin frm = new frmLogin();
                    
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            else if (ProgressBar1.Value == 20)
            {
               // Label3.Text = "Abiendo .......";
                ProgressBar1.Value += 5;
            }
            else if (ProgressBar1.Value == 40)
            {
                //Label3.Text = "Cargando componenetes  .......";
                ProgressBar1.Value += 5;
            }
            else if (ProgressBar1.Value == 60)
            {
                //Label3.Text = "Gracias por esperar  .......";
                ProgressBar1.Value += 5;
            }
            else if (ProgressBar1.Value == 80)
            {
              //  Label3.Text = "Ya casi esta listo .......";
                ProgressBar1.Value += 5;
            }
            else
                ProgressBar1.Value += 3;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
