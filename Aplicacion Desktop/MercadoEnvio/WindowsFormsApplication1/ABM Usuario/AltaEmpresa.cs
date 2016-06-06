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
    public partial class AltaEmpresa : Form
    {
        public AltaEmpresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                SqlConnection conexion = conectionDB.getConnection();
                conexion.Open();
                SqlCommand cmd = new SqlCommand("LA_PETER_MACHINE.Crear_Empresa", conexion);
                SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
                rdo.Size = 255;
                rdo.Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usuario", SqlDbType.NVarChar);
                cmd.Parameters["@usuario"].Value = textBox1.Text;
                cmd.Parameters.Add("@pasword", SqlDbType.NVarChar);
                cmd.Parameters["@pasword"].Value = textBox2.Text;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmd.Parameters["@nombre"].Value = textBox5.Text;
                cmd.Parameters.Add("@cuit", SqlDbType.NVarChar);
                cmd.Parameters["@cuit"].Value = maskedTextBox2.Text;
                cmd.Parameters.Add("@contacto", SqlDbType.NVarChar);
                cmd.Parameters["@contacto"].Value = textBox7.Text;
                cmd.Parameters.Add("@mail", SqlDbType.NVarChar);
                cmd.Parameters["@mail"].Value = textBox8.Text;
                cmd.Parameters.Add("@telefono", SqlDbType.NVarChar);
                cmd.Parameters["@telefono"].Value = textBox9.Text;
                cmd.Parameters.Add("@calle", SqlDbType.NVarChar);
                cmd.Parameters["@calle"].Value = textBox10.Text;
                cmd.Parameters.Add("@cod_postal", SqlDbType.NVarChar);
                cmd.Parameters["@cod_postal"].Value = textBox11.Text;
                cmd.Parameters.Add("@ciudad", SqlDbType.NVarChar);
                cmd.Parameters["@ciudad"].Value = textBox12.Text;
                cmd.Parameters.Add("@numero", SqlDbType.NVarChar);
                cmd.Parameters["@numero"].Value = textBox13.Text;
                cmd.Parameters.Add("@piso", SqlDbType.NVarChar);
                cmd.Parameters["@piso"].Value = textBox14.Text;
                cmd.Parameters.Add("@depto", SqlDbType.NVarChar);
                cmd.Parameters["@depto"].Value = textBox15.Text;
                cmd.Parameters.Add(rdo);
                cmd.ExecuteNonQuery();
                MessageBox.Show(rdo.Value.ToString());
            }
            else { MessageBox.Show("contraseña no coincide"); }
        }
        void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("formato inapropiado");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Empresa clie = new Empresa();
            this.Hide();
            clie.ShowDialog();
            this.Close();
        }
    }
}
