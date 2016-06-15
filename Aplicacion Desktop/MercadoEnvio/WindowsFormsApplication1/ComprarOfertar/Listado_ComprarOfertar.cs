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
        int registrosPorPagina = 12;
        int numeroPagina = 1;
        int cantidadDePaginas;
        List<String> filtroRubros;

        String usuario;

        int cliente;

        public Listado_ComprarOfertar(String usuarioParam)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            usuario = usuarioParam;

            cliente = Logica_ComprarOfertar.ObtenerIdCliente(usuario);

            this.buttonComprar.Visible = false;
            this.buttonOfertar.Visible = false;

            this.buttonComprar.Enabled = false;
            this.buttonOfertar.Enabled = false;
            
            this.labelRubrosSeleccionados.Text = String.Format("");


            filtroRubros = new List<String>();
            Logica_ComprarOfertar.llenarComboRubros(this.comboRubros);            
        }


        public void Mostrar()
        {
            Grid_ComprarOfertar.DataSource = null;
            var tipo = comboTipo.Text;

            DataTable filasAMostrar = Logica_ComprarOfertar.Mostrar(registrosPorPagina, numeroPagina, cliente, tipo, textBuscado.Text);

            Grid_ComprarOfertar.DataSource = filasAMostrar;
            Grid_ComprarOfertar.ClearSelection();

            if (tipo == "COMPRAS")
            {
                buttonComprar.Visible = true;
            }

            if (tipo == "SUBASTAS")
            {
                buttonOfertar.Visible = true;
            }        

            cantidadDePaginas = Logica_ComprarOfertar.tamanio(registrosPorPagina, cliente, tipo,textBuscado.Text); ;

            this.labelNroPagina.Text = String.Format("{0}", numeroPagina);
            this.label_InfoPagina_CO.Text = String.Format("Paginas {0}", cantidadDePaginas);
            this.Grid_ComprarOfertar.Columns["publicacion_id"].Visible = false;
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


        private void linkPrimeraPag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            numeroPagina = 1;
            Mostrar();
        }


        private void linkUltimaPag_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            numeroPagina = cantidadDePaginas;
            Mostrar();
        }


        private void buttonAgregarRubro_Click(object sender, EventArgs e)
        {
            if (!filtroRubros.Contains(comboRubros.Text))
            {
                filtroRubros.Add(comboRubros.Text);
                this.labelRubrosSeleccionados.Text += (comboRubros.Text + " - ");
            }
        }


        private void buttonLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            labelRubrosSeleccionados.Text = "";
            textBuscado.Text = "";
            comboRubros.Text = "";
            filtroRubros = new List<string>();
            Grid_ComprarOfertar.DataSource = null;
        }


        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.buttonComprar.Visible = false;
            this.buttonOfertar.Visible = false;

            this.buttonComprar.Enabled = false;
            this.buttonOfertar.Enabled = false;

            if (comboTipo.Text == String.Empty)
            {
                MessageBox.Show("Se debe indicar el tipo de publicacion a buscar.");
                return;
            }

            this.numeroPagina = 1;
            this.Mostrar();          
        }


        private void Grid_ComprarOfertar_SelectionChanged(object sender, EventArgs e)
        {
            var tipo = comboTipo.Text;

            if (tipo == "COMPRAS")
            {
                buttonComprar.Enabled = true;
            }

            if (tipo == "SUBASTAS")
            {
                buttonOfertar.Enabled = true;
            }        
        }


        private void buttonComprar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = Grid_ComprarOfertar.CurrentRow;
            (new ComprarOfertar.Comprar(filaSeleccionada, this)).Show();
        }

        private void buttonOfertar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = Grid_ComprarOfertar.CurrentRow;
            (new ComprarOfertar.Ofertar(filaSeleccionada, this)).Show();

        }


    }
}