using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER.Modelo
{
    public class Venta
    {
        private int idVenta;
        private int idUsuario;
        private int idCliente;
        private string fecha;
        private decimal costoTotal;
        private decimal efectivo;
        private decimal cambio;
        private string estado;
        private string pago;
        private decimal costoTarjeta;

        public int IDVENTA
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        public int IDUSUARIO
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public int IDCLIENTE
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string FECHA
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public decimal COSTOTOTAL
        {
            get { return costoTotal; }
            set { costoTotal = value; }
        }

        public decimal EFECTIVO
        {
            get { return efectivo; }
            set { efectivo = value; }
        }

        public decimal CAMBIO
        {
            get { return cambio; }
            set { cambio = value; }
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

        public string PAGO
        {
            get { return pago; }
            set
            {
                pago = value;
            }
        }

        public decimal COSTOTARJETA
        {
            get { return costoTarjeta; }
            set { costoTarjeta = value; }
        }

        public Venta(int idVenta,int idUsuario,int idCliente,string fecha,decimal costototal,decimal efectivo,decimal cambio,string estado,string pago, decimal costoTarjeta)
        {
            this.IDVENTA = idVenta;
            this.IDUSUARIO = idUsuario;
            this.IDCLIENTE = idCliente;
            this.FECHA = fecha;
            this.COSTOTOTAL = costototal;
            this.EFECTIVO = efectivo;
            this.CAMBIO = cambio;
            this.ESTADO = estado;
            this.PAGO = pago;
            this.COSTOTARJETA = costoTarjeta;
        }
    }
}
