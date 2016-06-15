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
            textBox2.Text = filaSeleccionada.Cells["publ_costo"].Value.ToString();

            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            string rubros = "select rubr_descripcion_corta, rubr_cod from LA_PETER_MACHINE.rubro";
            SqlCommand listRubros = new SqlCommand(rubros, conexion);
            SqlDataReader rub = listRubros.ExecuteReader();
            List<String> rubritos = new List<String>();
            if (rub.HasRows)
            {
                while (rub.Read())
                {
                    rubritos.Add(rub["rubr_descripcion_corta"].ToString());
                    if (rub["rubr_cod"].ToString() == filaSeleccionada.Cells["publ_cod_rubro"].Value.ToString())
                    {
                        comboBox1.SelectedItem = rub["rubr_descripcion_corta"].ToString();
                    }
                }

            }

            comboBox1.DataSource = rubritos;
            conexion.Close();
            conexion.Open();
            string visibilidad = "select visi_descripcion, visi_cod from LA_PETER_MACHINE.visibilidad";
            SqlCommand listaVisi = new SqlCommand(visibilidad, conexion);

            SqlDataReader vis = listaVisi.ExecuteReader();
            List<String> visib = new List<String>();
            if (vis.HasRows)
            {
                while (vis.Read())
                {

                    comboBox2.Items.Add(vis["visi_descripcion"].ToString());
                    if (vis["visi_cod"].ToString() == filaSeleccionada.Cells["publ_cod_visibilidad"].Value.ToString())
                    {
                        comboBox2.SelectedText = vis["visi_descripcion"].ToString();
                    }

                }


            }
            conexion.Close();
            textBox4.Text = filaSeleccionada.Cells["publ_fecha_inicio"].Value.ToString();
            textBox5.Text = filaSeleccionada.Cells["publ_fecha_fin"].Value.ToString();
            conexion.Open();
            string estado = "select esta_descripcion from LA_PETER_MACHINE.estado where estado_id = " + filaSeleccionada.Cells["publ_id_estado"].Value.ToString();
            SqlCommand estadoComando = new SqlCommand(estado, conexion);

            SqlDataReader est = estadoComando.ExecuteReader();

            while (est.Read())
            {
                comboBox5.SelectedText = est["esta_descripcion"].ToString();
            }
            conexion.Close();
            comboBox3.Text = filaSeleccionada.Cells["publ_preguntas"].Value.ToString();
            comboBox4.Text = filaSeleccionada.Cells["publ_envio_habilitado"].Value.ToString();


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
            textBox5.Text = monthCalendarInicio.SelectionRange.Start.ToShortDateString();
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
            publicar.Parameters.AddWithValue("@precio", textBox3.Text);
            publicar.Parameters.AddWithValue("@costo", textBox2.Text);
            publicar.Parameters.AddWithValue("@rubro", comboBox1.Text);
            publicar.Parameters.AddWithValue("@visibilidad", comboBox2.Text);
            publicar.Parameters.AddWithValue("@preguntas", comboBox3.Text);
            publicar.Parameters.AddWithValue("@envio", comboBox4.Text);
            publicar.Parameters.AddWithValue("@fecha_inicio", textBox4.Text);
            publicar.Parameters.AddWithValue("@fecha_fin", textBox5.Text);
            publicar.Parameters.AddWithValue("@stock", textBox6.Text);
            publicar.Parameters.Add(rdo);


            publicar.ExecuteNonQuery();
            MessageBox.Show(rdo.Value.ToString());
            conexion.Close();
            this.Close();

        }





        




      
    }
}
