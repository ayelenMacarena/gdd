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
    public partial class modificarPublicacion : Form
    {
        DataGridViewRow miPublicacion;
        string user;
        public modificarPublicacion(DataGridViewRow filaSeleccionada, string username)
        {
            InitializeComponent();
            miPublicacion = filaSeleccionada;
            user = username;
            textBoxCod.Text = filaSeleccionada.Cells["publicacion_id"].Value.ToString();
            textBox1.Text = username.ToString();
            textBoxDescripcion.Text = filaSeleccionada.Cells["publ_descripcion"].Value.ToString();
            textBox6.Text = filaSeleccionada.Cells["publ_cantidad"].Value.ToString();
            textBox3.Text = filaSeleccionada.Cells["publ_precio"].Value.ToString();
            

            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            string rubros = "select rubr_descripcion_corta from LA_PETER_MACHINE.rubro";
            SqlCommand listRubros = new SqlCommand(rubros, conexion);
            SqlDataReader rub = listRubros.ExecuteReader();
            List<String> rubritos = new List<String>();
            
            if (rub.HasRows)
            {
                while (rub.Read())
                {
                    rubritos.Add(rub["rubr_descripcion_corta"].ToString());
                }

            }

            comboBox1.Text = filaSeleccionada.Cells["Rubro"].Value.ToString();
            
            comboBox1.DataSource = rubritos;
            conexion.Close();
            conexion.Open();

            string visibilidad = "select visi_descripcion from LA_PETER_MACHINE.visibilidad";
            SqlCommand listaVisi = new SqlCommand(visibilidad, conexion);

            SqlDataReader vis = listaVisi.ExecuteReader();
            List<String> visib = new List<String>();
            if (vis.HasRows)
            {
                while (vis.Read())
                {

                    comboBox2.Items.Add(vis["visi_descripcion"].ToString());
                }
            }

            comboBox2.Text = filaSeleccionada.Cells["Visibilidad"].Value.ToString();
            
            
            textBox4.Text = filaSeleccionada.Cells["publ_fecha_inicio"].Value.ToString();
            textBox5.Text = filaSeleccionada.Cells["publ_fecha_fin"].Value.ToString();
            
            comboBox5.Text =  filaSeleccionada.Cells["Estado"].Value.ToString();

            conexion.Close();
            MessageBox.Show(filaSeleccionada.Cells["Rubro"].Value.ToString());
            if (filaSeleccionada.Cells["publ_preguntas"].Value.ToString() == "True")
            {

                comboBox3.Text = "Si";
            }
            else
            {
                comboBox3.Text = "No";
            }
            if (filaSeleccionada.Cells["publ_envio_habilitado"].Value.ToString() == "True")
            {

                comboBox4.Text = "Si";
            }
            else
            {
                comboBox4.Text = "No";
            }            
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (isNumeric(e.KeyChar) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }


        public bool isNumeric(Char c)
        {
            if ((c >= '0' && c <= '9'))
            {
                return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void monthCalendarVencimiento_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox5.Text = monthCalendarInicio.SelectionRange.Start.ToShortDateString();
            monthCalendarVencimiento.Visible = false;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            monthCalendarInicio.Visible = true;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            monthCalendarVencimiento.Visible = true;
        }

        private void monthCalendarInicio_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            textBox4.Text = monthCalendarInicio.SelectionRange.Start.ToShortDateString();
            monthCalendarInicio.Visible = false;
        }

        private void monthCalendarVencimiento_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            textBox5.Text = monthCalendarVencimiento.SelectionRange.Start.ToShortDateString();
            monthCalendarVencimiento.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();

            SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
            rdo.Size = 255;
            rdo.Direction = ParameterDirection.Output;
            SqlCommand publicar = new SqlCommand("LA_PETER_MACHINE.modificarPublicacion", conexion);
            publicar.CommandType = CommandType.StoredProcedure;
            publicar.Parameters.AddWithValue("@publ_id", miPublicacion.Cells["publicacion_id"].Value.ToString());
            publicar.Parameters.AddWithValue("@estado", comboBox5.Text);
            publicar.Parameters.AddWithValue("@descripcion", textBoxDescripcion.Text);
            if (Convert.ToDecimal(textBox3.Text) < 0)
            {
                MessageBox.Show("El precio no puede ser negativo");
                return;
            }
            publicar.Parameters.AddWithValue("@precio", textBox3.Text);
            publicar.Parameters.AddWithValue("@costo", DBNull.Value);
            publicar.Parameters.AddWithValue("@rubro", comboBox1.Text);
            publicar.Parameters.AddWithValue("@visibilidad", comboBox2.Text);
            publicar.Parameters.AddWithValue("@preguntas", comboBox3.Text);
            publicar.Parameters.AddWithValue("@envio", comboBox4.Text);
            if (Convert.ToDateTime(textBox4.Text) > Convert.ToDateTime(textBox5.Text))
            {

                MessageBox.Show("La fecha de fin no puede ser menor a la de inicio");
                return;
            }
            publicar.Parameters.AddWithValue("@fecha_inicio", textBox4.Text);
            publicar.Parameters.AddWithValue("@fecha_fin", textBox5.Text);
            publicar.Parameters.AddWithValue("@stock", textBox6.Text);
            publicar.Parameters.Add(rdo);


            publicar.ExecuteNonQuery();
            MessageBox.Show(rdo.Value.ToString());
            conexion.Close();

            if (comboBox5.Text == "Activa" && comboBox2.Text != "Gratis")
            {
                Logica_GenerarPublicacion.facturarPublicacion(comboBox2.Text, user, Convert.ToInt32(textBoxCod.Text));
            }

            this.Close();

        }       

      
    }
}
