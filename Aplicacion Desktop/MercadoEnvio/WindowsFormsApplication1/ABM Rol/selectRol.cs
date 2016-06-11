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

        public selectRol(List<String> listaRoles)
        {
            InitializeComponent();
            comboBox1.DataSource = listaRoles;
        }
       
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aca va la pantalla de tato, puedo llegar a pasarle la selección.
            rolSelected = (string)comboBox1.SelectedItem;
            ABM_Usuario.MenuPrincipal menuPrincipal = new ABM_Usuario.MenuPrincipal(rolSelected);
            this.Hide();
            menuPrincipal.ShowDialog();
            this.Close();
        }

        private void selectRol_Load(object sender, EventArgs e)
        {
            
        }
    }
}
