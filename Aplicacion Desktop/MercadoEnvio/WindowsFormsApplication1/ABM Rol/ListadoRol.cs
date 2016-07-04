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
    public partial class ListadoRol : Form
    {
        Boolean hab = true;
        String text = "";
        public ListadoRol()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rol rol = new Rol();
            this.Hide();
            rol.MdiParent = this.MdiParent;
            rol.Show();
            rol.Location = new Point(0, 49);
            this.Close();
        }

  

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rol rol = new Rol();
            this.Hide();
            rol.MdiParent = this.MdiParent;
            rol.Show();
            rol.Location = new Point(0, 49);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            SqlConnection conexion = conectionDB.getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            text = textBox1.Text;
            hab = controlComboBox();
            cmd.CommandText = "select rol_descripcion from LA_PETER_MACHINE.rol where (rol_descripcion LIKE '%' + @rol + '%') and rol_habilitado=@habilitado";
            cmd.Parameters.Add("@rol", SqlDbType.NVarChar);
            cmd.Parameters.Add("@habilitado", SqlDbType.Bit);
            cmd.Parameters["@rol"].Value = text;
            cmd.Parameters["@habilitado"].Value = hab;
             conexion.Open();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Rol";
            this.seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.seleccionar.Text = "Seleccionar";
            this.seleccionar.UseColumnTextForButtonValue = true;
            this.seleccionar.HeaderText = "Seleccionar";
            this.seleccionar.Name = "Seleccionar";
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccionar});
            this.habilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.habilitar.Text = "Habilitar";
            this.habilitar.UseColumnTextForButtonValue = true;
            this.habilitar.HeaderText = "Habilitar";
            this.habilitar.Name = "Habilitar";
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.habilitar});
            this.deshabilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deshabilitar.Text = "Deshabilitar";
            this.deshabilitar.UseColumnTextForButtonValue = true;
            this.deshabilitar.HeaderText = "Deshabilitar";
            this.deshabilitar.Name = "Deshabilitar";
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deshabilitar});
        }
        private Boolean controlComboBox() {
            return comboBox1.Text=="Habilitado";
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool enteroABool(int num)
        {
            if (num == 0) { return true; }
            else { return false; }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            if (enteroABool(String.Compare(senderGrid.Columns[e.ColumnIndex].HeaderText, "Seleccionar")) && e.RowIndex >= 0)
            {
                String rol=senderGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                SqlConnection conexion = conectionDB.getConnection();
                conexion.Open();
                SqlCommand controlarRolHabilitado = new SqlCommand("LA_PETER_MACHINE.Controlar_Rol_Habilitado", conexion);
                SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
                rdo.Size = 255;
                rdo.Direction = ParameterDirection.Output;

                rdo.Direction = ParameterDirection.Output;
                controlarRolHabilitado.CommandType = CommandType.StoredProcedure;
                controlarRolHabilitado.Parameters.Add("@rol", SqlDbType.NVarChar);
                controlarRolHabilitado.Parameters["@rol"].Value = senderGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                controlarRolHabilitado.Parameters.Add(rdo);
                controlarRolHabilitado.ExecuteNonQuery();

                if (String.Compare(rdo.Value.ToString(),"ok")==0)
                {
                    EditarFuncionalidades select = new EditarFuncionalidades(senderGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    this.Hide();
                    select.MdiParent = this.MdiParent;
                    select.Show();
                    select.Location = new Point(0, 49);
                    this.Close();
          
                }
                else
                {
                    MessageBox.Show(rdo.Value.ToString());
                }
            }
              if (enteroABool(String.Compare(senderGrid.Columns[e.ColumnIndex].HeaderText, "Habilitar")) && e.RowIndex >= 0)
            {
                SqlConnection conexion = conectionDB.getConnection();
                conexion.Open();
                SqlCommand cmd = new SqlCommand("LA_PETER_MACHINE.habilitarRol", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@rol", SqlDbType.NVarChar);
                cmd.Parameters["@rol"].Value = senderGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

                cmd.ExecuteNonQuery();

             }
              if (enteroABool(String.Compare(senderGrid.Columns[e.ColumnIndex].HeaderText, "Deshabilitar")) && e.RowIndex >= 0)
              {
                  SqlConnection conexion = conectionDB.getConnection();
                  conexion.Open();
                  SqlCommand cmd = new SqlCommand("LA_PETER_MACHINE.deshabilitar_rol", conexion);
                  cmd.CommandType = CommandType.StoredProcedure;
                  cmd.Parameters.Add("@rol", SqlDbType.NVarChar);
                  cmd.Parameters["@rol"].Value = senderGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

                  cmd.ExecuteNonQuery();
              }
        }
      
    
public  DataGridViewButtonColumn seleccionar { get; set; }

private void button1_Click(object sender, EventArgs e)
{
    dataGridView1.DataSource = null;
    dataGridView1.Rows.Clear();
    dataGridView1.Columns.Clear();
}

public DataGridViewButtonColumn habilitar { get; set; }

public DataGridViewButtonColumn deshabilitar { get; set; }
    }
}
