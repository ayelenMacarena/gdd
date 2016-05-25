using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (ingresoUser.Text == "a" && ingresoPass.Text == "a") // TODO: Hay que hacer un SP 
            {
                MessageBox.Show("BIENVENIDO");
                fails = 0;
            }
            else
            {
                if (fails < 3)
                {
                    fails++;
                    MessageBox.Show("Usuario o Contraseña INCORRECTOS");
                }
                else
                {
                    //TODO: SP que inhabilita el usuario despues de 3 login mal.
                    MessageBox.Show("Ingreso 3 veces mal la contraseña, su usuario fue inhabilitado");

                }
            }
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
