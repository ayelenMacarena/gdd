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
using System.Reflection;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class MenuPrincipal : Form
    {
        List<string> listaFuncionalidades = new List<string>();
        List<string> listaNombres = new List<string>();
        string usuario;

        public MenuPrincipal(string rol, string username)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.LayoutMdi(MdiLayout.Cascade);
            usuario = username;
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand getFuncionalidades = new SqlCommand("LA_PETER_MACHINE.get_funcionalidades_para_rol", conexion);
            getFuncionalidades.CommandType = CommandType.StoredProcedure;
            //Paso los parámetros al SP
            getFuncionalidades.Parameters.AddWithValue("@rol_desc", rol);

            SqlDataReader funcionalidadesFunciones = getFuncionalidades.ExecuteReader();

            if (funcionalidadesFunciones.HasRows)
            {
                while (funcionalidadesFunciones.Read())
                {
                    listaFuncionalidades.Add(funcionalidadesFunciones["func_procedure"].ToString());
                    listaNombres.Add(funcionalidadesFunciones["func_descripcion"].ToString());
                }
                this.seteoBotones();
            }
            else
            {
                MessageBox.Show("El rol no tiene funciones asignadas");
            }
            conexion.Close();

        }



//Seteo la configuracion de cada boton para que se vea el nombre y se oculte si no existe
        private void seteoBotones()
        {
            int contador = 1;

            if (listaNombres.Count >= contador)
            {
                button1.Text = listaNombres[contador-1];
            }
            button1.Visible = (listaNombres.Count >= contador);
            button1.Enabled = (listaNombres.Count >= contador);
            contador ++;

            if (listaNombres.Count >= contador)
            {
                button2.Text = listaNombres[contador-1];
            }
            button2.Visible = listaNombres.Count >= contador;
            button2.Enabled = listaNombres.Count >= contador;
            contador ++;

            if (listaNombres.Count >= contador)
            {
                button3.Text = listaNombres[contador-1];
            }
            button3.Visible = listaNombres.Count >= contador;
            button3.Enabled = listaNombres.Count >= contador;
            contador ++;

            if (listaNombres.Count >= contador)
            {
                button4.Text = listaNombres[contador-1];
            }
            button4.Visible = listaNombres.Count >= contador;
            button4.Enabled = listaNombres.Count >= contador;
            contador ++;

            if (listaNombres.Count >= contador)
            {
                button5.Text = listaNombres[contador-1];
            }
            button5.Visible = listaNombres.Count >= contador;
            button5.Enabled = listaNombres.Count >= contador;
            contador ++;

            if (listaNombres.Count >= contador)
            {
                button6.Text = listaNombres[contador-1];
            }
            button6.Visible = listaNombres.Count >= contador;
            button6.Enabled = listaNombres.Count >= contador;
            contador++;

            if (listaNombres.Count >= contador)
            {
                button7.Text = listaNombres[contador - 1];
            }
            button7.Visible = listaNombres.Count >= contador;
            button7.Enabled = listaNombres.Count >= contador;
            contador++;
            
            if (listaNombres.Count >= contador)
            {
                button8.Text = listaNombres[contador - 1];
            }
            button8.Visible = listaNombres.Count >= contador;
            button8.Enabled = listaNombres.Count >= contador;
            contador++;
            
            if (listaNombres.Count >= contador)
            {
                button9.Text = listaNombres[contador - 1];
            }
            button9.Visible = listaNombres.Count >= contador;
            button9.Enabled = listaNombres.Count >= contador;
            contador++;
            
            if (listaNombres.Count >= contador)
            {
                button10.Text = listaNombres[contador - 1];
            }
            button10.Visible = listaNombres.Count >= contador;
            button10.Enabled = listaNombres.Count >= contador;
            contador++;

            if (listaNombres.Count >= contador)
            {
                button11.Text = listaNombres[contador - 1];
            }
            button11.Visible = listaNombres.Count >= contador;
            button11.Enabled = listaNombres.Count >= contador;

            button12.Text = "salir";
        }


