﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class AltaCliente : Form
    {
        string dateTimeStamp = ConfigurationManager.AppSettings["dateTimeStamp"].ToString();

        public AltaCliente()
        {
            InitializeComponent();
            maskedTextBox1.Mask = "00/00/0000";

            SqlConnection conexion = conectionDB.getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            cmd.CommandText = "select type_descripcion from LA_PETER_MACHINE.document_type";
            conexion.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
            }
        }

        void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("formato inapropiado");
        }

        void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("formato inapropiado");
        }


        public bool isNotEmpty(TextBox text, String campo)
        {
            if (text.Text == "")
            {
                MessageBox.Show("el campo " + campo + " esta vacio");
                return false;
            }
            else { return true; }
        }

        public bool isNotEmpty(ComboBox text, String campo)
        {

            if (text.Text == "")
            {
                MessageBox.Show("el campo " + campo + " esta vacio");
                return false;

            }
            else { return true; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (isNotEmpty(textBox1, "usuario") && isNotEmpty(textBox2, "contraseña") &&
                isNotEmpty(textBox5, "nombre") && isNotEmpty(textBox7, "apellido") &&
                isNotEmpty(textBox4, "documento") && isNotEmpty(comboBox1, "tipo de documento"))
            {
                if (textBox2.Text == textBox3.Text)
                {
                    SqlConnection conexion = conectionDB.getConnection();
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("LA_PETER_MACHINE.Crear_Cliente", conexion);
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
                    cmd.Parameters.Add("@apellido", SqlDbType.NVarChar);
                    cmd.Parameters["@apellido"].Value = textBox7.Text;
                    cmd.Parameters.Add("@dni", SqlDbType.NVarChar);
                    cmd.Parameters["@dni"].Value = textBox4.Text;
                    cmd.Parameters.Add("@fecha_nac", SqlDbType.NVarChar);
                    cmd.Parameters["@fecha_nac"].Value = maskedTextBox1.Text;
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
                    cmd.Parameters.Add("@tipo_DNI", SqlDbType.NVarChar);
                    cmd.Parameters["@tipo_DNI"].Value = comboBox1.Text;
                    cmd.Parameters.Add("@fechaCreacion", SqlDbType.NVarChar);
                    cmd.Parameters["@fechaCreacion"].Value = dateTimeStamp;
                    cmd.Parameters.Add(rdo);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(rdo.Value.ToString());
                    if (rdo.Value.ToString() == "cliente creado correctamente") { this.Close(); }
                }
                else { MessageBox.Show("contraseña no coincide"); }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cliente clie = new Cliente();
            this.Hide();
            clie.MdiParent = this.MdiParent;
            clie.Show();
            clie.Location = new Point(0, 49);
            this.Close();
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

    }
}
