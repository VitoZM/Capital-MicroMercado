using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TALLER.Controlador;
using TALLER.Modelo;

namespace TALLER.Vista
{
    public partial class FormProducto : Form
    {
        BaseDatos bd = new BaseDatos();
        Producto producto;
        public FormProducto(Producto p)
        {
            InitializeComponent();
            producto = p;
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            string codigo = this.txtBoxCodigo.Text;
            string nombre = this.txtBoxNombre.Text.ToUpper();
            string marca = this.txtBoxMarca.Text.ToUpper();
            if(this.txtBoxPresentacion.Text != "SEGUNDA MARCA, SABOR, LATA, ETC.")
                marca += " " + this.txtBoxPresentacion.Text.ToUpper();            
            string contenido = this.txtBoxContenido.Text;
            string unidad = this.txtBoxUnidad.Text.ToUpper();
            string categoria = this.txtBoxCategoria.Text;
            decimal precioVenta = bd.convertirDecimal(this.txtBoxPrecioVenta.Text);
            string descripcion = this.txtBoxDescripcion.Text;
            string ubicacion = this.txtBoxUbicacion.Text;

            if (nombre == "" || nombre == "LECHE, CHOCOLATE, SHAMPOO, ETC." || marca == "" || marca == "NESTLE, KRIS, ARCOR, ETC." || contenido == "" || unidad == "" || categoria == "" || txtBoxPrecioVenta.Text == "" || ubicacion == "")
            {
                MessageBox.Show("¡DEBE LLENAR TODOS LOS ESPACIOS OBLIGATORIOS!");
                return;
            }

            producto = new Producto(producto.IDPRODUCTO, codigo, nombre, categoria, "", 0, precioVenta, descripcion, ubicacion, -1, marca, contenido + " " + unidad);
            bd.editarProducto(producto);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            cargarPlaceHolders();
            cargarProducto();
        }

        private void cargarProducto()
        {
            this.txtBoxId.Text = producto.IDPRODUCTO.ToString();
            this.txtBoxCodigo.Text = producto.CODIGO;
            this.txtBoxNombre.Text = producto.NOMBRE;
            if (producto.NOMBRE == "TARJETA")
                txtBoxNombre.ReadOnly = true;
            string[] marca = producto.MARCA.Split(' ');
            this.txtBoxMarca.Text = marca[0];
            for (int i = 1; i < marca.Count(); i++)
            {
                if (i == 1)
                {
                    this.txtBoxPresentacion.ForeColor = Color.Black;
                    this.txtBoxPresentacion.Text = "";
                    this.txtBoxPresentacion.Text += marca[i];
                }
                else
                    this.txtBoxPresentacion.Text += " " + marca[i];
            }
            this.txtBoxContenido.Text = producto.CONTENIDO.Split(' ')[0];
            this.txtBoxUnidad.Text = producto.CONTENIDO.Split(' ')[1];
            this.txtBoxPrecioVenta.Text = producto.PRECIOVENTA.ToString();
            this.txtBoxUbicacion.Text = producto.UBICACION;
            this.txtBoxCategoria.Text = producto.CATEGORIA;
            this.txtBoxDescripcion.Text = producto.DESCRIPCION;
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
                    this.txtBoxCategoria.Items.Add(linea);
            }

        }

        private void cargarPlaceHolders()
        {
            txtBoxNombre.GotFocus += new EventHandler(this.txtBoxNombreGotFocus);
            txtBoxNombre.LostFocus += new EventHandler(this.txtBoxNombreLostFocus);

            txtBoxMarca.GotFocus += new EventHandler(this.txtBoxMarcaGotFocus);
            txtBoxMarca.LostFocus += new EventHandler(this.txtBoxMarcaLostFocus);

            txtBoxPresentacion.GotFocus += new EventHandler(this.txtBoxPresentacionGotFocus);
            txtBoxPresentacion.LostFocus += new EventHandler(this.txtBoxPresentacionLostFocus);

            txtBoxContenido.GotFocus += new EventHandler(this.txtBoxContenidoGotFocus);
            txtBoxContenido.LostFocus += new EventHandler(this.txtBoxContenidoLostFocus);
        }

        private void txtBoxContenidoLostFocus(object sender, EventArgs e)
        {
            if (txtBoxContenido.Text == "")
            {
                txtBoxContenido.Text = "10 ML., 1 KG., 1 UN., ETC.";
                txtBoxContenido.ForeColor = Color.Gray;
            }
        }

        private void txtBoxContenidoGotFocus(object sender, EventArgs e)
        {
            if (txtBoxContenido.Text == "10 ML., 1 KG., 1 UN., ETC.")
            {
                txtBoxContenido.Text = "";
                txtBoxContenido.ForeColor = Color.Black;
            }
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
            if (txtBoxNombre.Text == "")
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

        private void btnListarCompras_Click(object sender, EventArgs e)
        {
            FormProductoComprado frm = new FormProductoComprado(producto.IDPRODUCTO);
            frm.Show();
        }
    }
}
