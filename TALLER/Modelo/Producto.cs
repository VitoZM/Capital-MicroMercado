using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER.Modelo
{
    public class Producto
    {
        private int idProducto;
        private string codigo;
        private string nombre;
        private string categoria;
        private string presentacion;
        private decimal precioCompra;
        private decimal precioVenta;
        private string descripcion;
        private string ubicacion;
        private int cantidad;
        private string marca;
        private string contenido;

        public int IDPRODUCTO
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string CODIGO
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string CATEGORIA
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string PRESENTACION
        {
            get { return presentacion; }
            set { presentacion = value; }
        }

        public decimal PRECIOCOMPRA
        {
            get
            { return precioCompra; }
            set { precioCompra = value; }
        }

        public decimal PRECIOVENTA
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        public string DESCRIPCION
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string UBICACION
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }

        public int CANTIDAD
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string MARCA
        {
            get { return marca; }
            set { marca = value; }
        }

        public string CONTENIDO
        {
            get
            {
                return contenido;
            }
            set { contenido = value; }
        }

        public Producto(int id, string codigo, string nombre, string categoria, string presentacion, decimal precioCompra, decimal precioVenta, string descripcion,string ubicacion, int cantidad, string marca, string contenido)
        {
            this.IDPRODUCTO = id;
            this.CODIGO = codigo;
            this.NOMBRE = nombre;
            this.CATEGORIA = categoria;
            this.PRESENTACION = presentacion;
            this.PRECIOCOMPRA = precioCompra;
            this.PRECIOVENTA = precioVenta;
            this.DESCRIPCION = descripcion;
            this.UBICACION = ubicacion;
            this.CANTIDAD = cantidad;
            this.MARCA = marca;
            this.CONTENIDO = contenido;
        }
    }
}
