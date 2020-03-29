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
using TALLER.Controlador;
using TALLER.Modelo;

namespace TALLER.Vista
{
    public partial class FormLote : Form
    {
        private BaseDatos bd = new BaseDatos();
        private ListaCompra listaCompra;
        private List<ListaLote> listaLote;
        public FormLote(ListaCompra lc)
        {
            InitializeComponent();
            listaCompra = lc;
        }

        private void FormLote_Load(object sender, EventArgs e)
        {
            prepararVentana();
            cargarCabeza();
            cargarCuerpo();
            cargarPie();
        }

        private void prepararVentana()
        {
            this.lblDetalle.Text = "DETALLE DE COMPRA " + listaCompra.IDCOMPRA;
            /*if (listaVenta.ESTADO == "CANCELADO")
            {
                this.btnCancelar.Visible = false;
                this.lblEstado.Visible = true;
                this.txtBoxDescripcion.ReadOnly = true;
            }*/
        }

        private void cargarCabeza()
        {
            this.txtBoxUsuario.Text = listaCompra.NOMBREUSUARIO;
            this.txtBoxDistribuidora.Text = listaCompra.NOMBREDISTRIBUIDORA;
            this.txtBoxFecha.Text = listaCompra.FECHA;
        }

        private void cargarCuerpo()
        {
            listaLote = bd.listarLote(listaCompra.IDCOMPRA);

            foreach (ListaLote lc in listaLote)
                this.dgvCompra.Rows.Add();

            for (int i = 0; i < this.dgvCompra.RowCount; i++)
            {
                ListaLote lc = listaLote[i];
                DataGridViewRow row = this.dgvCompra.Rows[i];
                row.Cells[0].Value = lc.CODIGO;
                row.Cells[1].Value = lc.PRODUCTO;
                row.Cells[2].Value = lc.CONTENIDO;
                row.Cells[3].Value = lc.CANTIDAD;
                row.Cells[4].Value = lc.PRECIOCOMPRA;
                row.Cells[5].Value = lc.CANTIDADPAQUETE;
                row.Cells[6].Value = lc.CANTIDADENPAQUETE;
                row.Cells[7].Value = lc.COSTO;
                row.Cells[8].Value = lc.EXPIRACION;
            }
        }

        private void cargarPie()
        {
            this.txtBoxCosto.Text = this.listaCompra.COSTOTOTAL.ToString();
            this.txtBoxDescripcion.Text = this.listaCompra.DESCRIPCION;
        }
    }
}
