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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void consultaFacturas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dateFromLabel.Clear();
            this.dateToLabel.Clear();
            this.priceFromLabel.Clear();
            this.priceToLabel.Clear();
            this.detailsLabel.Clear();

        }

        private void dateFromLabel_DateChanged(object sender, EventArgs e){

            
            

                
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
        private void dateToLabel_TextChanged(object sender, EventArgs e)
        {
            
            

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

        private void salesmanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand buscarFacturas = new SqlCommand("LA_PETER_MACHINE.buscarFacturas", conexion);
            buscarFacturas.CommandType = CommandType.StoredProcedure;
            buscarFacturas.Parameters.AddWithValue("@dateFrom", dateFromLabel.Text);
            buscarFacturas.Parameters.AddWithValue("@dateTo", dateToLabel.Text);
                //TODO: FALTAN VALIDACIONES DE TIPOS
            buscarFacturas.Parameters.AddWithValue("@priceFrom", priceFromLabel.Text);
            buscarFacturas.Parameters.AddWithValue("@priceTo", priceToLabel.Text);
            buscarFacturas.Parameters.AddWithValue("@detalle", detailsLabel.Text);
            buscarFacturas.Parameters.AddWithValue("@salesman", salesmanComboBox.SelectedItem.ToString());








        }
    }
}
