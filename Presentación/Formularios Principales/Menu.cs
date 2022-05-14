using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estética;
using Calculo;

namespace Presentación
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            Aspecto.FormatearForm(this, panelMenuIzq, this.Width, this.Height);
            frmBienvenida frm = new frmBienvenida();
            Aspecto.AbrirNuevoForm(this, frm);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Calculos.Salir();
        }
    }
}
