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
        string respuesta;
        int precio;
        double porcentaje;

        public Selección()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand modificarVisib = new SqlCommand("LA_PETER_MACHINE.modificarVisibilidad", conexion);
            modificarVisib.CommandType = CommandType.StoredProcedure;
            //Paso los parámetros al SP
            modificarVisib.Parameters.AddWithValue("@codigo", this.codigoBox);
            int.TryParse(this.precioText.Text, out precio);
            modificarVisib.Parameters.AddWithValue("@precio", this.precio);
            double.TryParse(this.precioText.Text, out porcentaje);
            modificarVisib.Parameters.AddWithValue("@porcentaje", this.porcentaje);
            if (this.envioBox.Checked) envio = 1; else envio = 0;
            modificarVisib.Parameters.AddWithValue("@envio", this.envio);
            modificarVisib.Parameters.AddWithValue("@descripcion", this.descripcionText.Text);

            modificarVisib.ExecuteNonQuery();

            conexion.Close();

            MessageBox.Show("Se modificaron los valores de la visibilidad seleccionada");
            Visibilidad visibilidad = new Visibilidad();
            this.Hide();
            visibilidad.MdiParent = this.MdiParent;
            visibilidad.Show();
            visibilidad.Location = new Point(0, 49);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand eliminarVisib = new SqlCommand("LA_PETER_MACHINE.eliminarVisibilidad", conexion);
            eliminarVisib.CommandType = CommandType.StoredProcedure;
            //Paso los parámetros al SP
            eliminarVisib.Parameters.AddWithValue("@codigo", this.codigoBox.Text);

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
