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

namespace WindowsFormsApplication1.Calificar
{
    public partial class Calificar : Form
    {
        int numeroVendedorId;
        int compraId;
        string compraSeleccionada;
        int numeroVendedorSeleccionado;
        int compraIdSeleccionado;
        List<String> listaCompras = new List<String>();
        List<int> listaVendedoresId = new List<int>();
        List<int> listaComprasId = new List<int>();
        int estrellas;

        public Calificar(String username)
        {
            InitializeComponent();
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand buscarCompras = new SqlCommand("LA_PETER_MACHINE.buscarComprasSinCalificar", conexion);
            buscarCompras.CommandType = CommandType.StoredProcedure;

            buscarCompras.Parameters.Add("@username", SqlDbType.NVarChar);
            buscarCompras.Parameters["@username"].Size = 255;
            buscarCompras.Parameters["@username"].Value = username;

            SqlDataReader compras = buscarCompras.ExecuteReader();
            if (compras.HasRows)
            {
                while (compras.Read())
                {
                    listaCompras.Add(compras["publ_descripcion"].ToString());
                    int.TryParse(compras["comp_id_vendedor"].ToString(), out numeroVendedorId);
                    listaVendedoresId.Add(numeroVendedorId);
                    int.TryParse(compras["compra_id"].ToString(), out compraId);
                    listaComprasId.Add(compraId);
                }
                comboBox1.DataSource = listaCompras;
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                this.button1.Enabled = true;
            }
            else
            {
                this.button1.Enabled = false;
                MessageBox.Show("No se encontraron compras sin calificar para este usuario");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            estrellas = 0;
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand califCompra = new SqlCommand("LA_PETER_MACHINE.calificar", conexion);
            califCompra.CommandType = CommandType.StoredProcedure;
            compraSeleccionada = (string)comboBox1.SelectedItem;
            numeroVendedorSeleccionado = listaVendedoresId[listaCompras.IndexOf(compraSeleccionada)];
            compraIdSeleccionado = listaComprasId[listaCompras.IndexOf(compraSeleccionada)];

            if(this.radioButton1.Checked) estrellas = 1;
            if(this.radioButton2.Checked) estrellas = 2;
            if(this.radioButton3.Checked) estrellas = 3;
            if(this.radioButton4.Checked) estrellas = 4;
            if(this.radioButton5.Checked) estrellas = 5;

            if (estrellas == 0)
            {
                MessageBox.Show("Debe seleccionar una calificacion");
            }
            else
            {
                califCompra.Parameters.Add("@idCompra", SqlDbType.Real);
                califCompra.Parameters["@idCompra"].Precision = 18;
                califCompra.Parameters["@idCompra"].Scale = 0;
                califCompra.Parameters["@idCompra"].Value = this.compraIdSeleccionado;

                califCompra.Parameters.Add("@valor", SqlDbType.Real);
                califCompra.Parameters["@valor"].Precision = 5;
                califCompra.Parameters["@valor"].Scale = 0;
                califCompra.Parameters["@valor"].Value = this.estrellas;

                califCompra.Parameters.Add("@detalle", SqlDbType.NVarChar);
                califCompra.Parameters["@detalle"].Size = 100;
                califCompra.Parameters["@detalle"].Value = this.textBox1.Text;

                califCompra.Parameters.Add("@vendedorId", SqlDbType.Real);
                califCompra.Parameters["@vendedorId"].Precision = 18;
                califCompra.Parameters["@vendedorId"].Scale = 0;
                califCompra.Parameters["@vendedorId"].Value = this.numeroVendedorSeleccionado;

                califCompra.ExecuteNonQuery();

                MessageBox.Show("Se ha calificado la compra correctamente");

                this.Hide();
                this.Close();
            }
        }
    }
}
