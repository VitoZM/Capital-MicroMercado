using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TALLER.Controlador;
using TALLER.Modelo;
using TALLER.Vista;
using TALLER.ClasesVista;

namespace TALLER.CapaVista
{
    public partial class FormVentas : Form
    {
        Usuario usuario;
        Cliente cliente = null;
        Venta venta = null;
        List<LoteVenta> listaLoteVenta = new List<LoteVenta>();
        List<ListaLoteVenta> listaProductos = new List<ListaLoteVenta>();
        BaseDatos bd = new BaseDatos();
        bool banVenta = false;
        ListaVenta listaVenta;
        Conversion conversion = new Conversion();

        public FormVentas()
        {
            InitializeComponent();
        }
        public FormVentas(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }
       

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string ci = this.txtBoxCi.Text;
            cliente = bd.getCliente(ci);
            if (cliente != null)
            {
                this.txtBoxNombres.Text = cliente.NOMBRES;
                this.txtBoxTelefono.Text = cliente.TELEFONO;
                soloLectura(true);
                this.txtBoxCodigo.Focus();
            }
            else
                MessageBox.Show("CLIENTE INEXISTENTE");
        }

        private void soloLectura(bool v)
        {
            this.txtBoxNombres.ReadOnly = v;
            this.txtBoxTelefono.ReadOnly = v;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            this.txtBoxPago.Text = "EFECTIVO";
            this.txtBoxCodigo.Focus();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            banVenta = true;
            if(ventaValida())
                cambiarModoBotones(!banVenta);
            else
                MessageBox.Show("¡VENTA INCOMPLETA O VACIA!");
        }

