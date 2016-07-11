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
        String user;

        public Ofertar(DataGridViewRow filaSeleccionada, Listado_ComprarOfertar listadoPubl, String usuario)
        {
            InitializeComponent();
            fila = filaSeleccionada;
            listado = listadoPubl;
            user = usuario;
            cantidad.Text = filaSeleccionada.Cells["Cantidad"].Value.ToString();
            labelInfoDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
            labelInfoVendedor.Text = filaSeleccionada.Cells["Vendedor"].Value.ToString();
            textBoxOferta.Text = (Convert.ToInt32(filaSeleccionada.Cells["Precio"].Value) + 1).ToString();
            labelPrice.Text = (Convert.ToDecimal(filaSeleccionada.Cells["Precio"].Value)).ToString();
        }

        private void buttonConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxOferta.Text) <= (Convert.ToInt32(this.fila.Cells["Precio"].Value))){
                MessageBox.Show("La oferta debe ser mayor a la actual: ${0}",
                                        Convert.ToString(Convert.ToInt32(this.fila.Cells["Precio"].Value)));}

            Logica_ComprarOfertar.Ofertar(Convert.ToInt32(fila.Cells["publicacion_id"].Value), Convert.ToInt32(textBoxOferta.Text), user);

            listado.Mostrar();

            this.Close();
        }

        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (isNumeric(e.KeyChar) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }


        public bool isNumeric(Char c)
        {
            if ((c >= '0' && c <= '9'))
            {
                return true;
            }
            return false;
        }


    }
}
