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
namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class EditarRoles : Form
    {
        String rol;
        String usu;
        public EditarRoles(String usuario, String tipo)
        {
            InitializeComponent();
            label1.Text = usuario;
            usu = usuario;
            rol = tipo;
            actualizarGrid();

            dataGridView1.AllowUserToAddRows = false;
        }
        private void actualizarGrid() {
            SqlConnection conexion = conectionDB.getConnection();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.CommandText = "select  rol_descripcion as Rol, LA_PETER_MACHINE.charABit(rolu_username)  as Habilitado from LA_PETER_MACHINE.rol left outer join LA_PETER_MACHINE.roles_usuario   on rolu_id_rol=rol_id and  rolu_username=@usuario ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            conexion.Open();
            cmd.Parameters.Add("@usuario", SqlDbType.NVarChar);
            cmd.Parameters["@usuario"].Value = usu;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListadoDeUsuarios list = new ListadoDeUsuarios();
            this.Hide();
            list.MdiParent = this.MdiParent;
            list.Show();
            list.Location = new Point(0, 49);
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private bool enteroABool(int num)
        {
            if (num == 0) { return true; }
            else { return false; }
        }



        public DataGridViewButtonColumn habilitar { get; set; }

        public DataGridViewButtonColumn deshabilitar { get; set; }

        private void EditarRoles_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rol == "empresa")
            {
                modificarEmpresa mod = new modificarEmpresa(usu);
                this.Hide();
                mod.MdiParent = this.MdiParent;
                mod.Show();
                mod.Location = new Point(0, 49);
                this.Close();
            }
            if (rol == "cliente")
            {
                modificarCliente mod = new modificarCliente(usu);
                this.Hide();
                mod.MdiParent = this.MdiParent;
                mod.Show();
                mod.Location = new Point(0, 49);
                this.Close();

            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                String rol1 = row.Cells["Rol"].FormattedValue.ToString();
                String boolean = row.Cells["Habilitado"].FormattedValue.ToString();
                if (boolean == "True")
                {
                    SqlCommand crearFuncRol = new SqlCommand("LA_PETER_MACHINE.agregar_Usuario_Rol", conexion);
                    SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
                    rdo.Size = 255;
                    rdo.Direction = ParameterDirection.Output;

                    crearFuncRol.CommandType = CommandType.StoredProcedure;
                    crearFuncRol.Parameters.Add("@rol", SqlDbType.NVarChar);
                    crearFuncRol.Parameters["@rol"].Value = rol1;

                    crearFuncRol.Parameters.Add("@usuario", SqlDbType.NVarChar);
                    crearFuncRol.Parameters["@usuario"].Value = usu;
                    crearFuncRol.Parameters.Add(rdo);
              
               
                    crearFuncRol.ExecuteNonQuery();
                }
                else
                {

                    SqlCommand eliminarFuncRol = new SqlCommand("LA_PETER_MACHINE.eliminar_usuario_rol", conexion);
                    SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
                    rdo.Size = 255;
                    rdo.Direction = ParameterDirection.Output;

                    eliminarFuncRol.CommandType = CommandType.StoredProcedure;
                    eliminarFuncRol.Parameters.Add("@rol", SqlDbType.NVarChar);
                    eliminarFuncRol.Parameters["@rol"].Value = rol1;

                    eliminarFuncRol.Parameters.Add("@usuario", SqlDbType.NVarChar);
                    eliminarFuncRol.Parameters["@usuario"].Value = usu;
                    eliminarFuncRol.Parameters.Add(rdo);
        
               
                    eliminarFuncRol.ExecuteNonQuery();
                }

               
            }
            actualizarGrid();
        }
    }
}
