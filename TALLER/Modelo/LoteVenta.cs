using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER.Modelo
{
    public class LoteVenta
    {
        private int idVenta;
        private int idProducto;
        private int cantidad;
        private decimal precioVenta;
        private string estado;
        private decimal costo;

        public int IDVENTA
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        public int IDPRODUCTO
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public int CANTIDAD
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public decimal PRECIOVENTA
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        public string ESTADO
        {
            get { return estado; }
            set
            {
                if (value == "1")
                    estado = "VENDIDO";
                else
                    estado = "CANCELADO";
            }
        }

        public decimal COSTO
        {
            get { return costo; }
            set { costo = value; }
        }

        public LoteVenta(int idVenta, int idProducto, int cantidad, decimal precioVenta, string estado, decimal costo)
        {
            this.IDVENTA = idVenta;
            this.IDPRODUCTO = idProducto;
            this.CANTIDAD=cantidad;
            this.PRECIOVENTA = precioVenta;
            this.ESTADO = estado;
            this.COSTO = costo;
        }
    }
}
