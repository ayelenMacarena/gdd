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
namespace WindowsFormsApplication1
{
    public partial class Deshabilitar_Funcionalidad : Form
    {
        String rol;
        String funcionalidad;
        public Deshabilitar_Funcionalidad(String _funcinalidad, String _rol)
        {
            InitializeComponent();
            rol = _rol;
            funcionalidad = _funcinalidad;
            label1.Text = _rol;
            label3.Text = _funcinalidad;
        }

        private void Deshabilitar_Funcionalidad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand eliminarFuncRol = new SqlCommand("LA_PETER_MACHINE.eliminar_funcionalidad_rol", conexion);
            SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
            rdo.Size = 255;
            rdo.Direction = ParameterDirection.Output;

            eliminarFuncRol.CommandType = CommandType.StoredProcedure;
            eliminarFuncRol.Parameters.Add("@funcionalidad", SqlDbType.NVarChar);
            eliminarFuncRol.Parameters["@funcionalidad"].Value = funcionalidad;

            eliminarFuncRol.Parameters.Add("@rol", SqlDbType.NVarChar);
            eliminarFuncRol.Parameters["@rol"].Value = rol;
            eliminarFuncRol.Parameters.Add(rdo);

            eliminarFuncRol.ExecuteNonQuery();
            MessageBox.Show(rdo.Value.ToString());
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
