using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente clie = new Cliente();
            this.Hide();
            clie.MdiParent = this.MdiParent;
            clie.Show();
            clie.Location = new Point(0, 49);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empresa empr = new Empresa();
            this.Hide();
            empr.MdiParent = this.MdiParent;
            empr.Show();
            empr.Location = new Point(0, 49);
            this.Close();
        }
    }
}
