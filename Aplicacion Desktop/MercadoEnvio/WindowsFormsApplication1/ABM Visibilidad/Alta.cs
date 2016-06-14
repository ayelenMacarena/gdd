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
        int precio;
        double porcentaje;

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
            int.TryParse(this.precioText.Text, out precio);
            crearVisib.Parameters.AddWithValue("@precio", this.precio);
            double.TryParse(this.precioText.Text, out porcentaje);
            crearVisib.Parameters.AddWithValue("@porcentaje", this.porcentaje);
            if (this.envioBox.Checked) envio = 1; else envio = 0;
            crearVisib.Parameters.AddWithValue("@envio", this.envio);
            crearVisib.Parameters.AddWithValue("@descripcion", this.descripcionText.Text);
            crearVisib.Parameters.Add("@rdo", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            crearVisib.ExecuteNonQuery();
            this.respuesta = Convert.ToString(crearVisib.Parameters["@rdo"].Value);

            conexion.Close();

            MessageBox.Show(this.respuesta);
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
