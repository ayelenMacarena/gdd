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
    public partial class CambiarContraseña : Form
    {
        public CambiarContraseña(String usuario)
        {
            InitializeComponent();
            label5.Text = usuario;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text && textBox3.Text == textBox4.Text)
            {
                SqlConnection conexion = conectionDB.getConnection();
                conexion.Open();
                SqlCommand cmd = new SqlCommand("LA_PETER_MACHINE.CambiarContraseña", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
                rdo.Size = 255;
                rdo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Usuario", SqlDbType.NVarChar);
                cmd.Parameters["@Usuario"].Value = label5.Text;
                cmd.Parameters.Add("@contraseñaNueva", SqlDbType.NVarChar);
                cmd.Parameters["@contraseñaNueva"].Value = textBox3.Text;
                cmd.Parameters.Add("@contraseñaVieja", SqlDbType.NVarChar);
                cmd.Parameters["@contraseñaVieja"].Value = textBox1.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show(rdo.Value.ToString());
            }
            else { MessageBox.Show("La contraseña no coincide"); }
       
        }
    }
}
