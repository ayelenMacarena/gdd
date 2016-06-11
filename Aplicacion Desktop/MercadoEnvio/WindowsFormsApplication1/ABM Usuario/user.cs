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
 
        public user()
        {
            InitializeComponent();
            ingresoUser.KeyDown += new KeyEventHandler(OnKeyDownHandler);
            ingresoPass.KeyDown += new KeyEventHandler(OnKeyDownHandler);
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
            loginProcedure.Parameters.AddWithValue("@username", username);
            loginProcedure.Parameters["@username"].Value = username;
            string pass = ingresoPass.Text;
            loginProcedure.Parameters.AddWithValue("@pass", pass);
            
            SqlDataReader usuario = loginProcedure.ExecuteReader();
            List<String> listaRoles = new List<String>();

            if (usuario.HasRows)
            {

              
                    while (usuario.Read())
                    {
                        if (usuario.GetBoolean(0)) // getBoolean recibe le número de fila que quiero convertir en boolean, en este caso es usua_habilitado la 0.
                        { //Si el usuario está habilitado
                                                       
                            listaRoles.Add(usuario["rol_descripcion"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("El usuario está inhabilitado, debe contactarse con el administrador del sistema");
                        }

                    }

                
            }
            else
            {

                MessageBox.Show("El usuario o contraseña especificado, no existe");
            }
            conexion.Close();
            if (listaRoles.Count() >=1)
            {
                //Si se cargo la listaRoles, es porque el usuario se logueo Ok y tiene roles asignados.
                ABM_Rol.selectRol selectRol = new ABM_Rol.selectRol(listaRoles);
                this.Hide();
                selectRol.ShowDialog();
                this.Close();
            }

        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1.PerformClick();
            }
        }
        
    }
}