//Aca esta el comportamiento de cada boton, (cada uno ejecuta la funcionalidad asignada)
        private void button1_Click(object sender, EventArgs e)
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(listaFuncionalidades[0]);
            theMethod.Invoke(this, null);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(listaFuncionalidades[1]);
            theMethod.Invoke(this, null);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(listaFuncionalidades[2]);
            theMethod.Invoke(this, null);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(listaFuncionalidades[3]);
            theMethod.Invoke(this, null);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(listaFuncionalidades[4]);
            theMethod.Invoke(this, null);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(listaFuncionalidades[5]);
            theMethod.Invoke(this, null);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(listaFuncionalidades[6]);
            theMethod.Invoke(this, null);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(listaFuncionalidades[7]);
            theMethod.Invoke(this, null);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(listaFuncionalidades[8]);
            theMethod.Invoke(this, null);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(listaFuncionalidades[9]);
            theMethod.Invoke(this, null);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(listaFuncionalidades[10]);
            theMethod.Invoke(this, null);
        }
        //Salir
        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }


//Aca pongo los comportamientos de cada Funcionalidad
        public void STORE_publicar()
        {
            //Aca voy para Publicar
            //Como todas las publicaciones inician en borrador, ya la creo desde acá.

            Generar_Publicación.tiposDePublicacion generarPubli = new Generar_Publicación.tiposDePublicacion();
            generarPubli.MdiParent = this;
            generarPubli.Show();
            generarPubli.Location = new Point(0, 49);
        }
        public void STORE_categorizar_publicacion()
        { 
            //Aca voy para categorizar publicacion
            this.Hide();
            this.Close();
        }
        public void STORE_visibilidad()
        {
            //Aca voy para administrar visibilidades
            ABM_Visibilidad.Visibilidad visib = new ABM_Visibilidad.Visibilidad();
            visib.MdiParent = this;
            visib.Show();
            visib.Location = new Point(0, 49);
        }
        public void STORE_comprar_ofertar()
        { 
            //Aca voy para comprar ofertar
            //ComprarOfertar.Mostrar compOfer = new ComprarOfertar.Mostrar(15, 3, 0);
            this.Hide();
            //compOfer.ShowDialog();
            this.Close();
            //compOfer.MdiParent = this;
            //compOfer.Show();
            //compOfer.Location = new Point(0, 49);
        }
        public void STORE_historial_cliente()
        { 
            //Aca voy para historial cliente
            //Historial_Cliente.Mostrar compOfer = new Historial_Cliente.Mostrar(15, 3, 0);
            this.Hide();
           // compOfer.ShowDialog();
            this.Close();
            //Historial_Cliente.Mostrar histoClie = new Historial_Cliente.Mostrar(15, 3, 0);
            //histoClie.MdiParent = this;
            //histoClie.Show();
            //histoClie.Location = new Point(0, 49);
        }
        public void STORE_calificar()
        { 
            //Aca voy para calificar
            this.Hide();
            this.Close();
        }
        public void STORE_facturas_realizadas()
        { 
            //Aca voy para facturas realizadas
            this.Hide();
            this.Close();
        }
        public void STORE_listado_estadistico()
        { 
            //Aca voy para listado estadistico
            Listado_Estadistico.ListadoEstadistico listadoEstad = new Listado_Estadistico.ListadoEstadistico();
            listadoEstad.MdiParent = this;
            listadoEstad.Show();
            listadoEstad.Location = new Point(0, 49);
        }
        public void STORE_administrar_usuario()
        { 
            //Aca voy para administrar usuario
            ABM_Usuario.Cliente admUsuario = new ABM_Usuario.Cliente();
            admUsuario.MdiParent = this;
            admUsuario.Show();
            admUsuario.Location = new Point(0, 49);
        }
        public void STORE_administrar_rol()
        { 
            //Aca voy para administrar rol
            ABM_Rol.Rol admRol = new ABM_Rol.Rol();
            admRol.MdiParent = this;
            admRol.Show();
            admRol.Location = new Point(0, 49);
        }
        public void STORE_administrar_rubro()
        {
            //Aca voy para administrar rubro
            ABM_Rubro.Rubro admRubro = new ABM_Rubro.Rubro();
            admRubro.MdiParent = this;
            admRubro.Show();
            admRubro.Location = new Point(0, 49);

        }

    }
}