using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TALLER.Controlador;
using TALLER.Modelo;
using TALLER.Vista;

namespace TALLER.CapaVista
{
    public partial class FormPedido : Form
    {
        private BaseDatos bd = new BaseDatos();
        private Compra compra;
        private Distribuidora distribuidora;
        private List<Lote> listaLote = new List<Lote>();
        private DateTimePicker dateTimePicker1;
        private Usuario usuario;

        public FormPedido(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }


        private void FormPedido_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            cargarPlaceHolders();
            this.txtBoxUbicacion.Text = "LADO IZQUIERDO";
            this.txtBoxCategoria.Text = "ACEITE Y PASTA";
            this.txtBoxCategoria2.Text = "ACEITE Y PASTA";
        }

        private void cargarPlaceHolders()
        {
            txtBoxNombre.GotFocus += new EventHandler(this.txtBoxNombreGotFocus);
            txtBoxNombre.LostFocus += new EventHandler(this.txtBoxNombreLostFocus);

            txtBoxMarca.GotFocus += new EventHandler(this.txtBoxMarcaGotFocus);
            txtBoxMarca.LostFocus += new EventHandler(this.txtBoxMarcaLostFocus);

            txtBoxPresentacion.GotFocus += new EventHandler(this.txtBoxPresentacionGotFocus);
            txtBoxPresentacion.LostFocus += new EventHandler(this.txtBoxPresentacionLostFocus);
        }


        private void txtBoxPresentacionLostFocus(object sender, EventArgs e)
        {
            if (txtBoxPresentacion.Text == "")
            {
                txtBoxPresentacion.Text = "SEGUNDA MARCA, SABOR, LATA, ETC.";
                txtBoxPresentacion.ForeColor = Color.Gray;
            }
        }

        private void txtBoxPresentacionGotFocus(object sender, EventArgs e)
        {
            if (txtBoxPresentacion.Text == "SEGUNDA MARCA, SABOR, LATA, ETC.")
            {
                txtBoxPresentacion.Text = "";
                txtBoxPresentacion.ForeColor = Color.Black;
            }
        }

        private void txtBoxMarcaLostFocus(object sender, EventArgs e)
        {
            if (txtBoxMarca.Text == "")
            {
                txtBoxMarca.Text = "NESTLE, KRIS, ARCOR, ETC.";
                txtBoxMarca.ForeColor = Color.Gray;
            }
        }

        private void txtBoxMarcaGotFocus(object sender, EventArgs e)
        {
            if (txtBoxMarca.Text == "NESTLE, KRIS, ARCOR, ETC.")
            {
                txtBoxMarca.Text = "";
                txtBoxMarca.ForeColor = Color.Black;
            }
        }

        private void txtBoxNombreLostFocus(object sender, EventArgs e)
        {
            if(txtBoxNombre.Text == "")
            {
                txtBoxNombre.Text = "LECHE, CHOCOLATE, SHAMPOO, ETC.";
                txtBoxNombre.ForeColor = Color.Gray;
            }
        }

        private void txtBoxNombreGotFocus(object sender, EventArgs e)
        {
            if (txtBoxNombre.Text == "LECHE, CHOCOLATE, SHAMPOO, ETC.")
            {
                txtBoxNombre.Text = "";
                txtBoxNombre.ForeColor = Color.Black;
            }
        }

