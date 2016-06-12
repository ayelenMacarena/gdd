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
            dataGridView1.Visible = false;
            


        }

        private void dateFromLabel_DateChanged(object sender, EventArgs e)
        {





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
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand buscarFacturas = new SqlCommand("LA_PETER_MACHINE.buscarFacturas", conexion);
            buscarFacturas.CommandType = CommandType.StoredProcedure;

            if (dateFromLabel.Text == String.Empty)
            {
                buscarFacturas.Parameters.AddWithValue("@fechaDesde", DBNull.Value);
            }
            else
            {
                buscarFacturas.Parameters.AddWithValue("@fechaDesde", dateFromLabel.Text);
            }
            

            if (dateToLabel.Text == String.Empty)
            {
                buscarFacturas.Parameters.AddWithValue("@fechaHasta", DBNull.Value);
            }
            else
            {
                buscarFacturas.Parameters.AddWithValue("@fechaHasta", dateToLabel.Text);
            }
            
            if (priceFromLabel.Text == String.Empty)
            {
                buscarFacturas.Parameters.AddWithValue("@precioDesde", DBNull.Value);
            }
            else
            {
                buscarFacturas.Parameters.AddWithValue("@precioDesde", priceFromLabel.Text);
            }
           
            if (priceToLabel.Text == String.Empty)
            {
                buscarFacturas.Parameters.AddWithValue("@precioHasta", DBNull.Value);
            }
            else
            {
                buscarFacturas.Parameters.AddWithValue("@precioHasta", priceToLabel.Text);
            }
            
            if (detailsLabel.Text == String.Empty)
            {
                buscarFacturas.Parameters.AddWithValue("@descripcion", DBNull.Value);
            }
            else
            {
                buscarFacturas.Parameters.AddWithValue("@descripcion", detailsLabel.Text);
            }
            
            if (salesmanComboBox.Text == String.Empty)
            { buscarFacturas.Parameters.AddWithValue("@vendedor",  DBNull.Value); }
            else { buscarFacturas.Parameters.AddWithValue("@vendedor", salesmanComboBox.Text); }

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(buscarFacturas);
            adapter.Fill(table);


            
            

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

 
 
    }
}