        private bool ventaValida()
        {
            string pago = this.txtBoxPago.Text;
            string ci = this.txtBoxCi.Text;
            decimal costoTotal = bd.convertirDecimal(this.txtBoxCosto.Text);
            decimal efectivo = bd.convertirDecimal(this.txtBoxCosto.Text);
            decimal cambio = bd.convertirDecimal(this.txtBoxCambio.Text);

            if (costoTotal <= 0 || cambio < 0 || efectivo <= 0)
                return false;

            if (pago == "CREDITO" && ci.Length < 4)
                return false;

            return true;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string codigo = this.txtBoxCodigo.Text;
            if (codigo != "")
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
                this.dgvVenta.Rows[fila].Cells[3].Value = producto.PRECIOVENTA;
                this.dgvVenta.Rows[fila].Cells[4].Value = 1;
                this.dgvVenta.Rows[fila].Cells[5].Value = producto.PRECIOVENTA;
                this.dgvVenta.Rows[fila].Cells[6].Value = producto.IDPRODUCTO;
                this.dgvVenta.ClearSelection();
                this.dgvVenta.Rows[fila].Cells[4].Selected = true;

                this.txtBoxCodigo.Text = "";
                this.txtBoxCantidad.Text = "";
                this.txtBoxCantidad.Focus();
            }
            else
                MessageBox.Show("PRODUCTO INEXISTENTE");
        }

        private void txtBoxCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            string c = this.txtBoxCodigo.Text;
            if (e.KeyCode == Keys.Enter && c != "")
            {
                e.SuppressKeyPress = true;
                btnBuscarProducto_Click(sender, e);
            }
            if(e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
                this.txtBoxEfectivo.Focus();
            }
            if(e.KeyCode == Keys.F1)
            {
                e.SuppressKeyPress = true;
                btnAlmacen_Click(sender, e);
            }
        }

        private void txtBoxCi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnBuscarCliente_Click(sender, e);
            }
        }

        private void dgvVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
                return;
            //obtienes la fila seleccionada
            DataGridViewRow row = dgvVenta.Rows[e.RowIndex];

            for (int i = 3; i <= 5; i++)
                if (row.Cells[i].Value == null)
                    return;

            decimal precio = bd.convertirDecimal(row.Cells[3].Value.ToString());
            int cantidad = bd.convertirEntero(row.Cells[4].Value.ToString());
            row.Cells[5].Value = cantidad * precio;
            calcularCostoTotal();
        }

        private void calcularCostoTotal()
        {
            decimal costoTotal = 0;
            for(int i=0; i<this.dgvVenta.RowCount; i++)
            {
                DataGridViewRow row = dgvVenta.Rows[i];
                decimal costo = bd.convertirDecimal(row.Cells[5].Value.ToString());
                costoTotal += costo;
            }
            this.txtBoxCosto.Text = costoTotal.ToString();
            if (this.txtBoxPago.Text == "CREDITO" || this.txtBoxPago.Text == "TARJETA")
                this.txtBoxEfectivo.Text = this.txtBoxCosto.Text;
        }

        private void dgvVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calcularCostoTotal();
        }

        private void txtBoxEfectivo_TextChanged(object sender, EventArgs e)
        {
            calcularCambio();
        }

        private void calcularCambio()
        {
            decimal costoTotal = bd.convertirDecimal(this.txtBoxCosto.Text);
            decimal efectivo = bd.convertirDecimal(this.txtBoxEfectivo.Text);
            this.txtBoxCambio.Text = (efectivo - costoTotal).ToString();
        }

        private void txtBoxCosto_TextChanged(object sender, EventArgs e)
        {
            calcularCambio();
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

        private void txtBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            int fila = this.dgvVenta.Rows.Count - 1;
            if (fila > -1)
            {
                if (this.txtBoxCantidad.Text == "")
                    this.dgvVenta.Rows[fila].Cells[4].Value = 1;
                else
                    this.dgvVenta.Rows[fila].Cells[4].Value = this.txtBoxCantidad.Text;
            }
        }

        private void txtBoxCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                unirFilas();
                this.txtBoxCodigo.Focus();
            }
        }

        private void unirFilas()
        {
            int fila = this.dgvVenta.Rows.Count - 1;
            if (fila > -1)
            {
                string codigo = this.dgvVenta.Rows[fila].Cells[0].Value.ToString();
                for (int i = 0; i < fila; i++)
                {
                    string codigoFila = this.dgvVenta.Rows[i].Cells[0].Value.ToString();
                    if (codigo == codigoFila)
                    {
                        int cantidad = bd.convertirEntero(this.dgvVenta.Rows[fila].Cells[4].Value.ToString());
                        int cantidadFila = bd.convertirEntero(this.dgvVenta.Rows[i].Cells[4].Value.ToString());
                        dgvVenta.Rows.RemoveAt(fila);
                        this.dgvVenta.Rows[i].Cells[4].Value = (cantidad + cantidadFila).ToString();
                    }
                }
            }
        }

        private void dgvVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                unirFilas();
                this.txtBoxCodigo.Focus();
            }
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
                this.txtBoxEfectivo.Focus();
            }
            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
                try
                {
                    int fila = dgvVenta.CurrentRow.Index;
                    dgvVenta.Rows.RemoveAt(dgvVenta.CurrentRow.Index);
                }
                catch(Exception ex)
                {
                    
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ventaValida())
            {
                cambiarModoBotones(banVenta);
                instanciarCliente();
                instanciarLoteVenta();
                instanciarVenta();
                bd.insertarVenta(venta, cliente, listaLoteVenta);
                MessageBox.Show("¡VENTA REGISTRADA EXITOSAMENTE!");
                limpiar();
            }
        }

        private void instanciarLoteVenta()
        {
            LoteVenta lote;
            foreach (DataGridViewRow row in this.dgvVenta.Rows)
            {
                decimal costo = bd.convertirDecimal(row.Cells[5].Value.ToString());
                if (costo > 0)
                {
                    decimal precio = bd.convertirDecimal(row.Cells[3].Value.ToString());
                    int cantidad = bd.convertirEntero(row.Cells[4].Value.ToString());
                    int id = bd.convertirEntero(row.Cells[6].Value.ToString());
                    string estado = "1";
                    if (row.Cells[1].Value.ToString().Split(' ')[0] == "TARJETA")
                        estado = "0";
                    lote = new LoteVenta(-1, id, cantidad, precio, estado, costo);

                    this.listaLoteVenta.Add(lote);
                }
            }
        }

        private void instanciarVenta()
        {
            int idUsuario = usuario.IDUSUARIO;
            decimal costoTotal = bd.convertirDecimal(this.txtBoxCosto.Text);
            decimal efectivo = bd.convertirDecimal(this.txtBoxEfectivo.Text);
            decimal cambio = bd.convertirDecimal(this.txtBoxCambio.Text);
            string pago = this.txtBoxPago.Text;
            decimal costoTarjeta = 0;

            foreach (LoteVenta l in listaLoteVenta)
                if (l.ESTADO == "CANCELADO")
                    costoTarjeta += l.COSTO;

            venta = new Venta(-1, idUsuario, -1, "", costoTotal, efectivo, cambio, "1", pago, costoTarjeta);
        }

        private void instanciarCliente()
        {
            string ci = this.txtBoxCi.Text;
            if (ci == "")
                ci = "0";
            string nombres = this.txtBoxNombres.Text.ToUpper();
            string telefono = this.txtBoxTelefono.Text;

            cliente = new Cliente(-1, ci, nombres, telefono);
        }

        private void limpiar()
        {
            this.cliente = null;
            this.venta = null;
            this.listaLoteVenta = new List<LoteVenta>();
            this.txtBoxCi.Text = string.Empty;
            this.txtBoxNombres.Text = string.Empty;
            this.txtBoxTelefono.Text = string.Empty;
            this.txtBoxCodigo.Text = string.Empty;
            this.dgvVenta.Rows.Clear();
            this.txtBoxEfectivo.Text = string.Empty;
            this.txtBoxCambio.Text = string.Empty;
            this.txtBoxCosto.Text = string.Empty;
            this.txtBoxPago.Text = "EFECTIVO";
            this.txtBoxCantidad.Text = string.Empty;
            this.txtBoxCodigo.Focus();
            banVenta = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cambiarModoBotones(banVenta);
            banVenta = false;
        }

        private void cambiarModoBotones(bool modo)
        {
            this.btnProcesar.Visible = modo;
            this.btnRegistrar.Visible = !modo;
            this.btnCancelar.Visible = !modo;
            this.btnImprimir.Visible = !modo;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtBoxCi_TextChanged(object sender, EventArgs e)
        {
            soloLectura(false);
        }

        private void btnListarVentas_Click(object sender, EventArgs e)
        {
            FormMisVentas frm = new FormMisVentas(usuario);
            frm.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FormClientes frm = new FormClientes();
            frm.ban = true;
            string respuesta = frm.ShowDialog().ToString();
            if (respuesta == "OK")
            {
                this.txtBoxCi.Text = frm.cliente.CICLIENTE;
                btnBuscarCliente_Click(sender, e);
            }
            else
                this.txtBoxCodigo.Focus();
        }

        private void txtBoxPago_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.txtBoxPago.Text == "CREDITO" || this.txtBoxPago.Text == "TARJETA")
            {
                this.txtBoxEfectivo.ReadOnly = true;
                this.txtBoxEfectivo.Text = this.txtBoxCosto.Text;
            }
            else
                this.txtBoxEfectivo.ReadOnly = false;
        }

        private void txtBoxEfectivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
                this.txtBoxCodigo.Focus();
            }
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (banVenta)
                    btnRegistrar_Click(sender, e);
                else
                    btnProcesar_Click(sender, e);
            }
        }

        private void dgvVenta_Click(object sender, EventArgs e)
        {
            this.txtBoxCantidad.Focus();
        }

        private void txtBoxPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (banVenta)
                    btnRegistrar_Click(sender, e);
                else
                    btnProcesar_Click(sender, e);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (ventaValida())
            {
                cambiarModoBotones(banVenta);
                instanciarCliente();
                instanciarLoteVenta();
                instanciarVenta();
                bd.insertarVenta(venta, cliente, listaLoteVenta);

                listaVenta = bd.obtenerUltimaVenta();
                imprimirVenta();

                MessageBox.Show("¡VENTA REGISTRADA EXITOSAMENTE!");
                limpiar();
            }
        }

        private void imprimirVenta()
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int yRectangulo;
                yRectangulo = calcularY(e);
                /*e.Graphics.DrawImage(pictureBox1.Image, 40, 20, 110, 110);
                e.Graphics.DrawImage(pictureBox2.Image, 40, 119, 110, 40);*/
                //                                   x   y   width height
                Rectangle rectangulo = new Rectangle(0, 225, 900, yRectangulo);

                e.Graphics.DrawRectangle(Pens.Gray, rectangulo);
                //                                                                                               x   y
                e.Graphics.DrawString("NOTA DE VENTA", new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, 375, 40);
                e.Graphics.DrawString("ID VENTA: " + listaVenta.IDVENTA, new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, 590, 40);

                e.Graphics.DrawString("MICROMERCADO CAPITAL", new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, 40, 80);
                e.Graphics.DrawString("COBIJA # 57", new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, 40, 105);

                e.Graphics.DrawString("FECHA DE VENTA: " + this.listaVenta.FECHA, new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 40, 130);

                e.Graphics.DrawString("SEÑOR(ES):", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 40, 160);
                e.Graphics.DrawString(listaVenta.NOMBRECLIENTE, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 150, 160);
                e.Graphics.DrawString("TELF.:", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 400, 160);
                e.Graphics.DrawString("-", new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 450, 160);
                e.Graphics.DrawString("NIT/CI:", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 580, 160);
                e.Graphics.DrawString(listaVenta.CICLIENTE, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 685, 160);
                e.Graphics.DrawString("DIRECCION:", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 40, 180);
                e.Graphics.DrawString("-", new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 150, 180);
                e.Graphics.DrawString("VENDEDOR:", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 580, 180);
                e.Graphics.DrawString(listaVenta.NOMBREUSUARIO, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 685, 180);
                e.Graphics.DrawString("CANTIDAD", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 50, 210);
                e.Graphics.DrawString("CONCEPTO", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 240, 210);
                e.Graphics.DrawString("PRECIO", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 580, 210);
                e.Graphics.DrawString("TOTAL", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 690, 210);
                int nuevaY = 232 + yRectangulo;
                e.Graphics.DrawString("SON:", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 50, nuevaY);
                e.Graphics.DrawString(conversion.enletras((listaVenta.COSTOTARJETA + listaVenta.COSTOTOTAL).ToString()), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 100, nuevaY);
                e.Graphics.DrawString("TOTAL VENTA:", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 555, nuevaY);
                e.Graphics.DrawString((listaVenta.COSTOTOTAL + listaVenta.COSTOTARJETA).ToString(), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 700, nuevaY);
                /*e.Graphics.DrawString("TARJETAS DE REGARCA:", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 555, nuevaY + 20);
                e.Graphics.DrawString(listaVenta.COSTOTARJETA.ToString(), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 700, nuevaY + 20);
                e.Graphics.DrawString("COSTO FINAL:", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 555, nuevaY + 40);
                e.Graphics.DrawString((listaVenta.COSTOTARJETA + listaVenta.COSTOTOTAL).ToString(), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 700, nuevaY + 40);*/
                e.Graphics.DrawString("EFECTIVO:", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 555, nuevaY + 20);
                e.Graphics.DrawString(listaVenta.EFECTIVO.ToString(), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 700, nuevaY + 20);
                e.Graphics.DrawString("VUELTO:", new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, 555, nuevaY + 40);
                e.Graphics.DrawString(listaVenta.CAMBIO.ToString(), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 700, nuevaY + 40);                

                e.Graphics.DrawString(listaVenta.NOMBRECLIENTE, new Font("Verdana", 7, FontStyle.Bold), Brushes.Black, 50, nuevaY + 82);
                e.Graphics.DrawString(listaVenta.NOMBREUSUARIO, new Font("Verdana", 7, FontStyle.Bold), Brushes.Black, 220, nuevaY + 82);

                e.Graphics.DrawString("EL MONTO A CANCELAR SE ENCUENTRA EXPRESADO EN BOLIVIANOS.", new Font("Verdana", 7, FontStyle.Regular), Brushes.Black, 40, nuevaY + 120);

                rectangulo = new Rectangle(40, nuevaY + 80, 130, 1);
                e.Graphics.DrawRectangle(Pens.Gray, rectangulo);
                rectangulo = new Rectangle(195, nuevaY + 80, 130, 1);
                e.Graphics.DrawRectangle(Pens.Gray, rectangulo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private int calcularY(System.Drawing.Printing.PrintPageEventArgs e)
        {
            listaProductos = bd.listarLoteVenta(listaVenta.IDVENTA);
            int y = 0;
            foreach(ListaLoteVenta p in listaProductos)
            {
                y += 20;
                e.Graphics.DrawString(p.CANTIDAD.ToString(), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 60, 207 + y);
                e.Graphics.DrawString(p.NOMBRE + " " + p.MARCA + " " + p.CONTENIDO, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 130, 207 + y);
                e.Graphics.DrawString(p.PRECIOVENTA.ToString(), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 590, 207 + y);
                e.Graphics.DrawString(p.COSTO.ToString(), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 700, 207 + y);
            }

            return y;
        }

        private void txtBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCodigo_Enter(object sender, EventArgs e)
        {
            this.txtBoxCodigo.BackColor = Color.FromArgb(243,195,151);
        }

        private void txtBoxCodigo_Leave(object sender, EventArgs e)
        {
            this.txtBoxCodigo.BackColor = Color.White;
        }

        private void txtBoxEfectivo_Enter(object sender, EventArgs e)
        {
            this.txtBoxEfectivo.BackColor = Color.FromArgb(243, 195, 151);
        }

        private void txtBoxEfectivo_Leave(object sender, EventArgs e)
        {
            this.txtBoxEfectivo.BackColor = Color.White;
        }

        private void txtBoxCi_Enter(object sender, EventArgs e)
        {
            this.txtBoxCi.BackColor = Color.FromArgb(243, 195, 151);
        }

        private void txtBoxCi_Leave(object sender, EventArgs e)
        {
            this.txtBoxCi.BackColor = Color.White;
        }

        private void txtBoxNombres_Enter(object sender, EventArgs e)
        {
            this.txtBoxNombres.BackColor = Color.FromArgb(243, 195, 151);
        }

        private void txtBoxNombres_Leave(object sender, EventArgs e)
        {
            this.txtBoxNombres.BackColor = Color.White;
        }

        private void txtBoxTelefono_Leave(object sender, EventArgs e)
        {
            this.txtBoxTelefono.BackColor = Color.White;
        }

        private void txtBoxTelefono_Enter(object sender, EventArgs e)
        {
            this.txtBoxTelefono.BackColor = Color.FromArgb(243, 195, 151);
        }
    }
}
