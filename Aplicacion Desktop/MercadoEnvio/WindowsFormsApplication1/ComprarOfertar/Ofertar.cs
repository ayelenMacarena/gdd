using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ComprarOfertar
{
    public partial class Ofertar : Form
    {
        DataGridViewRow fila;

        public Ofertar(DataGridViewRow filaSeleccionada)
        {
            InitializeComponent();
            fila = filaSeleccionada;
            cantidad.Text = filaSeleccionada.Cells["publ_cantidad"].Value.ToString();
            labelInfoDescripcion.Text = filaSeleccionada.Cells["publ_descripcion"].Value.ToString();
            labelInfoVendedor.Text = filaSeleccionada.Cells["publ_id_vendedor"].Value.ToString();
            textBoxOferta.Text = (Convert.ToInt32(filaSeleccionada.Cells["publ_precio"].Value) + 1).ToString();
        }

        private void buttonConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxOferta.Text) <= (Convert.ToInt32(this.fila.Cells["publ_precio"].Value))){
                MessageBox.Show("La oferta debe ser mayor a la anterior");}
        }

        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
