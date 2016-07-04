using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rubro
{
    public partial class Selección : Form
    {
        public Selección()
        {
            InitializeComponent();
        }

        private void volverLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rubro rubro = new Rubro();
            this.Hide();
            rubro.MdiParent = this.MdiParent;
            rubro.Show();
            rubro.Location = new Point(0, 49);
            this.Close();
        }
    }
}
