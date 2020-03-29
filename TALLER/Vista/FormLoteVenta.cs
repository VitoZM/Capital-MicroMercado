using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TALLER.ClasesVista;
using TALLER.Modelo;
using TALLER.Controlador;

namespace TALLER.Vista
{
    public partial class FormLoteVenta : Form
    {
        private BaseDatos bd = new BaseDatos();
        private ListaVenta listaVenta;
        private List<ListaLoteVenta> listaLoteVenta;
        public FormLoteVenta(ListaVenta v)
        {
            InitializeComponent();
            listaVenta = v;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormLoteVenta_Load(object sender, EventArgs e)
        {
            prepararVentana();
            cargarCabeza();
            cargarCuerpo();
            cargarPie();
        }

        private void prepararVentana()
        {
            this.lblDetalle.Text = "DETALLE DE VENTA " + listaVenta.IDVENTA;
            if(listaVenta.ESTADO == "CANCELADO")
            {
                this.btnCancelar.Visible = false;
                this.lblEstado.Visible = true;
                this.txtBoxDescripcion.ReadOnly = true;
            }
        }

        private void cargarCabeza()
        {
            this.txtBoxCliente.Text = listaVenta.NOMBRECLIENTE;
            this.txtBoxVendedor.Text = listaVenta.NOMBREUSUARIO;
            this.txtBoxFecha.Text = listaVenta.FECHA;
            this.txtBoxCi.Text = listaVenta.CICLIENTE;
        }

        private void cargarCuerpo()
        {
            listaLoteVenta = bd.listarLoteVenta(listaVenta.IDVENTA);

            foreach (LoteVenta l in listaLoteVenta)
                this.dgvVenta.Rows.Add();

            for (int i = 0; i < this.dgvVenta.RowCount; i++)
            {
                ListaLoteVenta lv = listaLoteVenta[i];
                DataGridViewRow row = this.dgvVenta.Rows[i];
                row.Cells[0].Value = lv.CODIGO;
                row.Cells[1].Value = lv.NOMBRE + " " + lv.MARCA;
                row.Cells[2].Value = lv.CONTENIDO;
                row.Cells[3].Value = lv.PRECIOVENTA;
                row.Cells[4].Value = lv.CANTIDAD;
                row.Cells[5].Value = lv.COSTO;
            }
        }

        private void cargarPie()
        {
            this.txtBoxEfectivo.Text = this.listaVenta.EFECTIVO.ToString();
            this.txtBoxCambio.Text = this.listaVenta.CAMBIO.ToString();
            this.txtBoxPago.Text = this.listaVenta.PAGO.ToString();
            this.txtBoxCosto.Text = this.listaVenta.COSTOTOTAL.ToString();
            this.txtBoxDescripcion.Text = this.listaVenta.DESCRIPCION;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA CANCELAR LA VENTA?", "CANCELAR VENTA", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string descripcion = this.txtBoxDescripcion.Text;
                bd.cancelarVenta(listaVenta.IDVENTA, descripcion);
                MessageBox.Show("¡VENTA CANCELADA EXITOSAMENTE!");
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
