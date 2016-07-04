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
    public partial class AltaRol : Form
    {
        String descripcion;
        public AltaRol()
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand crearRol = new SqlCommand("LA_PETER_MACHINE.crearRol", conexion);
            descripcion= textBox_1.Text;
            SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
            rdo.Size = 255;
             rdo.Direction = ParameterDirection.Output;
            
            crearRol.CommandType = CommandType.StoredProcedure;
            crearRol.Parameters.Add("@descripcion", SqlDbType.NVarChar);
            crearRol.Parameters["@descripcion"].Value = descripcion;
            crearRol.Parameters.Add(rdo);
             crearRol.ExecuteNonQuery();

             EditarFuncionalidades func = new EditarFuncionalidades(descripcion);
              MessageBox.Show(rdo.Value.ToString());
              if (rdo.Value.ToString()=="ok") { func.ShowDialog(); }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
     
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

  

    }
}
