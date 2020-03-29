using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TALLER.Modelo;

namespace TALLER.ClasesVista
{
    public class ListaLote : Lote
    {
        private string codigo;
        private string producto;
        private string contenido;

        public string CODIGO
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string PRODUCTO
        {
            get { return producto; }
            set { producto = value; }
        }

        public string CONTENIDO
        {
            get { return contenido; }
            set { contenido = value; }
        }

        public ListaLote(int idLote, int idProducto, int idCompra, string expiracion, int cantidad, decimal precioCompra, decimal costo, int cantidadPaquete, int cantidadEnPaquete, string codigo, string producto, string contenido)
            : base(idLote,idProducto,idCompra,expiracion,cantidad,precioCompra,costo,cantidadPaquete,cantidadEnPaquete)
        {
            this.CODIGO = codigo;
            this.PRODUCTO = producto;
            this.CONTENIDO = contenido;
        }
    }
}
