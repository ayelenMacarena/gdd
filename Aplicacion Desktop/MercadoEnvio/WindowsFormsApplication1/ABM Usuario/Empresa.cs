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
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaEmpresa alt = new AltaEmpresa();
            this.Hide();
            alt.MdiParent = this.MdiParent;
            alt.Show();
            alt.Location = new Point(0, 49);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoDeUsuarios list = new ListadoDeUsuarios();
            this.Hide();
            list.MdiParent = this.MdiParent;
            list.Show();
            list.Location = new Point(0, 49);
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Usuario usu = new Usuario();
            this.Hide();
            usu.MdiParent = this.MdiParent;
            usu.Show();
            usu.Location = new Point(0, 49);
            this.Close();
        }
    }
}
