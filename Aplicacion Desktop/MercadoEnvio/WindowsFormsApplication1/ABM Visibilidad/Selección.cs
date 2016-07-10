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
    public partial class Selección : Form
    {
        int envio;
        decimal codigo;
        decimal precio;
        decimal porcentaje;

        public Selección(decimal codigo, decimal precio, decimal porcentaje, int envio, string descripcion)
        {
            InitializeComponent();
            this.codigoBox.Text = codigo.ToString();
            this.precioBox.Text = precio.ToString();
            this.porcentajeBox.Text = porcentaje.ToString();
            this.envioBox.Checked = envio == 1;
            this.descripcionText.Text = descripcion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand modificarVisib = new SqlCommand("LA_PETER_MACHINE.modificarVisibilidad", conexion);
            modificarVisib.CommandType = CommandType.StoredProcedure;
            //Paso los parámetros al SP
            decimal.TryParse(this.codigoBox.Text, out codigo);
            modificarVisib.Parameters.Add("@codigo", SqlDbType.Real);
            modificarVisib.Parameters["@codigo"].Precision = 18;
            modificarVisib.Parameters["@codigo"].Scale = 0;
            modificarVisib.Parameters["@codigo"].Value = this.codigo;
            decimal.TryParse(this.precioBox.Text, out precio);
            if (this.precio == 0)
            {
                MessageBox.Show("Valor de precio invalido");
            }
            else
            {
                modificarVisib.Parameters.Add("@precio", SqlDbType.Real);
                modificarVisib.Parameters["@precio"].Precision = 18;
                modificarVisib.Parameters["@precio"].Scale = 2;
                modificarVisib.Parameters["@precio"].Value = this.precio;
                decimal.TryParse(this.porcentajeBox.Text, out porcentaje);
                if (this.porcentaje == 0)
                {
                    MessageBox.Show("Valor de porcentaje invalido");
                }
                else
                {
                    modificarVisib.Parameters.Add("@porcentaje", SqlDbType.Real);
                    modificarVisib.Parameters["@porcentaje"].Precision = 18;
                    modificarVisib.Parameters["@porcentaje"].Scale = 2;
                    modificarVisib.Parameters["@porcentaje"].Value = this.porcentaje;
                    if (this.envioBox.Checked) envio = 1; else envio = 0;
                    modificarVisib.Parameters.Add("@envio", SqlDbType.Bit);
                    modificarVisib.Parameters["@envio"].Value = this.envio;
                    modificarVisib.Parameters.Add("@descripcion", SqlDbType.NVarChar);
                    modificarVisib.Parameters["@descripcion"].Value = this.descripcionText.Text;

                    modificarVisib.ExecuteNonQuery();

                    MessageBox.Show("Se modificaron los valores de la visibilidad seleccionada");

                    Listado visibilidad = new Listado();
                    //Visibilidad visibilidad = new Visibilidad();
                    this.Hide();
                    visibilidad.MdiParent = this.MdiParent;
                    visibilidad.Show();
                    visibilidad.Location = new Point(0, 49);
                    this.Close();
                }
            }
            conexion.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand eliminarVisib = new SqlCommand("LA_PETER_MACHINE.eliminarVisibilidad", conexion);
            eliminarVisib.CommandType = CommandType.StoredProcedure;
            //Paso los parámetros al SP
            decimal.TryParse(this.codigoBox.Text, out codigo);
            eliminarVisib.Parameters.Add("@codigo", SqlDbType.Real);
            eliminarVisib.Parameters["@codigo"].Precision = 18;
            eliminarVisib.Parameters["@codigo"].Scale = 0;
            eliminarVisib.Parameters["@codigo"].Value = this.codigo;

            try
            {
                eliminarVisib.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Se ha eliminado la Visibilidad seleccionada");
                Visibilidad visibilidad = new Visibilidad();
                this.Hide();
                visibilidad.MdiParent = this.MdiParent;
                visibilidad.Show();
                visibilidad.Location = new Point(0, 49);
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se puede eliminar la Visibilidad, existen publicaciones que la referencian");
                conexion.Close();
            }
        }

        private void volverLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Visibilidad visibilidad = new Visibilidad();
            this.Hide();
            visibilidad.MdiParent = this.MdiParent;
            visibilidad.Show();
            visibilidad.Location = new Point(0, 49);
            this.Close();
        }
    }
}
