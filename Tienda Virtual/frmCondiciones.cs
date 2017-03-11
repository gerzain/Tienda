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
    public partial class frmCondiciones : Form
    {
        public frmCondiciones()
        {
            InitializeComponent();
        }

        private void btnAcepto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
