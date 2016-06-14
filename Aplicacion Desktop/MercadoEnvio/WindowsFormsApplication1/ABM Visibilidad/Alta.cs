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
    public partial class Alta : Form
    {
        int envio;
        string respuesta;
        decimal precio;
        decimal porcentaje;

        public Alta()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand crearVisib = new SqlCommand("LA_PETER_MACHINE.crearVisibilidad", conexion);
            crearVisib.CommandType = CommandType.StoredProcedure;
            //Paso los parámetros al SP
            decimal.TryParse(this.precioBox.Text, out precio);
            if(this.precio == 0)
            {
                MessageBox.Show("Valor de precio invalido");
            }
            else
            {
                crearVisib.Parameters.Add("@precio", SqlDbType.Real);
                crearVisib.Parameters["@precio"].Precision = 18;
                crearVisib.Parameters["@precio"].Scale = 0;
                crearVisib.Parameters["@precio"].Value = this.precio;
                decimal.TryParse(this.porcentajeBox.Text, out porcentaje);
                if (this.porcentaje == 0)
                {
                    MessageBox.Show("Valor de porcentaje invalido");
                }
                else
                {
                    crearVisib.Parameters.Add("@porcentaje", SqlDbType.Real);
                    crearVisib.Parameters["@porcentaje"].Precision = 18;
                    crearVisib.Parameters["@porcentaje"].Scale = 2;
                    crearVisib.Parameters["@porcentaje"].Value = this.porcentaje;
                    if (this.envioBox.Checked) envio = 1; else envio = 0;
                    crearVisib.Parameters.Add("@envio", SqlDbType.Bit);
                    crearVisib.Parameters["@envio"].Value = this.envio;
                    crearVisib.Parameters.Add("@descripcion", SqlDbType.NVarChar);
                    crearVisib.Parameters["@descripcion"].Value = this.descripcionText.Text;
                    crearVisib.Parameters.Add("@rdo", SqlDbType.NVarChar).Direction = ParameterDirection.Output;
                    crearVisib.Parameters["@rdo"].Size = 255;

                    crearVisib.ExecuteNonQuery();
                    this.respuesta = Convert.ToString(crearVisib.Parameters["@rdo"].Value);

                    MessageBox.Show(this.respuesta);
                }
            }
            conexion.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
