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

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class busquedaPublicacion : Form
    {
        string user;
        public busquedaPublicacion(string vendedor)
        {
            InitializeComponent();
            user = vendedor;
            DataTable table = new DataTable();
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand publicaciones = new SqlCommand("LA_PETER_MACHINE.publicacionesParaModificar", conexion);
            publicaciones.CommandType = CommandType.StoredProcedure;
            publicaciones.Parameters.AddWithValue("@username", user);
            SqlDataAdapter adapter = new SqlDataAdapter(publicaciones);
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            Generar_Publicación.tiposDePublicacion generarPubli = new Generar_Publicación.tiposDePublicacion(this.user);
            this.Hide();
            generarPubli.ShowDialog();
            this.Close();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.CurrentRow;
            Generar_Publicación.modificarPublicacion modificarPublicacion = new Generar_Publicación.modificarPublicacion(filaSeleccionada, this.user);
            this.Hide();
            modificarPublicacion.ShowDialog();
            
        }

    }
}
