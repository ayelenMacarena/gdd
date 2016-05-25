using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void Inicio_Load_1(object sender, EventArgs e)
        {

        }

        private void Inicio_Load_2(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABM_Usuario.user formUser = new ABM_Usuario.user();
            this.Hide();
            formUser.ShowDialog();
            this.Close();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABM_Usuario.altaUser newUser = new ABM_Usuario.altaUser();
            this.Hide();
            newUser.ShowDialog();
            this.Close();
        }
    }
}
