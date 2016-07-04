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
    public partial class Comprar : Form
    {
        DataGridViewRow fila;
        Listado_ComprarOfertar listado;

        public Comprar(DataGridViewRow filaSeleccionada, Listado_ComprarOfertar listadoPubl)
        {
            InitializeComponent();
            fila = filaSeleccionada;
            listado = listadoPubl;
            var cantidad = filaSeleccionada.Cells["publ_cantidad"].Value;
            numericCantidad.Minimum = 1;
            numericCantidad.Maximum = Convert.ToInt32(filaSeleccionada.Cells["publ_cantidad"].Value);
            labelInfoDescripcion.Text = filaSeleccionada.Cells["publ_descripcion"].Value.ToString();
            labelInfoVendedor.Text = filaSeleccionada.Cells["publ_id_vendedor"].Value.ToString();
            labelInfoPrecio.Text = (Convert.ToDecimal(filaSeleccionada.Cells["publ_precio"].Value) * numericCantidad.Value).ToString();
        }

        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {
            labelInfoPrecio.Text = (Convert.ToInt32(fila.Cells["publ_precio"].Value) * numericCantidad.Value).ToString();
        }

        private void buttonConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (comboBoxFormaPago.Text == String.Empty)
            {
                MessageBox.Show("Se debe indicar la forma de pago.");
                return;
            }

            Logica_ComprarOfertar.Comprar(Convert.ToInt32(fila.Cells["publicacion_id"].Value), Convert.ToInt32(numericCantidad.Value));
            
            Logica_ComprarOfertar.InsertarFactura(Convert.ToInt32(fila.Cells["publicacion_id"].Value), Convert.ToInt32(numericCantidad.Value));

            listado.Mostrar();

            this.Close();
        }

        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   }
}
