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
    public partial class ListadoVendXProdSinVend : Form
    {
        String inicio;
        String fin;
       
        public ListadoVendXProdSinVend(String año, String trimestre)
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

            SqlConnection conexion = conectionDB.getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            SqlDataReader reader;
            cmd.CommandText = "select visi_descripcion  from LA_PETER_MACHINE.visibilidad";
            conexion.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                SqlConnection conexion = conectionDB.getConnection();
           
                SqlCommand cmd = new SqlCommand("select * from LA_PETER_MACHINE.topDeProductosNoVendidos(@fechaInicio,@fechaFin,@visibilidad)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexion;
       
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.Parameters.Add("@fechaFin", SqlDbType.NVarChar);
                cmd.Parameters["@fechaFin"].Value = fin;
                cmd.Parameters.Add("@fechaInicio", SqlDbType.NVarChar);
                cmd.Parameters["@fechaInicio"].Value = inicio;
                cmd.Parameters.Add("@visibilidad", SqlDbType.NVarChar);
                cmd.Parameters["@visibilidad"].Value = comboBox1.Text;
                conexion.Open();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
           
            }
            else { MessageBox.Show("Debe ingresar un tipo de visibilidad"); }
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
