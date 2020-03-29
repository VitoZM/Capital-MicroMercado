using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER.Modelo
{
    public class Lote
    {
        private int idLote;
        private int idProducto;
        private int idCompra;
        private string expiracion;
        private int cantidad;
        private decimal precioCompra;
        private decimal costo;
        private int cantidadPaquete;
        private int cantidadEnPaquete;

        public int IDLOTE
        {
            get { return idLote; }
            set { idLote = value; }
        }

        public int IDCOMPRA
        {
            get { return idCompra; }
            set { idCompra = value; }
        }

        public int IDPRODUCTO
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string EXPIRACION
        {
            get { return expiracion; }
            set { expiracion = value; }
        }

        public int CANTIDAD
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public decimal PRECIOCOMPRA
        {
            get { return precioCompra; }
            set { precioCompra = value; }
        }

        public decimal COSTO
        {
            get { return costo; }
            set { costo = value; }
        }

        public int CANTIDADPAQUETE
        {
            get { return cantidadPaquete; }
            set { cantidadPaquete = value; }
        }

        public int CANTIDADENPAQUETE
        {
            get { return cantidadEnPaquete; }
            set { cantidadEnPaquete = value; }
        }

        public Lote(int idLote, int idProducto, int idCompra, string expiracion, int cantidad, decimal precioCompra, decimal costo, int cantidadPaquete, int cantidadEnPaquete)
        {
            this.IDLOTE = idLote;
            this.IDCOMPRA = idCompra;
            this.IDPRODUCTO = idProducto;
            this.CANTIDAD = cantidad;
            this.PRECIOCOMPRA = precioCompra;
            this.EXPIRACION = expiracion;
            this.COSTO = costo;
            this.CANTIDADPAQUETE = cantidadPaquete;
            this.CANTIDADENPAQUETE = cantidadEnPaquete;
        }
    }
}
