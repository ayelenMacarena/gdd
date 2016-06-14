using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class selectRol : Form
    {
        string rolSelected;
        string myUser;

        public selectRol(List<String> listaRoles, String username)
        {
            InitializeComponent();
            comboBox1.DataSource = listaRoles;
            myUser = username;
        }
       
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void selectRol_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rolSelected = (string)comboBox1.SelectedItem;
            ABM_Usuario.MenuPrincipal menuPrincipal = new ABM_Usuario.MenuPrincipal(rolSelected, myUser);
            this.Hide();
            menuPrincipal.ShowDialog();
            this.Close();

        }

    }
}
