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
        private Usuario usuario;
        Conversion conversion = new Conversion();
        public FormLoteVenta(ListaVenta v,Usuario u)
        {
            InitializeComponent();
            listaVenta = v;
            usuario = u;
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
            if (listaVenta.PAGO == "CREDITO")
                this.btnPagar.Visible = true;
            this.txtBoxEfectivo.Text = this.listaVenta.EFECTIVO.ToString();
            this.txtBoxCambio.Text = this.listaVenta.CAMBIO.ToString();
            this.txtBoxPago.Text = this.listaVenta.PAGO.ToString();
            this.txtBoxCosto.Text = this.listaVenta.COSTOTOTAL.ToString();
            this.txtBoxDescripcion.Text = this.listaVenta.DESCRIPCION;
            this.txtBoxTarjeta.Text = this.listaVenta.COSTOTARJETA.ToString();
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

        private void btnPagar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA PAGAR LA VENTA?", "PAGAR VENTA", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bd.pagarCredito(listaVenta.IDVENTA,usuario.IDUSUARIO);
                MessageBox.Show("¡VENTA PAGADA EXITOSAMENTE!");
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
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
            int y = 0;
            foreach (ListaLoteVenta p in listaLoteVenta)
            {
                y += 20;
                e.Graphics.DrawString(p.CANTIDAD.ToString(), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 60, 207 + y);
                e.Graphics.DrawString(p.NOMBRE + " " + p.MARCA + " " + p.CONTENIDO, new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 130, 207 + y);
                e.Graphics.DrawString(p.PRECIOVENTA.ToString(), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 590, 207 + y);
                e.Graphics.DrawString(p.COSTO.ToString(), new Font("Verdana", 8, FontStyle.Regular), Brushes.Black, 700, 207 + y);
            }

            return y;
        }
    }
}
