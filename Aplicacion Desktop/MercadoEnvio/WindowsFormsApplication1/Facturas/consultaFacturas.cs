using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1.Facturas
{
    public partial class consultaFacturas : Form
    {
        int registrosPorPagina = 10;
        int numeroPagina = 1;
        int cantidadDePaginas;

        public consultaFacturas()
        {
            InitializeComponent();

            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            SqlDataReader reader;
            cmd.CommandText = "select pers_username from LA_PETER_MACHINE.persona";

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                salesmanComboBox.Items.Add(reader[0]);
            }
            conexion.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.dateFromLabel.Clear();
            this.dateToLabel.Clear();
            this.priceFromLabel.Clear();
            this.priceToLabel.Clear();
            this.detailsLabel.Clear();
            salesmanComboBox.Text = "";

            button4.Enabled = false;
            //Grid_ListaFacturas.Visible = false;          
            Grid_ListaFacturas.DataSource = null;

            this.labelNroPagina.Text = String.Empty;
            this.label_InfoPagina_CO.Text = "Paginas";

        }


        private void calendarFrom_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateFromLabel.Text = calendarFrom.SelectionRange.Start.ToShortDateString();
            calendarFrom.Visible = false;
        }

        
        private void dateToLabel_onClick(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            calendarFrom.Visible = true;
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateToLabel.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            monthCalendar1.Visible = false;
        }


        private void dateFromLabel_Click(object sender, EventArgs e)
        {
            calendarFrom.Visible = true;
        }


        private void dateToLabel_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            numeroPagina = 1;
            mostrarFacturas();
            button4.Enabled = true;
        }

        private void mostrarFacturas()
        {
            DataTable filasAMostrar = Logica_Facturas.Mostrar(dateFromLabel.Text, dateToLabel.Text, priceFromLabel.Text, priceToLabel.Text, detailsLabel.Text, salesmanComboBox.Text, registrosPorPagina, numeroPagina);            

            Grid_ListaFacturas.DataSource = filasAMostrar;

            var cantidadDeFilas = (Logica_Facturas.tamanio(dateFromLabel.Text, dateToLabel.Text, priceFromLabel.Text,
                                priceToLabel.Text, detailsLabel.Text, salesmanComboBox.Text, registrosPorPagina)).Rows.Count;

            cantidadDePaginas = cantidadDeFilas / registrosPorPagina;

            if (cantidadDePaginas % registrosPorPagina > 0)
            {
                cantidadDePaginas = cantidadDePaginas + 1;
            }
            else
            {
                cantidadDePaginas = 1;
            }

            this.labelNroPagina.Text = String.Format("{0}", numeroPagina);
            this.label_InfoPagina_CO.Text = String.Format("Paginas {0}", cantidadDePaginas);
        }            
            

        private void dateFromLabel_Validating(object sender, CancelEventArgs e)
        {
            DateTime fecha;
            if (!DateTime.TryParse(dateFromLabel.Text, out fecha))
            {
                e.Cancel = true;
                MessageBox.Show("Coloque por favor un rango de fecha válido");
                return;
            }
        }


        private void dateToLabel_Validating(object sender, CancelEventArgs e)
        {
            DateTime fecha;
            if (!DateTime.TryParse(dateToLabel.Text, out fecha))
            {
                e.Cancel = true;
                MessageBox.Show("Coloque por favor un rango de fecha válido");
                return;
            }
        }

        private void priceFromLabel_Validating(object sender, CancelEventArgs e)
        {
            Int32 unInt;
            if (!Int32.TryParse(priceFromLabel.Text, out unInt))
            {
                
                MessageBox.Show("Valor inválido en precio desde");
                return;
            }
        }

        private void priceToLabel_Validating(object sender, CancelEventArgs e)
        {
            Int32 unInt;
            if (!Int32.TryParse(priceToLabel.Text, out unInt))
            {

                MessageBox.Show("Valor inválido en precio hasta");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkUltimaPag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            numeroPagina = cantidadDePaginas;
            mostrarFacturas();
        }

        private void linkPrimeraPag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            numeroPagina = 1;
            mostrarFacturas();
        }

        private void label_Anterio_CO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (numeroPagina > 1)
            {
                numeroPagina = numeroPagina - 1;
                mostrarFacturas();
            }
        }

        private void label_Siguiente_CO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (numeroPagina < cantidadDePaginas)
            {
                numeroPagina = numeroPagina + 1;
                mostrarFacturas();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Grid_ListaFacturas.CurrentRow != null)
            {
                DataGridViewRow filaSeleccionada = Grid_ListaFacturas.CurrentRow;
                (new Facturas.itemsFactura(filaSeleccionada)).Show();
            }


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = Grid_ListaFacturas.CurrentRow;
            (new Facturas.itemsFactura(filaSeleccionada)).Show();


        }

 
 
    }
}