        private void cargarCategorias()
        {
            string fichero = Directory.GetCurrentDirectory() + "\\categorias.txt";
            string archivo = String.Empty;
            if (File.Exists(fichero))
            {
                archivo = File.ReadAllText(fichero);
                string[] lineas = archivo.Split('\n');
                foreach (string linea in lineas)
                {
                    this.txtBoxCategoria.Items.Add(linea);
                    this.txtBoxCategoria2.Items.Add(linea);
                }
            }
            txtBoxCategoria2.Items.Add("TODO");
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            string codigo = this.txtBoxCodigo.Text;
            string nombre = this.txtBoxNombre.Text.ToUpper();
            string marca = this.txtBoxMarca.Text.ToUpper();
            if(txtBoxPresentacion.Text != "SEGUNDA MARCA, SABOR, LATA, ETC.")
                marca += " " + this.txtBoxPresentacion.Text;
            string contenido = this.txtBoxContenido.Text;
            string unidad = this.txtBoxUnidad.Text;
            string categoria = this.txtBoxCategoria.Text;
            decimal precioVenta = bd.convertirDecimal(this.txtBoxPrecioVenta.Text);
            string descripcion = this.txtBoxDescripcion.Text;
            string ubicacion = this.txtBoxUbicacion.Text;

            if(nombre == "" || nombre == "LECHE, CHOCOLATE, SHAMPOO, ETC." || marca == "" || marca == "NESTLE, KRIS, ARCOR, ETC." || contenido == "" || unidad == "" || categoria == "" || txtBoxPrecioVenta.Text == "" || ubicacion == "")
            {
                MessageBox.Show("¡DEBE LLENAR TODOS LOS ESPACIOS OBLIGATORIOS!");
                return;
            }

            Producto producto = new Producto(-1, codigo, nombre, categoria, "", -1, precioVenta, descripcion, ubicacion, -1, marca, contenido + " " + unidad);
            bd.insertarProducto(producto);
            MessageBox.Show("¡PRODUCTO INGRESADO EXITOSAMENTE!");

            limpiarProducto();
        }

        private void limpiarProducto()
        {
            this.txtBoxCodigo.Text = "";
            this.txtBoxNombre.Text = "";
            this.txtBoxMarca.Text = "";
            this.txtBoxContenido.Text = "";
            this.txtBoxPrecioVenta.Text = "";
            this.txtBoxDescripcion.Text = "";

            this.txtBoxCodigo.Focus();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string codigo = this.txtBoxBuscarCodigo.Text;
            ingresarProducto(codigo);
        }

        private void ingresarProducto(string codigo)
        {
            Producto producto = bd.getProducto(codigo);
            if (producto != null)
            {
                this.dgvVenta.Rows.Add();
                int fila = this.dgvVenta.Rows.Count - 1;

                this.dgvVenta.Rows[fila].Cells[0].Value = producto.CODIGO;
                this.dgvVenta.Rows[fila].Cells[1].Value = producto.NOMBRE + " " + producto.MARCA;
                this.dgvVenta.Rows[fila].Cells[2].Value = producto.CONTENIDO;
                this.dgvVenta.Rows[fila].Cells[8].Value = DateTime.Today.ToString("dd/MM/yyyy");
                this.dgvVenta.Rows[fila].Cells[9].Value = producto.IDPRODUCTO;
                this.dgvVenta.ClearSelection();
                this.dgvVenta.Rows[fila].Cells[5].Selected = true;

                this.txtBoxBuscarCodigo.Text = "";
                this.txtBoxCantidad.Text = "";
                this.txtBoxCantidad.Focus();
            }
            else
            {
                this.txtBoxCodigo.Text = codigo;
                MessageBox.Show("¡PRODUCTO INEXISTENTE AÑADALO EN LA PARTE SUPERIOR!");
                this.txtBoxCodigo.Focus();
            }
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            FormAlmacenamiento frm = new FormAlmacenamiento();
            frm.ban = true;
            string respuesta = frm.ShowDialog().ToString();
            if (respuesta == "OK")
                ingresarProducto(frm.producto.CODIGO);
            else
                this.txtBoxCodigo.Focus();
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

        private void dgvVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
                return;
            //obtienes la fila seleccionada
            DataGridViewRow row = dgvVenta.Rows[e.RowIndex];

            for (int i=5; i<=7; i++)
                if (row.Cells[i].Value == null)
                    return;

            int cantidadPaquete = bd.convertirEntero(row.Cells[5].Value.ToString());
            int cantidadPorPaquete = bd.convertirEntero(row.Cells[6].Value.ToString());
            decimal costo = bd.convertirDecimal(row.Cells[7].Value.ToString());
            int cantidadUnitaria = cantidadPaquete * cantidadPorPaquete;
            decimal precioUnitario = Math.Truncate(costo / cantidadUnitaria * 100) / 100;
            row.Cells[3].Value = cantidadUnitaria;
            row.Cells[4].Value = precioUnitario;
            calcularCostoTotal();
        }

