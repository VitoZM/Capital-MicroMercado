using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TALLER.Modelo;

namespace TALLER.ClasesVista
{
    public class ListaLoteVenta : LoteVenta
    {
        private string codigo;
        private string nombre;
        private string marca;
        private string contenido;

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

        public ListaLoteVenta(int idVenta, int idProducto, int cantidad, decimal precioVenta, string estado, decimal costo, string codigo, string nombre, string marca, string contenido)
            : base(idVenta, idProducto, cantidad, precioVenta, estado, costo)
        {
            this.CODIGO = codigo;
            this.NOMBRE = nombre;
            this.MARCA = marca;
            this.CONTENIDO = contenido;
        }
    }
}
