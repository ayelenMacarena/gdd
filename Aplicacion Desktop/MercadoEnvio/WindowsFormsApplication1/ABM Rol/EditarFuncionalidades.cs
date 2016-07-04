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
        private DataGridViewButtonColumn habilitar;
        private DataGridViewButtonColumn deshabilitar;
        
        public EditarFuncionalidades(String rol)
        {
            InitializeComponent();

            label1.Text = rol;
            SqlConnection conexion = conectionDB.getConnection();
            DataTable table=new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.CommandText = "select func_descripcion from LA_PETER_MACHINE.funcionalidad";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            conexion.Open();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText ="funcionalidad";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
     
            if (enteroABool(String.Compare(senderGrid.Columns[e.ColumnIndex].HeaderText,"Habilitar")) && e.RowIndex >= 0)
            {
               

                AceptarNuevaFuncionalidad window = new AceptarNuevaFuncionalidad( senderGrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString(), label1.Text);
                window.ShowDialog();
                
            }
            if (enteroABool(String.Compare(senderGrid.Columns[e.ColumnIndex].HeaderText, "Deshabilitar")) && e.RowIndex >= 0)
            {
               
                Deshabilitar_Funcionalidad window = new Deshabilitar_Funcionalidad( senderGrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString(), label1.Text);
                window.ShowDialog();
                
        
            }
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
    }
}
