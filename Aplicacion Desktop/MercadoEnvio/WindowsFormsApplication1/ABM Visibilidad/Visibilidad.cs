﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class Visibilidad : Form
    {
        public Visibilidad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void listadosToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Alta alta = new Alta();
            this.Hide();
            alta.MdiParent = this.MdiParent;
            alta.Show();
            alta.Location = new Point(0, 49);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listado listado = new Listado();
            this.Hide();
            listado.MdiParent = this.MdiParent;
            listado.Show();
            listado.Location = new Point(0, 49);
            this.Close();
        }
    }
}
