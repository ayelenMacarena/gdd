using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Para conectar con la base

namespace WindowsFormsApplication1.ABM_Usuario
{
 
    public partial class user : Form
    {
        int fails = 0;
        public user()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio back = new Inicio();
            this.Hide(); //La oculto
            back.ShowDialog(); //voy a la proxima
            this.Close(); // Cuando cierro 'back' vuelve y cierra est
            
            
        }

        private void user_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand loginProcedure = new SqlCommand("LA_PETER_MACHINE.login", conexion);
            string username = ingresoUser.Text;
            loginProcedure.CommandType = CommandType.StoredProcedure;
            //Paso los parámetros al SP
            loginProcedure.Parameters.Add("@username", SqlDbType.NVarChar);
            loginProcedure.Parameters["@username"].Value = username;

            loginProcedure.Parameters.Add("@pass", SqlDbType.NVarChar);
            loginProcedure.Parameters["@pass"].Value = ingresoPass.Text;
            SqlDataReader usuario = loginProcedure.ExecuteReader();
            if (usuario.HasRows)
            {
              
                while (usuario.Read())
                {
                    usuario.GetInt16["usua_habilitado"]

                    usuario.GetString(0);
                }

            } 
            else
            {

       
            }
            conexion.Close();

        }
        
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ABM_Usuario.altaUser newUser = new ABM_Usuario.altaUser();
            this.Hide();
            newUser.ShowDialog();
            this.Close();
        }
    }
}
