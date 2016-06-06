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
            SqlConnection conexion = conectionDB.getConnection();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.CommandText = "select rol_descripcion from LA_PETER_MACHINE.rol";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            conexion.Open();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Rol";
            this.habilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.habilitar.Text = "Habilitar";
            this.habilitar.UseColumnTextForButtonValue = true;
            this.habilitar.HeaderText = "Habilitar";
            this.habilitar.Name = "Habilitar";
            this.deshabilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deshabilitar.Text = "DesHabilitar";
            this.deshabilitar.UseColumnTextForButtonValue = true;
            this.deshabilitar.HeaderText = "Deshabilitar";
            this.deshabilitar.Name = "Deshabilitar";
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.habilitar});
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deshabilitar});
            conexion.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListadoDeUsuarios list = new ListadoDeUsuarios();
            this.Hide();
            list.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
     
            if (enteroABool(String.Compare(senderGrid.Columns[e.ColumnIndex].HeaderText,"Habilitar")) && e.RowIndex >= 0)
            {
                String rol = senderGrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                SqlConnection conexion = conectionDB.getConnection();
                conexion.Open();
                SqlCommand crearFuncRol = new SqlCommand("LA_PETER_MACHINE.agregar_Usuario_Rol", conexion);
                SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
                rdo.Size = 255;
                rdo.Direction = ParameterDirection.Output;

                crearFuncRol.CommandType = CommandType.StoredProcedure;
                crearFuncRol.Parameters.Add("@rol", SqlDbType.NVarChar);
                crearFuncRol.Parameters["@rol"].Value = rol;

                crearFuncRol.Parameters.Add("@usuario", SqlDbType.NVarChar);
                crearFuncRol.Parameters["@usuario"].Value = label1.Text;
                crearFuncRol.Parameters.Add(rdo);

                crearFuncRol.ExecuteNonQuery();
                MessageBox.Show(rdo.Value.ToString());
            }
            if (enteroABool(String.Compare(senderGrid.Columns[e.ColumnIndex].HeaderText, "Deshabilitar")) && e.RowIndex >= 0)
            {
                SqlConnection conexion = conectionDB.getConnection();
                conexion.Open();
                SqlCommand eliminarFuncRol = new SqlCommand("LA_PETER_MACHINE.eliminar_usuario_rol", conexion);
                SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
                rdo.Size = 255;
                rdo.Direction = ParameterDirection.Output;

                eliminarFuncRol.CommandType = CommandType.StoredProcedure;
                eliminarFuncRol.Parameters.Add("@rol", SqlDbType.NVarChar);
                eliminarFuncRol.Parameters["@rol"].Value = senderGrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();

                eliminarFuncRol.Parameters.Add("@usuario", SqlDbType.NVarChar);
                eliminarFuncRol.Parameters["@usuario"].Value = label1.Text;
                eliminarFuncRol.Parameters.Add(rdo);

                eliminarFuncRol.ExecuteNonQuery();
                MessageBox.Show(rdo.Value.ToString());
            }
        }
        private bool enteroABool(int num) {
            if (num==0) { return true;}
            else{return false;}
        }
         
        

        public DataGridViewButtonColumn habilitar { get; set; }

        public DataGridViewButtonColumn deshabilitar { get; set; }

        private void EditarRoles_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rol == "empresa") {
                modificarEmpresa mod = new modificarEmpresa(usu);
                this.Hide();
                mod.ShowDialog();
                this.Close();
            }
            if (rol == "cliente") {
                modificarCliente mod = new modificarCliente(usu);
                this.Hide();
                mod.ShowDialog();
                this.Close();
            
            }
        }
    }
}
