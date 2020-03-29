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
using TALLER.Vista;
using TALLER.Modelo;

namespace TALLER.CapaVista
{
    public partial class FormMisVentas : Form
    {
        BaseDatos bd = new BaseDatos();
        DataTable tabla = new DataTable();
        List<ListaVenta> listaVentas = new List<ListaVenta>();
        Usuario usuario;

        public FormMisVentas(Usuario u)
        {
            InitializeComponent();
            usuario = u;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormReparacion_Load(object sender, EventArgs e)
        {
            cargarColumnas();
            cargarDatos();
            if (this.dgvIngresos.Rows.Count > 0)
            {
                llenarBotones();
                calcularTotal();
            }
        }

        private void calcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvIngresos.Rows)
                if (row.Cells[8].Value.ToString() == "VENDIDO")
                    total += bd.convertirDecimal(row.Cells[4].Value.ToString());
            this.txtBoxTotalVendido.Text = total.ToString();
        }

        private void cargarColumnas()
        {
            tabla.Columns.Add("ID");//0
            tabla.Columns.Add("VENDEDOR");//1
            tabla.Columns.Add("CLIENTE");//2
            tabla.Columns.Add("FECHA");//3
            tabla.Columns.Add("COSTO T");//4
            tabla.Columns.Add("PAGO");//5
            tabla.Columns.Add("EFECTIVO");//6
            tabla.Columns.Add("CAMBIO");//7
            tabla.Columns.Add("ESTADO");//8
            tabla.Columns.Add("MOSTRAR");//9
        }

        private void llenarBotones()
        {
            int width = dgvIngresos.Rows[0].Cells[9].Size.Width;
            int height = dgvIngresos.Rows[0].Cells[9].Size.Height;
            foreach (DataGridViewRow row in dgvIngresos.Rows)
            {
                Button button = new Button();
                dgvIngresos.Controls.Add(button);
                Rectangle rectangle = dgvIngresos.GetCellDisplayRectangle(9, row.Index, true);
                button.Size = new Size(rectangle.Width, rectangle.Height);
                button.Location = new Point(rectangle.X, rectangle.Y);
                button.Text = row.Cells[0].Value.ToString();
                button.ForeColor = System.Drawing.Color.Silver;

                void button_Click(object sender, EventArgs e)
                {
                    for (int i = 0; i < listaVentas.Count; i++)
                    {
                        ListaVenta lv = listaVentas[i];
                        if (lv.IDVENTA == bd.convertirEntero(button.Text))
                        {
                            FormLoteVenta frm = new FormLoteVenta(lv);
                            string respuesta = frm.ShowDialog().ToString();
                            if (respuesta == "OK")
                                MessageBox.Show("PRESIONE BOTON INGRESOS NUEVAMENTE PARA ACTUALIZAR");
                            break;
                        }
                    }
                }

                button.Click += new EventHandler(button_Click);
            }
        }

        private void cargarDatos()
        {
            listaVentas = bd.listarVentas(usuario);

            foreach (ListaVenta v in listaVentas)
                tabla.Rows.Add(new Object[] { v.IDVENTA, v.NOMBREUSUARIO, v.NOMBRECLIENTE, v.FECHA, v.COSTOTOTAL, v.PAGO, v.EFECTIVO, v.CAMBIO, v.ESTADO });

            this.dgvIngresos.Rows.Clear();
            this.dgvIngresos.DataSource = tabla;
        }

        private void dgvIngresos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
                return;

            DataGridViewRow row = dgvIngresos.Rows[e.RowIndex];
            int idVenta = bd.convertirEntero(row.Cells[0].Value.ToString());

            for (int i = 0; i < listaVentas.Count; i++)
            {
                ListaVenta lv = listaVentas[i];
                if (lv.IDVENTA == idVenta)
                {
                    FormLoteVenta frm = new FormLoteVenta(lv);
                    string respuesta = frm.ShowDialog().ToString();
                    if (respuesta == "OK")
                        MessageBox.Show("PRESIONE BOTON INGRESOS NUEVAMENTE PARA ACTUALIZAR");
                    break;
                }
            }
        }
    }
}
