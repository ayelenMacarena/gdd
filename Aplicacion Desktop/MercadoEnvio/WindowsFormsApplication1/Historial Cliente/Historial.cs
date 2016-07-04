using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Historial_Cliente
{
    public partial class Historial : Form
    {
        string usuario;

        int registrosPorPagina = 12;
        int numeroPagina = 1;
        int cantidadDePaginas;
        int idUsuario;
        int tipo;

        public Historial(string username)
        {
            InitializeComponent();
            usuario = username;
            idUsuario = Logica_Historial.ObtenerIdUsuario(username); 
            this.labelCliente.Text = usuario;
            this.textBoxCalificacionPromedio.Text = Convert.ToString(Logica_Historial.ObtenerCalificacionProm(idUsuario));
            this.textBoxPorCalificar.Text = Convert.ToString(Logica_Historial.ObtenerPendientesDeCalificacion(idUsuario));
        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            tipo = 1;
            // El 1 son las Compras Inmediatas
            numeroPagina = 1;
            this.mostrar(tipo);
        }

        private void buttonOfertas_Click(object sender, EventArgs e)
        {
            // El 2 son las Subastas
            tipo = 2;
            numeroPagina = 1;
            this.mostrar(tipo);
        }

        private void mostrar(int tipo)
        {
            dataGridView_Historial.DataSource = null;

            DataTable filasAMostrar = Logica_Historial.Mostrar(registrosPorPagina, numeroPagina, usuario, tipo);

            dataGridView_Historial.DataSource = filasAMostrar;
            dataGridView_Historial.ClearSelection();
            
            cantidadDePaginas = Logica_Historial.tamanio(registrosPorPagina, usuario, tipo); ;
            
            this.labelNroPagina.Text = String.Format("{0}", numeroPagina);
            this.label_InfoPagina_CO.Text = String.Format("Paginas {0}", cantidadDePaginas);         
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView_Historial.DataSource = null;
            this.labelNroPagina.Text = String.Empty;
            this.label_InfoPagina_CO.Text = String.Empty;
        }

        private void linkPrimeraPag_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            numeroPagina = 1;
            mostrar(tipo);
        }

        private void linkUltimaPag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            numeroPagina = cantidadDePaginas;
            mostrar(tipo);
        }

        private void label_Anterio_CO_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (numeroPagina > 1)
            {
                numeroPagina = numeroPagina - 1;
                mostrar(tipo);
            }
        }

        private void label_Siguiente_CO_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (numeroPagina < cantidadDePaginas)
            {
                numeroPagina = numeroPagina + 1;
                mostrar(tipo);
            }
        }


    }
}
