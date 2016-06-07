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
namespace WindowsFormsApplication1.ABM_Usuario
{
     
    public partial class modificarCliente : Form
    {
        String usu;
        public modificarCliente(String usuario)
        {
            InitializeComponent();
            usu = usuario;
            SqlConnection conexion = conectionDB.getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.CommandText = "select clie_nombre,clie_apellido, clie_fecha_nac, pers_ciudad, pers_cod_postal, pers_depto, pers_domicilio_calle,pers_mail, pers_numero_calle, pers_piso, pers_telefono, usua_username, clie_dni,type_descripcion from LA_PETER_MACHINE.cliente,LA_PETER_MACHINE.usuario,LA_PETER_MACHINE.persona, LA_PETER_MACHINE.document_type where clie_id_persona=pers_id and pers_username=usua_username and usua_username=@usuario and type_id=clie_id_tipo_doc";
            cmd.Parameters.Add("@usuario", SqlDbType.NVarChar);
            cmd.Parameters["@usuario"].Value = usu;
            conexion.Open();
            adapter.Fill(table);
            textBox5.Text = table.Rows[0][0].ToString();
            textBox7.Text = table.Rows[0][1].ToString();
            maskedTextBox1.Text = table.Rows[0][2].ToString().Substring(0,10);
            textBox12.Text = table.Rows[0][3].ToString();
            textBox11.Text = table.Rows[0][4].ToString();
            textBox15.Text = table.Rows[0][5].ToString();
            textBox10.Text = table.Rows[0][6].ToString();
            textBox8.Text = table.Rows[0][7].ToString();
            textBox13.Text = table.Rows[0][8].ToString();
            textBox14.Text = table.Rows[0][9].ToString();
            textBox9.Text = table.Rows[0][10].ToString();
            textBox1.Text = table.Rows[0][11].ToString();
            textBox4.Text = table.Rows[0][12].ToString();
            textBox6.Text = table.Rows[0][13].ToString();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (textBox2.Text == textBox3.Text)
            {
                SqlConnection conexion = conectionDB.getConnection();
                conexion.Open();
                SqlCommand controlarUsarioHabilitado = new SqlCommand("LA_PETER_MACHINE.Modificar_Cliente", conexion);
                SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
                rdo.Size = 255;
                rdo.Direction = ParameterDirection.Output;

                rdo.Direction = ParameterDirection.Output;
                controlarUsarioHabilitado.CommandType = CommandType.StoredProcedure;
                controlarUsarioHabilitado.Parameters.Add("@Usuario", SqlDbType.NVarChar);
                controlarUsarioHabilitado.Parameters["@Usuario"].Value = textBox1.Text;
                controlarUsarioHabilitado.Parameters.Add("@pass", SqlDbType.NVarChar);
                controlarUsarioHabilitado.Parameters["@pass"].Value = textBox2.Text;
                controlarUsarioHabilitado.Parameters.Add("@ciudad", SqlDbType.NVarChar);
                controlarUsarioHabilitado.Parameters["@ciudad"].Value = textBox12.Text;
                controlarUsarioHabilitado.Parameters.Add("@apellido", SqlDbType.NVarChar);
                controlarUsarioHabilitado.Parameters["@apellido"].Value = textBox7.Text;
                controlarUsarioHabilitado.Parameters.Add("@nombre", SqlDbType.NVarChar);
                controlarUsarioHabilitado.Parameters["@nombre"].Value = textBox5.Text;
                controlarUsarioHabilitado.Parameters.Add("@mail", SqlDbType.NVarChar);
                controlarUsarioHabilitado.Parameters["@mail"].Value = textBox8.Text;
                controlarUsarioHabilitado.Parameters.Add("@telefono", SqlDbType.NVarChar);
                controlarUsarioHabilitado.Parameters["@telefono"].Value = textBox9.Text;
                controlarUsarioHabilitado.Parameters.Add("@calle", SqlDbType.NVarChar);
                 controlarUsarioHabilitado.Parameters["@calle"].Value = textBox10.Text;
                controlarUsarioHabilitado.Parameters.Add("@cod_postal", SqlDbType.NVarChar);
                controlarUsarioHabilitado.Parameters["@cod_postal"].Value = textBox11.Text;
                controlarUsarioHabilitado.Parameters.Add("@numero", SqlDbType.NVarChar);
                controlarUsarioHabilitado.Parameters["@numero"].Value = textBox13.Text;
                controlarUsarioHabilitado.Parameters.Add("@dpto", SqlDbType.NVarChar);
                controlarUsarioHabilitado.Parameters["@dpto"].Value = textBox15.Text;
                controlarUsarioHabilitado.Parameters.Add("@piso", SqlDbType.NVarChar);
                controlarUsarioHabilitado.Parameters["@piso"].Value = textBox14.Text;
                  controlarUsarioHabilitado.Parameters.Add("@fecha", SqlDbType.NVarChar);
                controlarUsarioHabilitado.Parameters["@fecha"].Value = maskedTextBox1.Text; 
               controlarUsarioHabilitado.Parameters.Add(rdo);
                controlarUsarioHabilitado.ExecuteNonQuery();
                MessageBox.Show(rdo.Value.ToString());
            }
            else { MessageBox.Show("No coincide la contraseña"); }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditarRoles edit = new EditarRoles(usu, "cliente");
            this.Hide();
            edit.ShowDialog();
            this.Close();
        }
    }
}
