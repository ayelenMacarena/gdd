using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class tiposDePublicacion : Form
    {
        string username;

        public tiposDePublicacion(string usuario)
        {
            InitializeComponent();
            username = usuario;
        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {

            Generar_Publicación.generarPublicacionCompra generarPublicacionCompra = new Generar_Publicación.generarPublicacionCompra(this.username);
            this.Hide();
            generarPublicacionCompra.MdiParent = this.MdiParent;
            generarPublicacionCompra.Show();
            generarPublicacionCompra.Location = new Point(0, 49);
            this.Close();
        }

        private void buttonSubasta_Click(object sender, EventArgs e)
        {

            Generar_Publicación.generarPublicacionSubasta generarPublicacionSubasta = new Generar_Publicación.generarPublicacionSubasta(this.username);
            this.Hide();
            generarPublicacionSubasta.MdiParent = this.MdiParent;
            generarPublicacionSubasta.Show();
            generarPublicacionSubasta.Location = new Point(0, 49);
            this.Close();

        }
    }
}
