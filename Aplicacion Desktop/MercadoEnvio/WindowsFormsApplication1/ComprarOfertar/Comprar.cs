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
        int comprador;

        public Comprar(DataGridViewRow filaSeleccionada, Listado_ComprarOfertar listadoPubl, int cliente)
        {
            InitializeComponent();
            fila = filaSeleccionada;
            listado = listadoPubl;
            comprador = cliente;
            var cantidad = filaSeleccionada.Cells["Cantidad"].Value;
            numericCantidad.Minimum = 1;
            numericCantidad.Maximum = Convert.ToInt32(filaSeleccionada.Cells["Cantidad"].Value);
            labelInfoDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
            labelInfoVendedor.Text = filaSeleccionada.Cells["Vendedor"].Value.ToString();
            labelInfoPrecio.Text = (Convert.ToDecimal(filaSeleccionada.Cells["Precio"].Value) * numericCantidad.Value).ToString();
        }

        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {
            labelInfoPrecio.Text = (Convert.ToInt32(fila.Cells["Precio"].Value) * numericCantidad.Value).ToString();
        }

        private void buttonConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (comboBoxFormaPago.Text == String.Empty)
            {
                MessageBox.Show("Se debe indicar la forma de pago.");
                return;
            }

            Logica_ComprarOfertar.InsertarFactura(Convert.ToInt32(fila.Cells["publicacion_id"].Value), Convert.ToInt32(numericCantidad.Value));

            Logica_ComprarOfertar.Comprar(Convert.ToInt32(fila.Cells["publicacion_id"].Value), Convert.ToInt32(numericCantidad.Value), comprador, 
                                                                                                        Convert.ToInt32(fila.Cells["publ_id_vendedor"].Value));

            listado.Mostrar();

            this.Close();
        }

        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   }
}
