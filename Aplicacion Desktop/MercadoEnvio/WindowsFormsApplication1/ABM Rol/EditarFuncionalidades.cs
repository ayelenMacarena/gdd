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
    public partial class EditarFuncionalidades : Form
    {
        String rol;
        
        public EditarFuncionalidades(String _rol)
        {
            InitializeComponent();
            rol = _rol;
            label1.Text = rol;
            actualizarGrid();
        }
        private void actualizarGrid() {
            SqlConnection conexion = conectionDB.getConnection();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.CommandText = "select func_descripcion as Funcionalidad,LA_PETER_MACHINE.numericABit(furo_id_rol) as Habilitado   from LA_PETER_MACHINE.funcionalidad left outer join LA_PETER_MACHINE.funcionalidad_rol on funcionalidad_id=furo_id_funcionalidad and furo_id_rol=(select rol_id from LA_PETER_MACHINE.rol where rol_descripcion=@rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@rol", SqlDbType.NVarChar);
            cmd.Parameters["@rol"].Value = rol;
            cmd.Connection = conexion;
            conexion.Open();
            adapter.Fill(table);
            dataGridView1.DataSource = table;


            dataGridView1.AllowUserToAddRows = false;
            conexion.Close();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private bool enteroABool(int num) {
            if (num==0) { return true;}
            else{return false;}
        }
        private void EditarFuncionalidades_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListadoRol select = new ListadoRol();
            this.Hide();
            select.MdiParent = this.MdiParent;
            select.Show();
            select.Location = new Point(0, 49);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                String funcionalidad = row.Cells["Funcionalidad"].FormattedValue.ToString();
                String boolean = row.Cells["Habilitado"].FormattedValue.ToString();
                if (boolean == "True")
                {
                    SqlCommand crearFuncRol = new SqlCommand("LA_PETER_MACHINE.agregar_funcionalidad_rol", conexion);
                    SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
                    rdo.Size = 255;
                    rdo.Direction = ParameterDirection.Output;

                    crearFuncRol.CommandType = CommandType.StoredProcedure;
                    crearFuncRol.Parameters.Add("@funcionalidad", SqlDbType.NVarChar);
                    crearFuncRol.Parameters["@funcionalidad"].Value = funcionalidad;

                    crearFuncRol.Parameters.Add("@rol", SqlDbType.NVarChar);
                    crearFuncRol.Parameters["@rol"].Value = rol;
                    crearFuncRol.Parameters.Add(rdo);
                    crearFuncRol.ExecuteNonQuery();
                }
                else
                {

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
                }


            }
            actualizarGrid();
            conexion.Close();
        }
    }
}
