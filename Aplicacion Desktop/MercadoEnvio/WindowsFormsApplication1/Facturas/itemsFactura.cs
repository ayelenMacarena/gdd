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
    public partial class itemsFactura : Form
    {
        public itemsFactura(DataGridViewRow filaSeleccionada)
        {
            InitializeComponent();
            DataGridViewRow fila;
            fila = filaSeleccionada;
            String facturaNumero = filaSeleccionada.Cells["fact_num"].Value.ToString();
            SqlConnection conexion = conectionDB.getConnection();
            DataTable table = new DataTable();

            conexion.Open();
            string items = "select * from LA_PETER_MACHINE.item_factura where item_num_factura = " + facturaNumero;

            SqlCommand buscarFacturas = new SqlCommand(items, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(buscarFacturas);
            adapter.Fill(table);
            dataGridView1.DataSource = table;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
