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
    public partial class ListadoDeUsuarios : Form
    {
      
        public ListadoDeUsuarios()
        {
            InitializeComponent();
             SqlConnection conexion = conectionDB.getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            SqlDataReader reader;
            cmd.CommandText ="select rol_descripcion  from LA_PETER_MACHINE.rol";
             conexion.Open();
             reader = cmd.ExecuteReader();
             while (reader.Read()) {
                 if (reader[0].ToString() != "administrativo")
                 {
                     comboBox1.Items.Add(reader[0]);
                 }
                }
             dataGridView1.AllowUserToAddRows = false;
             comboBox1.Items.Add("");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private bool enteroABool(int num)
        {
            if (num == 0) { return true; }
            else { return false; }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            String usu = senderGrid.Rows[e.RowIndex].Cells["Usuario"].FormattedValue.ToString();
            if (enteroABool(String.Compare(senderGrid.Columns[e.ColumnIndex].HeaderText, "Seleccionar")) && e.RowIndex >= 0)
            {
                SqlConnection conexion = conectionDB.getConnection();
                conexion.Open();
                SqlCommand controlarUsarioHabilitado = new SqlCommand("LA_PETER_MACHINE.Controlar_Usuario_Habilitado", conexion);
                SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
                rdo.Size = 255;
                rdo.Direction = ParameterDirection.Output;
                controlarUsarioHabilitado.CommandType = CommandType.StoredProcedure;
                controlarUsarioHabilitado.Parameters.Add("@Usuario", SqlDbType.NVarChar);
                controlarUsarioHabilitado.Parameters["@Usuario"].Value =usu;
                controlarUsarioHabilitado.Parameters.Add(rdo);
                controlarUsarioHabilitado.ExecuteNonQuery();

                if (String.Compare(rdo.Value.ToString(), "ok") == 0)
                {
                    if (comboBox1.Text == "cliente")
                    {
                        EditarRoles select = new EditarRoles(usu, "cliente");
                        select.ShowDialog();
                       
                    }
                    else {
                        if (comboBox1.Text == "empresa")
                        {
                            EditarRoles select = new EditarRoles(usu, "empresa");
                            select.ShowDialog();
                          }
                        else {
                            MessageBox.Show("Solo se pueden modificar usuarios dentro de la busqueda de empresas o clientes");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(rdo.Value.ToString());
                }
                return;
            }
        
        }

        private void textBox5_DoubleClick(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
    
        }
  

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
          }

        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
    
       
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox4.Text = monthCalendar2.SelectionRange.Start.ToShortDateString();
            monthCalendar2.Visible = false;
     
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox5.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            monthCalendar1.Visible = false;
     
        }

        private void button4_Click(object sender, EventArgs e)
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
            cmd.CommandText = "select tabla.Nombre,tabla.IdentUnico,tabla.Usuario,tabla.Ciudad,tabla.Calle,tabla.Numero,tabla.Mail,tabla.Habilitado  from (select  clie_nombre + ' ' + clie_apellido as Nombre,clie_dni as IdentUnico,usua_username as Usuario,pers_ciudad as Ciudad, pers_domicilio_calle as Calle,pers_numero_calle as Numero, pers_mail as Mail, usua_habilitado as Habilitado from LA_PETER_MACHINE.cliente, LA_PETER_MACHINE.usuario, LA_PETER_MACHINE.persona where pers_id=clie_id_persona and pers_username=usua_username  and (isnull(pers_ciudad,'') like '%' + @ciudad + '%') and usua_habilitado=@hab and pers_fecha_creacion >= right(@desde,4)+substring(@desde,4,2)+left(@desde,2) and pers_fecha_creacion< right(@hasta,4)+substring(@hasta,4,2)+left(@hasta,2) union select empr_razon_social as Nombre, convert(numeric,left(empr_cuit,2)+substring(empr_cuit,4,8)+right(empr_cuit,2)) as IdentUnico,pers_username as Usuario, pers_ciudad as Ciudad, pers_domicilio_calle as Calle,pers_numero_calle as Numero,pers_mail as Mail, usua_habilitado as Habilitado  from LA_PETER_MACHINE.empresa, LA_PETER_MACHINE.usuario, LA_PETER_MACHINE.persona  where pers_id=empr_id_persona and pers_username=usua_username and (isnull(pers_ciudad,'') like '%' + @ciudad + '%') and usua_habilitado=@hab and pers_fecha_creacion >= right(@desde,4)+substring(@desde,4,2)+left(@desde,2) and pers_fecha_creacion< right(@hasta,4)+substring(@hasta,4,2)+left(@hasta,2)) as tabla, LA_PETER_MACHINE.roles_usuario,LA_PETER_MACHINE.rol  where rolu_id_rol=rol_id and rol_descripcion like @rol + '%' and rolu_username=tabla.Usuario and (tabla.nombre like '%' + @nombre + '%') and (tabla.IdentUnico like '%' + @doc + '%') group by tabla.Nombre,tabla.IdentUnico,tabla.Usuario,tabla.Ciudad,tabla.Calle,tabla.Numero,tabla.Mail,tabla.Habilitado ";
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
            cmd.Parameters["@nombre"].Value = textBox1.Text;
            cmd.Parameters.Add("@doc", SqlDbType.NVarChar);
            cmd.Parameters["@doc"].Value = textBox2.Text;
            cmd.Parameters.Add("@ciudad", SqlDbType.NVarChar);
            cmd.Parameters["@ciudad"].Value = textBox3.Text;
            cmd.Parameters.Add("@hab", SqlDbType.NVarChar);
            cmd.Parameters["@hab"].Value = deBoolABit(checkBox1.Checked);
            cmd.Parameters.Add("@desde", SqlDbType.NVarChar);
            cmd.Parameters["@desde"].Value = checkDesde();
            cmd.Parameters.Add("@hasta", SqlDbType.NVarChar);
            cmd.Parameters["@hasta"].Value = checkHasta();
            cmd.Parameters.Add("@rol", SqlDbType.NVarChar);
            cmd.Parameters["@rol"].Value = comboBox1.Text;
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
            private String deBoolABit(Boolean b){
                if (b) { return "1"; }
                    else{return "0";}
            }
        private String checkDesde()
        {
            if (textBox5.Text == "")
            {
                return "01/01/1753";
            }
            else
            {
                return textBox5.Text;
            }
        }
        
        private String checkHasta(){
            if (textBox5.Text == "")
            {
                return "31/12/9998";
            }
            else {
                return textBox4.Text;
            }
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            textBox4.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Text = "";
            comboBox1.DropDownStyle = ComboBoxStyle.Simple;
            comboBox1.Text = "";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
           
        }

        public DataGridViewButtonColumn seleccionar { get; set; }

        public DataGridViewButtonColumn habilitar { get; set; }

        public DataGridViewButtonColumn deshabilitar { get; set; }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cliente clie = new Cliente();
            this.Hide();
            clie.MdiParent = this.MdiParent;
            clie.Show();
            clie.Location = new Point(0, 49);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                String usu = row.Cells["Usuario"].FormattedValue.ToString();
                String boolean = row.Cells[7].FormattedValue.ToString();
                 if (boolean == "True")
                {
                  
                   
                    SqlCommand cmd = new SqlCommand("LA_PETER_MACHINE.Habilitar_Usuario", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Usuario", SqlDbType.NVarChar);
                    cmd.Parameters["@Usuario"].Value = usu;
                    SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
                    rdo.Size = 255;
                    rdo.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(rdo);
                    cmd.ExecuteNonQuery();
                }
                else {
                   
                    SqlCommand cmd = new SqlCommand("LA_PETER_MACHINE.Deshabilitar_Usuario", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Usuario", SqlDbType.NVarChar);
                    cmd.Parameters["@Usuario"].Value = usu;
                    SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
                    rdo.Size = 255;
                    rdo.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(rdo);
                    cmd.ExecuteNonQuery();
                }
            }
            actualizarGrid();
        }

        private void ListadoDeUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
