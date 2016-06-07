using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApplication1;

namespace WindowsFormsApplication1.ComprarOfertar
{
    public partial class Listado_ComprarOfertar : Form
    {
        int registrosPorPagina = 15;
        int numeroPagina = 1;
        int cantidadDePaginas;

        int cliente = 39; //Harcodeado, pero deberia recibirlo del login.

        public Listado_ComprarOfertar()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            //Logica_ComprarOfertar.llenarComboRubros(this.comboRubros);
            Mostrar();
        }

        public void Mostrar()
        {
            this.Grid_ComprarOfertar.DataSource = Logica_ComprarOfertar.Mostrar(registrosPorPagina, numeroPagina, cliente);
            cantidadDePaginas = Logica_ComprarOfertar.tamanio(registrosPorPagina,cliente);
            this.labelNroPagina.Text = String.Format("{0}", numeroPagina);
        }

        public void Buscar()
        {
            try
            {
                this.Grid_ComprarOfertar.DataSource = Logica_ComprarOfertar.Buscar(this.textBuscado.Text);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void label_Anterio_CO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (numeroPagina > 1)
            {
                numeroPagina = numeroPagina-1;
                Mostrar();
            }
        }

        private void label_Siguiente_CO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (numeroPagina < cantidadDePaginas)
            {
                numeroPagina = numeroPagina + 1;
                Mostrar();
            }
        }

        private void textBuscado_TextChanged(object sender, EventArgs e)
        {
            if (this.textBuscado.Text == String.Empty)
            {
                this.numeroPagina = 1;
                this.Mostrar();
            }
            else
            {
                this.Buscar();
            }
            
        }

        private void linkPrimeraPag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            numeroPagina = 1;
            Mostrar();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            numeroPagina = cantidadDePaginas;
            Mostrar();
        }
    }
}