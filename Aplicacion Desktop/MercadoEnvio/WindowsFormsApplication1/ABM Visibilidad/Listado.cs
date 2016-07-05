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
namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class Listado : Form
    {
        decimal codigo;
        decimal precio;
        decimal porcentaje;
        int envio;
        string desc;
        public Listado()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Visibilidad visibilidad = new Visibilidad();
            this.Hide();
            visibilidad.MdiParent = this.MdiParent;
            visibilidad.Show();
            visibilidad.Location = new Point(0, 49);
            this.Close();
        }

  

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Visibilidad visibilidad = new Visibilidad();
            this.Hide();
            visibilidad.MdiParent = this.MdiParent;
            visibilidad.Show();
            visibilidad.Location = new Point(0, 49);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            SqlConnection conexion = conectionDB.getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            desc = textBox1.Text;
            cmd.CommandText = "select visi_cod,visi_precio,visi_porcentaje,visi_envio,visi_descripcion from LA_PETER_MACHINE.visibilidad where (visi_descripcion LIKE '%' + @desc + '%')";
            cmd.Parameters.Add("@desc", SqlDbType.NVarChar);
            cmd.Parameters["@desc"].Value = desc;
            conexion.Open();
            adapter.Fill(table);
            if (table.Rows.Count != 0)
            {
                dataGridView1.DataSource = table;
                dataGridView1.Columns[0].HeaderText = "Codigo";
                dataGridView1.Columns[1].HeaderText = "Precio";
                dataGridView1.Columns[2].HeaderText = "Porcentaje";
                dataGridView1.Columns[3].HeaderText = "Envio";
                dataGridView1.Columns[4].HeaderText = "Descripcion";
                this.seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
                this.seleccionar.Text = "Seleccionar";
                this.seleccionar.UseColumnTextForButtonValue = true;
                this.seleccionar.HeaderText = "Seleccionar";
                this.seleccionar.Name = "Seleccionar";
                this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.seleccionar});
            }
            else {
                MessageBox.Show("No se obtuvieron resultados con los filtros establecidos");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool enteroABool(int num)
        {
            if (num == 0) { return true; }
            else { return false; }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (enteroABool(String.Compare(senderGrid.Columns[e.ColumnIndex].HeaderText, "Seleccionar")) && e.RowIndex >= 0)
            {
                decimal.TryParse(senderGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString(), out codigo);
                decimal.TryParse(senderGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString(), out precio);
                decimal.TryParse(senderGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString(), out porcentaje);
                int.TryParse(senderGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString(), out envio);
                Selección select = new Selección(codigo,precio,porcentaje,envio,senderGrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                this.Hide();
                select.MdiParent = this.MdiParent;
                select.Show();
                select.Location = new Point(0, 49);
                this.Close();
            }
        }
      
    
public  DataGridViewButtonColumn seleccionar { get; set; }

private void button1_Click(object sender, EventArgs e)
{
    dataGridView1.DataSource = null;
    dataGridView1.Rows.Clear();
    dataGridView1.Columns.Clear();
}

public DataGridViewButtonColumn habilitar { get; set; }

public DataGridViewButtonColumn deshabilitar { get; set; }
    }
}
