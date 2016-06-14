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
    public partial class generarPublicacionCompra : Form
    {

        public generarPublicacionCompra(string usuario)
        {
            InitializeComponent();

            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            string ultimoNumero = "SELECT TOP 1 publicacion_id from LA_PETER_MACHINE.publicacion order by publicacion_id desc";
            SqlCommand lastNumber = new SqlCommand(ultimoNumero, conexion);
            
            SqlDataReader numero = lastNumber.ExecuteReader();

            while (numero.Read())
            {
                textBoxCod.Text = numero["publicacion_id"].ToString();
            }
            textBox1.Text = usuario;
            string rubros = "select rubr_descripcion_corta from LA_PETER_MACHINE.rubro";
            SqlCommand listRubros = new SqlCommand(rubros, conexion);
            conexion.Close();
            conexion.Open();
            SqlDataReader rub = listRubros.ExecuteReader();
            List<String> rubritos = new List<String>();
            if (rub.HasRows)
            {
                while (rub.Read())
                {
                    rubritos.Add(rub["rubr_descripcion_corta"].ToString());
                }

            }
            comboBox1.DataSource = rubritos;
            conexion.Close();
            conexion.Open();
            string visibilidad = "select visi_descripcion from LA_PETER_MACHINE.visibilidad";
            SqlCommand listaVisi = new SqlCommand(visibilidad, conexion);

            SqlDataReader vis = listRubros.ExecuteReader();
            List<String> visib = new List<String>();
            if (vis.HasRows)
            {
                while (vis.Read())
                {
                    visib.Add(vis["visi_descripcion"].ToString());
                }

            }
            comboBox2.DataSource = visib;



        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Int32 unInt;
            if (!Int32.TryParse(textBox3.Text, out unInt))
            {

                MessageBox.Show("El precio debe ser un número");
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Int32 unInt;
            if (!Int32.TryParse(textBox3.Text, out unInt))
            {

                MessageBox.Show("El costo debe ser un número");
                return;
            }

        }


        private void monthCalendarInicio_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox4.Text = monthCalendarInicio.SelectionRange.Start.ToShortDateString();
            monthCalendarInicio.Visible = false;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            monthCalendarVencimiento.Visible = true;
        }

        private void monthCalendarVencimiento_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox5.Text = monthCalendarInicio.SelectionRange.Start.ToShortDateString();
            monthCalendarVencimiento.Visible = false;
        }

        private void textBoxCod_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            monthCalendarInicio.Visible = true;
        }

        private void textBox5_Click_1(object sender, EventArgs e)
        {
            monthCalendarVencimiento.Visible = true;

        }






    }
}
