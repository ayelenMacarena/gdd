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


namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class generarPublicacion : Form
    {
        public generarPublicacion()
        {
            InitializeComponent();

            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand loginProcedure = new SqlCommand("LA_PETER_MACHINE.generar_publicacion", conexion);
            loginProcedure.CommandType = CommandType.StoredProcedure;
            SqlDataReader tipos = loginProcedure.ExecuteReader();
            List<String> listaTipos = new List<String>();

            if (tipos.HasRows)
            {


                while (tipos.Read())
                {

                    listaTipos.Add(tipos["tipo_descripcion"].ToString());
                }
            }
            comboBox1.DataSource = listaTipos;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            //ACA va a que ABM VOLver (LA home, que hace Tato)
            this.Hide();
           // selectRol.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "nextNumber";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



    }
}
