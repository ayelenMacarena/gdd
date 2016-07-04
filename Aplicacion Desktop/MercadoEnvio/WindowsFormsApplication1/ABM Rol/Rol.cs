using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class Rol : Form
    {
        public Rol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaRol alta = new AltaRol();
            this.Hide();
            alta.MdiParent = this.MdiParent;
            alta.Show();
            alta.Location = new Point(0, 49);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoRol listado = new ListadoRol();
            this.Hide();
            listado.MdiParent = this.MdiParent;
            listado.Show();
            listado.Location = new Point(0, 49);
            this.Close();
        }

    
    }
}
