using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Historial_Cliente
{
    public partial class Historial : Form
    {
        int cliente = 39; //Harcodeado, pero deberia recibirlo del login.
        string usuario;
        public Historial(string username)
        {
            InitializeComponent();
            usuario = username;
            this.labelCliente.Text = String.Format("{0}", cliente);
        }
    }
}
