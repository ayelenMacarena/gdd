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
using System.Data.SqlTypes;
namespace WindowsFormsApplication1.Listado_Estadistico
{
    public partial class ElegirListado : Form
    {
        public ElegirListado(String año, String trimestre)
        {
            InitializeComponent();
            label1.Text = año;
            label2.Text = trimestre;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") { MessageBox.Show("Debe elegir un listado"); }
            else
            {
                switch (comboBox1.Text)
                {
                    case "Top de vendedores con mayor cant. de prod. no vendidos":
                        ListadoVendXProdSinVend vent = new ListadoVendXProdSinVend(label1.Text, label2.Text);
                        this.Hide();
                        vent.ShowDialog();
                        this.Close();
                        break;
                    case "Top de clientes con mayor cant. de prod. comprados":
                        ListadoXProductComprados vent2 = new ListadoXProductComprados(label1.Text, label2.Text);
                        this.Hide();
                        vent2.ShowDialog();
                        this.Close();
                        break;
                    case "Top de vendedores con mayor cant. de facturas":
                        ListadoXFacturas vent3 = new ListadoXFacturas(label1.Text, label2.Text);
                        this.Hide();
                        vent3.ShowDialog();
                        this.Close();
                        break;
                    case "Top de vendedores con mayor monto facturado":
                        ListadoXFacturas vent4 = new ListadoXFacturas(label1.Text, label2.Text);
                        this.Hide();
                        vent4.ShowDialog();
                        this.Close();
                        break;
                }
            }
            
            }

        private void ElegirListado_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ElegirTrimestre vent = new ElegirTrimestre(label1.Text);
            this.Hide();
            vent.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
