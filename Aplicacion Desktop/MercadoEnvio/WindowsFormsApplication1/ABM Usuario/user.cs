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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio back = new Inicio();
            this.Hide(); //La oculto
            back.ShowDialog(); //voy a la proxima
            this.Close(); // Cuando cierro 'back' vuelve y cierra esta
            
            
        }

        private void user_Load(object sender, EventArgs e)
        {

        }
    }
}
