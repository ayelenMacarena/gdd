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
            SqlConnection conexion = conectionDB.getConnection();
            String facturaNumero = filaSeleccionada.Cells["fact_num"].Value.ToString();
            facturaNumeroLabel.Text = facturaNumero;
            string vendedor = "select pers_username from LA_PETER_MACHINE.persona where pers_id = " + filaSeleccionada.Cells["fact_id_vendedor"].Value.ToString();
            conexion.Open();
            
            SqlCommand miVendedor = new SqlCommand(vendedor, conexion);
            
            SqlDataReader vend = miVendedor.ExecuteReader();


            while (vend.Read())
            {
                vendedorLabel.Text = vend["pers_username"].ToString();
            }

            conexion.Close();
            label5.Text = filaSeleccionada.Cells["fact_fecha"].Value.ToString();

            formaDePago.Text = filaSeleccionada.Cells["fact_forma_pago"].Value.ToString();

            total.Text = "$ " + filaSeleccionada.Cells["fact_total"].Value.ToString();
            
            DataTable table = new DataTable();

            
            string items = "select * from LA_PETER_MACHINE.item_factura where item_num_factura = " + facturaNumero;
            conexion.Open();
            SqlCommand buscarFacturas = new SqlCommand(items, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(buscarFacturas);
            adapter.Fill(table);
            dataGridView1.DataSource = table;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
