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
        public selectRol(List<String> listaRoles)
        {
            InitializeComponent();
            List<String> lista = listaRoles;
        }
        private void selectRol_Load(object sender, EventArgs e) 
        {   comboBox1.Items.Add("weekdays"); 
            comboBox1.Items.Add("year");
            
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
