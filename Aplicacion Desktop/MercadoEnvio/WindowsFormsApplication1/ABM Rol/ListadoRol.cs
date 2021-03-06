﻿using System;
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
        
        String text = "";
        public ListadoRol()
        {
            InitializeComponent();
            actualizarGrid();
            dataGridView1.AllowUserToAddRows = false;
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
            actualizarGrid();
           
            }
        private void actualizarGrid() {
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

            cmd.CommandText = "select rol_descripcion as Rol, rol_habilitado as Habilitado from LA_PETER_MACHINE.rol where (rol_descripcion LIKE '%' + @rol + '%') and rol_habilitado=@habilitado";
            cmd.Parameters.Add("@rol", SqlDbType.NVarChar);
            cmd.Parameters.Add("@habilitado", SqlDbType.Bit);
            cmd.Parameters["@rol"].Value = text;
            cmd.Parameters["@habilitado"].Value = checkBox1.Checked;
            conexion.Open();
            adapter.Fill(table);
            if (table.Rows.Count == 0) { }
            else
            {
                dataGridView1.DataSource = table;
                this.seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
                this.seleccionar.Text = "Seleccionar";
                this.seleccionar.UseColumnTextForButtonValue = true;
                this.seleccionar.HeaderText = "Seleccionar";
                this.seleccionar.Name = "Seleccionar";
                this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccionar});
            }
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
                String rol = senderGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
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

                if (String.Compare(rdo.Value.ToString(), "ok") == 0)
                {
                    EditarFuncionalidades select = new EditarFuncionalidades(senderGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    this.Hide();
                    select.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show(rdo.Value.ToString());
                }
                return;
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
                    SqlCommand cmd = new SqlCommand("LA_PETER_MACHINE.habilitar_rol", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
                    rdo.Size = 255;
                    rdo.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(rdo);
                    cmd.Parameters.Add("@rol", SqlDbType.NVarChar);
                    cmd.Parameters["@rol"].Value = rol1;

                    cmd.ExecuteNonQuery();
                }
                else
                {

                    SqlCommand cmd = new SqlCommand("LA_PETER_MACHINE.deshabilitar_rol", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
                    rdo.Size = 255;
                    rdo.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(rdo);
                    cmd.Parameters.Add("@rol", SqlDbType.NVarChar);
                    cmd.Parameters["@rol"].Value = rol1;

                    cmd.ExecuteNonQuery();
                }

               
            }
            actualizarGrid();
        
}
    }
}
