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
        Listado_ComprarOfertar listado;

        public Ofertar(DataGridViewRow filaSeleccionada, Listado_ComprarOfertar listadoPubl)
        {
            InitializeComponent();
            fila = filaSeleccionada;
            listado = listadoPubl;
            cantidad.Text = filaSeleccionada.Cells["publ_cantidad"].Value.ToString();
            labelInfoDescripcion.Text = filaSeleccionada.Cells["publ_descripcion"].Value.ToString();
            labelInfoVendedor.Text = filaSeleccionada.Cells["publ_id_vendedor"].Value.ToString();
            textBoxOferta.Text = (Convert.ToInt32(filaSeleccionada.Cells["publ_precio"].Value) + 1).ToString();
            labelPrice.Text = (Convert.ToDecimal(filaSeleccionada.Cells["publ_precio"].Value)).ToString();
        }

        private void buttonConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxOferta.Text) <= (Convert.ToInt32(this.fila.Cells["publ_precio"].Value))){
                MessageBox.Show("La oferta debe ser mayor a la actual");}

            Logica_ComprarOfertar.Ofertar(Convert.ToInt32(fila.Cells["publicacion_id"].Value), Convert.ToInt32(textBoxOferta.Text));

            listado.Mostrar();

            this.Close();
        }

        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
