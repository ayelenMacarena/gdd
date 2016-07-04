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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
