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

namespace WindowsFormsApplication1.Listado_Estadistico
{
    public partial class ListadoXMonto : Form
    {

        String inicio;
        String fin;
        public ListadoXMonto(String año, String trimestre)
        {
            InitializeComponent();
            label1.Text = año;
            label2.Text = trimestre;
            switch (label2.Text)
            {
                case "1º Trimestre": inicio = "01/01";
                    fin = "31/03";
                    break;
                case "2º Trimestre": inicio = "01/04";
                    fin = "30/06";
                    break;
                case "3º Trimestre": inicio = "01/07";
                    fin = "30/9";
                    break;
                case "4º Trimestre": inicio = "01/10";
                    fin = "31/12";
                    break;
            }
            fin = string.Concat(fin, "/", año);
            inicio = string.Concat(inicio, "/", año);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            SqlConnection conexion = conectionDB.getConnection();

            SqlCommand cmd = new SqlCommand("select * from LA_PETER_MACHINE.topDeVendedoresPorMontoFacturado(@fechaInicio,@fechaFin)");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@fechaFin", SqlDbType.NVarChar);
            cmd.Parameters["@fechaFin"].Value = fin;
            cmd.Parameters.Add("@fechaInicio", SqlDbType.NVarChar);
            cmd.Parameters["@fechaInicio"].Value = inicio;
            conexion.Open();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ElegirListado vent = new ElegirListado(label1.Text,label2.Text);
            this.Hide();
            vent.ShowDialog();
            this.Close();
        }
    }
}
