using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TALLER.Controlador;
using TALLER.Modelo;

namespace TALLER.Vista
{
    public partial class FormTarjetas : Form
    {
        BaseDatos bd = new BaseDatos();
        DataTable tabla = new DataTable();
        List<Producto> listarProductos;
        public Producto producto;
        private Compra compra;
        private Distribuidora distribuidora;
        private List<Lote> listaLote = new List<Lote>();
        private Usuario usuario;

        public FormTarjetas(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }

        private void FormTarjetas_Load(object sender, EventArgs e)
        {
            armarTabla();
            cargarDatos();
            cargarMontos();
        }

        private void cargarMontos()
        {
            decimal deuda = bd.obtenerMontoDeudaTarjetas();
            decimal prestado = bd.obtenerMontoPrestadoTarjetas();
            decimal efectivo = bd.obtenerMontoEfectivoTarjetas();
            decimal capital = bd.obtenerCapitalTarjetas();
            decimal montoTotal = prestado + efectivo + capital - deuda;

            this.txtBoxMontoDeuda.Text = deuda.ToString();
            this.txtBoxMontoPrestado.Text = prestado.ToString();
            this.txtBoxMontoEfectivo.Text = efectivo.ToString();
            this.txtBoxCapital.Text = capital.ToString();
            this.txtBoxMontoTotal.Text = montoTotal.ToString();

            if (montoTotal < 0)
                this.txtBoxMontoTotal.ForeColor = Color.Red;
        }

        private void armarTabla()
        {
            tabla.Columns.Add("CANTIDAD");//0
            tabla.Columns.Add("CODIGO");//1
            tabla.Columns.Add("NOMBRE");//2
            tabla.Columns.Add("MARCA");//3
            tabla.Columns.Add("CONTENIDO");//4
            tabla.Columns.Add("PRECIO COMPRA");//5
            tabla.Columns.Add("PRECIO VENTA");//6
            tabla.Columns.Add("UBICACION");//7
            tabla.Columns.Add("DESCRIPCION");//8
            tabla.Columns.Add("ID");//9
            tabla.Columns.Add("CATEGORIA");//10
        }

        private void cargarDatos()
        {
            listarProductos = bd.listarProductos();
            tabla.Rows.Clear();
            foreach (Producto p in listarProductos)
                if (p.NOMBRE == "TARJETA")
                    tabla.Rows.Add(new Object[] { p.CANTIDAD, p.CODIGO, p.NOMBRE, p.MARCA, p.CONTENIDO, p.PRECIOCOMPRA, p.PRECIOVENTA, p.UBICACION, p.DESCRIPCION, p.IDPRODUCTO, p.CATEGORIA });

            this.dgvTarjetas.DataSource = tabla;

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string codigo = this.txtBoxBuscarCodigo.Text;
            ingresarProducto(codigo);
        }

        private void ingresarProducto(string codigo)
        {
            Producto producto = bd.getProducto(codigo);
            if (producto != null && producto.NOMBRE == "TARJETA")
            {
                this.dgvVenta.Rows.Add();
                int fila = this.dgvVenta.Rows.Count - 1;

                this.dgvVenta.Rows[fila].Cells[0].Value = producto.CODIGO;
                this.dgvVenta.Rows[fila].Cells[1].Value = producto.NOMBRE + " " + producto.MARCA;
                this.dgvVenta.Rows[fila].Cells[2].Value = producto.CONTENIDO;
                this.dgvVenta.Rows[fila].Cells[4].Value = producto.PRECIOCOMPRA.ToString();
                this.dgvVenta.Rows[fila].Cells[5].Value = "0";
                this.dgvVenta.Rows[fila].Cells[6].Value = producto.IDPRODUCTO;
                this.dgvVenta.ClearSelection();
                this.dgvVenta.Rows[fila].Cells[3].Selected = true;

                this.txtBoxBuscarCodigo.Text = "";
            }
            else
            {
                MessageBox.Show("¡ERROR DE CODIGO, COPIE EL CODIGO CORRECTO ARRIBA!");
            }
        }

        private void txtBoxBuscarCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            string c = this.txtBoxBuscarCodigo.Text;
            if (e.KeyCode == Keys.Enter && c != "")
            {
                e.SuppressKeyPress = true;
                btnBuscarProducto_Click(sender, e);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA REGISTRAR ESTA COMPRA?", "PEDIDO NUEVO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                instanciarDistribuidora();
                instanciarCompra();
                if (instanciarLote())
                {
                    MessageBox.Show("NO SE INSERTO NINGUNA TARJETA");
                    return;
                }
                actualizarCaja();
                bd.insertarCompra(compra, distribuidora, listaLote);
                cargarMontos();
                cargarDatos();
                limpiar();
                MessageBox.Show("¡COMPRA REGISTRADA EXITOSAMENTE!");
            }
        }

        private void actualizarCaja()
        {
            decimal costoTotal = bd.convertirDecimal(this.txtBoxCostoTotal.Text);
            decimal efectivo = bd.convertirDecimal(this.txtBoxEfectivo.Text);
            decimal deuda = (efectivo - costoTotal) * (-1);
            bd.compraTarjeta(costoTotal, efectivo, deuda);
        }

