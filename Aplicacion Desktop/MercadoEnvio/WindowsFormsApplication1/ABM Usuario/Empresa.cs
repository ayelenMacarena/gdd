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
            alt.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoDeUsuarios list = new ListadoDeUsuarios();
            this.Hide();
            list.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Usuario usu = new Usuario();
            this.Hide();
            usu.ShowDialog();
            this.Close();
        }
    }
}
