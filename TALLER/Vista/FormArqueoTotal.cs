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
    public partial class FormArqueoTotal : Form
    {
        private BaseDatos bd = new BaseDatos();
        private Usuario usuario1;
        private List<ListaLoteVenta> listaLoteVentas1 = new List<ListaLoteVenta>();
        DataTable tabla1 = new DataTable();
        private Usuario usuario2;
        private List<ListaLoteVenta> listaLoteVentas2 = new List<ListaLoteVenta>();
        DataTable tabla2 = new DataTable();
        private decimal totalVentas1;
        private decimal totalVentas2;
        private decimal totalEgresos1;
        private decimal totalEgresos2;

        public FormArqueoTotal()
        {
            InitializeComponent();
        }

        private void FormArqueoTotal_Load(object sender, EventArgs e)
        {
            armarTablas();
            cargarDatos1();
            cargarDatos2();
            cargarVentas1();
            cargarVentas2();
            cargarCompras1();
            cargarCompras2();
            calcularTotalEfectivo();
        }

        private void calcularTotalEfectivo()
        {
            decimal totalVentas = totalVentas1 + totalVentas2;
            decimal totalEgresos = totalEgresos1 + totalEgresos2;
            decimal cambios = bd.convertirDecimal(this.txtBoxCambios.Text);

            decimal totalEfectivo = totalVentas + cambios - totalEgresos;
            this.txtBoxTotalEfectivo.Text = totalEfectivo.ToString();
        }

        private void cargarCompras2()
        {
            totalEgresos1 = bd.obtenerComprasHoy(5);
            this.txtBoxEgresos1.Text = totalEgresos1.ToString();
        }

        private void cargarCompras1()
        {
            totalEgresos1 = bd.obtenerComprasHoy(4);
            this.txtBoxEgresos1.Text = totalEgresos1.ToString();
        }

        private void armarTablas()
        {
            tabla1.Columns.Add("IDVENTA");//0
            tabla1.Columns.Add("CODIGO");//1
            tabla1.Columns.Add("PRODUCTO");//2
            tabla1.Columns.Add("CONTENIDO");//3
            tabla1.Columns.Add("CANTIDAD");//4
            tabla1.Columns.Add("PRECIO VENTA");//5
            tabla1.Columns.Add("COSTO");//6

            tabla2 = tabla1;
        }
        private void cargarDatos1()
        {
            listaLoteVentas1 = bd.arqueoVentasHoy(4);
            tabla1.Rows.Clear();
            foreach (ListaLoteVenta lv in listaLoteVentas1)
                tabla1.Rows.Add(new Object[] { lv.IDVENTA, lv.CODIGO, lv.NOMBRE + " " + lv.MARCA, lv.CONTENIDO, lv.CANTIDAD, lv.PRECIOVENTA, lv.COSTO });

            this.dgvVentas1.DataSource = tabla1;
        }

        private void cargarDatos2()
        {
            listaLoteVentas2 = bd.arqueoVentasHoy(5);
            tabla2.Rows.Clear();
            foreach (ListaLoteVenta lv in listaLoteVentas2)
                tabla2.Rows.Add(new Object[] { lv.IDVENTA, lv.CODIGO, lv.NOMBRE + " " + lv.MARCA, lv.CONTENIDO, lv.CANTIDAD, lv.PRECIOVENTA, lv.COSTO });

            this.dgvVentas2.DataSource = tabla2;
        }

        private void cargarVentas1()
        {
            totalVentas1 = bd.obtenerMontoVentasHoy(4, "EFECTIVO");

            this.txtBoxVentas1.Text = totalVentas1.ToString();
        }
        private void cargarVentas2()
        {
            totalVentas2 = bd.obtenerMontoVentasHoy(5, "EFECTIVO");

            this.txtBoxVentas2.Text = totalVentas2.ToString();
        }

    }
}