        private bool instanciarLote()
        {
            Lote lote;
            foreach (DataGridViewRow row in this.dgvVenta.Rows)
            {
                decimal costo = bd.convertirDecimal(row.Cells[5].Value.ToString());
                if (costo > 0)
                {
                    int cantidad = bd.convertirEntero(row.Cells[3].Value.ToString());
                    decimal precioUnitario = bd.convertirDecimal(row.Cells[4].Value.ToString());
                    int id = bd.convertirEntero(row.Cells[6].Value.ToString());
                    lote = new Lote(-1, id, compra.IDCOMPRA, "2050/01/01", cantidad, precioUnitario, costo, 1, cantidad);
                    this.listaLote.Add(lote);
                }
            }
            return this.listaLote.Count <= 0 ? true : false;
        }

        private void instanciarCompra()
        {
            string descripcion = "COMPRA DE TARJETAS";
            decimal costoTotal = bd.convertirDecimal(this.txtBoxCostoTotal.Text);

            compra = new Compra(-1, "", costoTotal, descripcion, -1, usuario.IDUSUARIO, 0, costoTotal);
        }

        private void instanciarDistribuidora()
        {
            string nombre = "RUTERO";
            string direccion = "";
            string telefono = "";
            string categoria = "TARJETAS";
            distribuidora = new Distribuidora(-1, nombre, direccion, telefono, categoria);
        }

        private void limpiar()
        {
            this.compra = null;
            this.listaLote = new List<Lote>();
            this.dgvVenta.Rows.Clear();
            this.txtBoxCostoTotal.Text = "0";
            this.txtBoxBuscarCodigo.Focus();
            this.txtBoxEfectivo.Text = "";
            this.lblTipo.Text = "AMORTIZAR";
            this.txtBoxTipo.Text = "0";
        }

        private void dgvVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
                return;
            //obtienes la fila seleccionada
            DataGridViewRow row = dgvVenta.Rows[e.RowIndex];

            if (row.Cells[3].Value == null || row.Cells[4].Value == null)
                return;

            int cantidad = bd.convertirEntero(row.Cells[3].Value.ToString());
            decimal precioUnitario = bd.convertirDecimal(row.Cells[4].Value.ToString());
            decimal costo = cantidad * precioUnitario;
            row.Cells[5].Value = costo.ToString();
            calcularCostoTotal();
        }

        private void calcularCostoTotal()
        {
            decimal costoTotal = 0;
            for (int i = 0; i < this.dgvVenta.RowCount; i++)
            {
                DataGridViewRow row = dgvVenta.Rows[i];
                decimal costo = bd.convertirDecimal(row.Cells[5].Value.ToString());
                costoTotal += costo;
            }
            this.txtBoxCostoTotal.Text = costoTotal.ToString();
        }

        private void dgvTarjetas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
                return;

            DataGridViewRow row = dgvTarjetas.Rows[e.RowIndex];

            int cantidad = bd.convertirEntero(row.Cells[0].Value.ToString());
            string codigo = row.Cells[1].Value.ToString();
            string nombre = row.Cells[2].Value.ToString();
            string marca = row.Cells[3].Value.ToString();
            string contenido = row.Cells[4].Value.ToString();
            decimal precioCompra = bd.convertirDecimal(row.Cells[5].Value.ToString());
            decimal precioVenta = bd.convertirDecimal(row.Cells[6].Value.ToString());
            string ubicacion = row.Cells[7].Value.ToString();
            string descripcion = row.Cells[8].Value.ToString();
            int id = bd.convertirEntero(row.Cells[9].Value.ToString());
            string categoria = row.Cells[10].Value.ToString();

            producto = new Producto(id, codigo, nombre, categoria, "", precioCompra, precioVenta, descripcion, ubicacion, cantidad, marca, contenido);

            FormProducto frm = new FormProducto(producto);
            string respuesta = frm.ShowDialog().ToString();
            if (respuesta == "OK")
            {
                MessageBox.Show("¡PRODUCTO EDITADO EXITOSAMENTE!");
                cargarDatos();
            }
        }

        private void dgvTarjetas_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dgvVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
                try
                {
                    int fila = dgvVenta.CurrentRow.Index;
                    dgvVenta.Rows.RemoveAt(dgvVenta.CurrentRow.Index);
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btnListarVentas_Click(object sender, EventArgs e)
        {
            FormMisCompras frm = new FormMisCompras(usuario, false);
            frm.ShowDialog();
        }

        private void txtBoxEfectivo_TextChanged(object sender, EventArgs e)
        {
            decimal efectivo = bd.convertirDecimal(this.txtBoxEfectivo.Text);
            decimal costoT = bd.convertirDecimal(this.txtBoxCostoTotal.Text);
            decimal tipo = efectivo - costoT;

            if (tipo <= 0)
                this.lblTipo.Text = "DEUDA";
            else
                this.lblTipo.Text = "AMORTIZAR";

            this.txtBoxTipo.Text = Math.Abs(tipo).ToString();
        }

        private void txtBoxCostoTotal_TextChanged(object sender, EventArgs e)
        {
            txtBoxEfectivo_TextChanged(sender, e);
        }
    }
}
