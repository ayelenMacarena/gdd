﻿using System;
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
        public tiposDePublicacion()
        {
            InitializeComponent();
        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {

            Generar_Publicación.generarPublicacion generarPublicacionCompra = new Generar_Publicación.generarPublicacion();
            this.Hide();
            generarPublicacionCompra.ShowDialog();
            this.Close();
        }
    }
}
