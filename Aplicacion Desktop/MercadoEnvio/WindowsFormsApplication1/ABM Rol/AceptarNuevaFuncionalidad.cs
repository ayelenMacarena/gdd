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
namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class AceptarNuevaFuncionalidad : Form
    {
        SqlCommand exec;
        public AceptarNuevaFuncionalidad(String funcionalidad, String Rol)
        {
            InitializeComponent();
     
            label1.Text = Rol;
            label3.Text = funcionalidad;
        }

        private void AceptarNuevaFuncionalidad_Load(object sender, EventArgs e)
        {
         }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand crearFuncRol = new SqlCommand("LA_PETER_MACHINE.agregar_funcionalidad_rol", conexion);
            SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
            rdo.Size = 255;
            rdo.Direction = ParameterDirection.Output;

            crearFuncRol.CommandType = CommandType.StoredProcedure;
            crearFuncRol.Parameters.Add("@funcionalidad", SqlDbType.NVarChar);
            crearFuncRol.Parameters["@funcionalidad"].Value = label3.Text;

            crearFuncRol.Parameters.Add("@rol", SqlDbType.NVarChar);
            crearFuncRol.Parameters["@rol"].Value = label1.Text;
            crearFuncRol.Parameters.Add(rdo);
            crearFuncRol.ExecuteNonQuery();
                 MessageBox.Show(rdo.Value.ToString());
                  this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
