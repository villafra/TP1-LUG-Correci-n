using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using Calculo;
using Estética;

namespace Presentación
{
    public partial class frmPlatos : Form
    {
        BLL_Plato oBLL_Plato;
        BE_Plato oBE_Plato;
        public frmPlatos()
        {
            InitializeComponent();
            oBE_Plato = new BE_Plato();
            oBLL_Plato = new BLL_Plato();
            ActualizarListado();
            Aspecto.FormatearDGV(dgvPlatos);
            Aspecto.FormatearGRP(grpPlatos);

        }

        private void Nuevo()
        {
            try
            {
                oBE_Plato.Codigo = 0;
                oBE_Plato.Tipo = ComboTipo.SelectedItem.ToString();
                oBE_Plato.Nombre = txtNombre.Text;
                oBE_Plato.Clase= ComboClase.SelectedItem.ToString();
                oBE_Plato.CostoUnitario = Convert.ToDecimal(txtCosto.Text);
                oBE_Plato.Stock = Convert.ToInt32(lblCantidad.Text);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void Viejo()
        {
            try
            {
                oBE_Plato.Codigo = Convert.ToInt32(txtCodigo.Text);
                oBE_Plato.Tipo = ComboTipo.SelectedItem.ToString();
                oBE_Plato.Nombre = txtNombre.Text;
                oBE_Plato.Clase = ComboClase.SelectedItem.ToString();
                oBE_Plato.CostoUnitario = Convert.ToDecimal(txtCosto.Text);
                oBE_Plato.Stock = Convert.ToInt32(lblCantidad.Text);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ActualizarListado()
        {
            Calculos.RefreshGrilla(dgvPlatos, oBLL_Plato.Listar());
            Aspecto.DGVPlatos(dgvPlatos);
            //Aspecto.DGVPlatosPedidos(dgvPedidosConPlat);
        }

        private void dgvPlatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBE_Plato = (BE_Plato)dgvPlatos.SelectedRows[0].DataBoundItem;
                txtCodigo.Text = oBE_Plato.Codigo.ToString();
                txtNombre.Text = oBE_Plato.Nombre;
                ComboTipo.Text = oBE_Plato.Tipo;
                ComboClase.Text = oBE_Plato.Clase;
                txtCosto.Text = oBE_Plato.CostoUnitario.ToString();
                lblCantidad.Text = oBLL_Plato.PromedioPlatoEnPedido(oBE_Plato).ToString() + "%";
                prgFrecuencia.Value = Convert.ToInt32(Math.Round(oBLL_Plato.PromedioPlatoEnPedido(oBE_Plato), 0));
                
            }
            catch { }
        }
    }
}