        private void calcularCostoTotal()
        {
            decimal costoTotal = 0;
            for (int i = 0; i < this.dgvVenta.RowCount; i++)
            {
                DataGridViewRow row = dgvVenta.Rows[i];
                decimal costo = bd.convertirDecimal(row.Cells[7].Value.ToString());
                costoTotal += costo;
            }
            this.txtBoxCostoTotal.Text = costoTotal.ToString();
        }

        private void dgvVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calcularCostoTotal();
        }

        private void dgvVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.txtBoxBuscarCodigo.Focus();
            }
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

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (compraValida())
            {
                DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA REGISTRAR ESTA COMPRA?", "PEDIDO NUEVO", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    instanciarDistribuidora();
                    instanciarCompra();
                    instanciarLote();
                    bd.insertarCompra(compra, distribuidora, listaLote);
                    limpiar();
                    MessageBox.Show("¡COMPRA REGISTRADA EXITOSAMENTE!");
                }
            }
            else
                MessageBox.Show("¡COMPRA INVALIDA!");
        }

        private bool compraValida()
        {
            decimal costoTotal = bd.convertirDecimal(this.txtBoxCostoTotal.Text);
            if (costoTotal <= 0)
                return false;
            return true;
        }
        private void instanciarLote()
        {
            Lote lote;
            foreach (DataGridViewRow row in this.dgvVenta.Rows)
            {
                decimal costo = bd.convertirDecimal(row.Cells[7].Value.ToString());
                if (costo > 0)
                {
                    int cantidad = bd.convertirEntero(row.Cells[3].Value.ToString());
                    decimal precioUnitario = bd.convertirDecimal(row.Cells[4].Value.ToString());
                    int cantidadPaquete = bd.convertirEntero(row.Cells[5].Value.ToString());
                    int cantidadEnPaquete = bd.convertirEntero(row.Cells[6].Value.ToString());
                    string expiracion = row.Cells[8].Value.ToString();
                    int id = bd.convertirEntero(row.Cells[9].Value.ToString());
                    lote = new Lote(-1, id, compra.IDCOMPRA, expiracion, cantidad, precioUnitario, costo, cantidadPaquete, cantidadEnPaquete);
                    this.listaLote.Add(lote);
                }
            }
        }

        private void instanciarCompra()
        {
            string descripcion = this.txtBoxDescripcion2.Text;
            decimal costoTotal = bd.convertirDecimal(this.txtBoxCostoTotal.Text);

            compra = new Compra(-1, "", costoTotal, descripcion, -1, usuario.IDUSUARIO);
        }

        private void instanciarDistribuidora()
        {
            string nombre = this.txtBoxNombreDistribuidora.Text.ToUpper();
            if (nombre == "")
                nombre = "CONTRABANDO";
            string telefono = this.txtBoxTelefono.Text;
            string direccion = this.txtBoxDireccion.Text.ToUpper();
            string categoria = this.txtBoxCategoria2.Text;

            distribuidora = new Distribuidora(-1, nombre, direccion, telefono, categoria);
        }

        private void limpiar()
        {
            limpiarProducto();
            limpiarDistribuidora();
            limpiarCompra();
        }

        private void limpiarCompra()
        {
            this.distribuidora = null;
            this.compra = null;
            this.listaLote = new List<Lote>();
            this.dgvVenta.Rows.Clear();
            this.txtBoxCostoTotal.Text= "0";
            this.txtBoxDescripcion2.Text = "";
            this.txtBoxCantidad.Text = string.Empty;
            this.txtBoxBuscarCodigo.Focus();
        }

        private void limpiarDistribuidora()
        {
            this.txtBoxNombreDistribuidora.Text = "";
            this.txtBoxDireccion.Text = "";
            this.txtBoxTelefono.Text = "";
        }

        private void dateTimePicker1_OnTextChange(object sender, EventArgs e)
        {
            //Asignamos a la celda el valor de la feha seleccionada
            dgvVenta.CurrentCell.Value = dateTimePicker1.Text.ToString();
        }

        void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            //Volvemos a colocar en invisible el control
            dateTimePicker1.Visible = false;
        }


        private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí debes controlar el índice de columna del campo que tienes como fecha
            // En tu caso sería 4 (Fecha Visita Compra)
            DataGridViewRow row = this.dgvVenta.CurrentRow;
            if (row == null)
                return;
            if (e.ColumnIndex == 8)
            {
                //Creamos el control por código
                dateTimePicker1 = new DateTimePicker();

                //Agregamos el control de fecha dentro del DataGridView 
                dgvVenta.Controls.Add(dateTimePicker1);

                // Hacemos que el control sea invisible (para que no moleste visualmente)
                dateTimePicker1.Visible = false;

                // Establecemos el formato (depende de tu localización en tu PC)
                dateTimePicker1.Format = DateTimePickerFormat.Short;  //Ej: 24/08/2016

                // Agregamos el evento para cuando seleccionemos una fecha
                dateTimePicker1.TextChanged += new EventHandler(dateTimePicker1_OnTextChange);

                // Lo hacemos visible
                dateTimePicker1.Visible = true;

                // Creamos un rectángulo que representa el área visible de la celda
                Rectangle rectangle1 = dgvVenta.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Establecemos el tamaño del control DateTimePicker (que sería el tamaño total de la celda)
                dateTimePicker1.Size = new Size(rectangle1.Width, rectangle1.Height);

                // Establecemos la ubicación del control
                dateTimePicker1.Location = new Point(rectangle1.X, rectangle1.Y);

                // Generamos el evento de cierre del control fecha
                dateTimePicker1.CloseUp += new EventHandler(dateTimePicker1_CloseUp);
            }
        }

        private void txtBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            int fila = this.dgvVenta.Rows.Count - 1;
            if (fila > -1)
                this.dgvVenta.Rows[fila].Cells[5].Value = this.txtBoxCantidad.Text;
        }

        private void txtBoxCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.txtBoxBuscarCodigo.Focus();
            }
        }

        private void btnBuscarDistribuidora_Click(object sender, EventArgs e)
        {
            FormDistribuidoras frm = new FormDistribuidoras();
            frm.ban = true;
            string respuesta = frm.ShowDialog().ToString();
            if (respuesta == "OK")
            {
                distribuidora = frm.distribuidora;
                llenarDistribuidora();
            }
        }

        private void llenarDistribuidora()
        {
            this.txtBoxNombreDistribuidora.Text = distribuidora.NOMBRE;
            this.txtBoxTelefono.Text = distribuidora.TELEFONO;
            this.txtBoxCategoria2.Text = distribuidora.CATEGORIA;
            this.txtBoxDireccion.Text = distribuidora.DIRECCION;
        }

        private void txtBoxCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string codigo = this.txtBoxCodigo.Text;
                Producto producto = bd.getProducto(codigo);
                if (producto == null)
                    this.txtBoxNombre.Focus();
                else
                {
                    MessageBox.Show("EL PRODUCTO YA FUE REGISTRADO");
                    ingresarProducto(codigo);
                }
            }
        }

        private void txtBoxPrecioVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnGuardarProducto_Click(sender, e);
            }
        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxNombre.Text == "")
            {
                //txtBoxNombre.Text = "LECHE, CHOCOLATE, SHAMPOO, ETC.";
                txtBoxNombre.ForeColor = Color.LightGray;
            }
            else
                txtBoxNombre.ForeColor = Color.Black;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FormMisCompras frm = new FormMisCompras(usuario);
            frm.ShowDialog();
        }
    }
}
