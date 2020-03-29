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
using TALLER.ClasesVista;
using TALLER.CapaVista;

namespace TALLER.Vista
{
    public partial class FormArqueo : Form
    {
        private BaseDatos bd = new BaseDatos();
        private Usuario usuario;
        private List<ListaLoteVenta> listaLoteVentas = new List<ListaLoteVenta>();
        DataTable tabla = new DataTable();
        private decimal ventasEfectivo;
        private decimal ventasCredito;
        private decimal ventasTarjeta;
        private decimal inversiones;
        private decimal cambios;
        private decimal compras;
        private decimal egresos;
        private decimal totalEfectivo;
        public FormArqueo(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }

        private void FormArqueos_Load(object sender, EventArgs e)
        {
            armarTabla();
            cargarDatos();
            cargarVentas();
            cargarInversiones();
            cargarCambios();
            cargarCompras();
            cargarEgresos();
            calcularTotales();

        }

        private void calcularTotales()
        {
            decimal totalIngresos = ventasEfectivo + ventasCredito + ventasTarjeta + inversiones + cambios;
            decimal totalEgresos = compras + egresos;
            decimal montoTotal = totalIngresos - totalEgresos;
            totalEfectivo = ventasEfectivo + inversiones + cambios - totalEgresos;

            this.txtBoxIngresos.Text = totalIngresos.ToString();
            this.txtBoxEgresos.Text = totalEgresos.ToString();
            this.txtBoxMontoTotal.Text = montoTotal.ToString();
            this.txtBoxEfectivoTotal.Text = totalEfectivo.ToString();
        }

        private void cargarEgresos()
        {
            egresos = bd.obtenerGastosHoy(usuario.IDUSUARIO);
            this.txtBoxGastos.Text = egresos.ToString();
        }

        private void cargarCompras()
        {
            compras = bd.obtenerComprasHoy(usuario.IDUSUARIO);
            this.txtBoxCompras.Text = compras.ToString();
        }

        private void cargarCambios()
        {
            cambios = bd.obtenerCambios(usuario.IDUSUARIO);
            this.txtBoxCambios.Text = cambios.ToString();
        }

        private void cargarVentas()
        {
            ventasEfectivo = bd.obtenerMontoVentasHoy(usuario.IDUSUARIO,"EFECTIVO");
            ventasCredito = bd.obtenerMontoVentasHoy(usuario.IDUSUARIO, "CREDITO");
            ventasTarjeta = bd.obtenerMontoVentasHoy(usuario.IDUSUARIO, "TARJETA");

            this.txtBoxEfectivo.Text = ventasEfectivo.ToString();
            this.txtBoxCredito.Text = ventasCredito.ToString();
            this.txtBoxTarjeta.Text = ventasTarjeta.ToString();
        }

        private void cargarInversiones()
        {
            inversiones = bd.obtenerInversionesHoy(usuario.IDUSUARIO);
            this.txtBoxInversiones.Text = inversiones.ToString();
        }

        private void armarTabla()
        {
            tabla.Columns.Add("IDVENTA");//0
            tabla.Columns.Add("CODIGO");//1
            tabla.Columns.Add("PRODUCTO");//2
            tabla.Columns.Add("CONTENIDO");//3
            tabla.Columns.Add("CANTIDAD");//4
            tabla.Columns.Add("PRECIO VENTA");//5
            tabla.Columns.Add("COSTO");//6
        }

        private void cargarDatos()
        {
            listaLoteVentas = bd.arqueoVentasHoy(usuario.IDUSUARIO);
            tabla.Rows.Clear();
            foreach (ListaLoteVenta lv in listaLoteVentas)
                tabla.Rows.Add(new Object[] { lv.IDVENTA, lv.CODIGO, lv.NOMBRE + " " + lv.MARCA, lv.CONTENIDO, lv.CANTIDAD, lv.PRECIOVENTA, lv.COSTO });

            this.dgvVentas.DataSource = tabla;
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA CERRAR LA CAJA?\nLa caja cerrara y dejara\nde cambios el efectivo total", "CERRAR CAJA", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bd.cerrarCaja(usuario.IDUSUARIO, totalEfectivo);
                MessageBox.Show("¡CAJA CERRADA EXITOSAMENTE!");
                Login frm = new Login();
                frm.Show();
                Application.Exit();
            }
        }
    }
}
