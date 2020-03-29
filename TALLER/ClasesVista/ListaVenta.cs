using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TALLER.Modelo;

namespace TALLER.ClasesVista
{
    public class ListaVenta : Venta
    {
        private string nombreUsuario;
        private string nombreCliente;
        private string ciCliente;
        private string descripcion;

        public string NOMBREUSUARIO
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string NOMBRECLIENTE
        {
            get
            {
                return nombreCliente;
            }
            set { nombreCliente = value; }
        }

        public string CICLIENTE
        {
            get { return ciCliente; }
            set { ciCliente = value; }
        }

        public string DESCRIPCION
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public ListaVenta(int idVenta, int idUsuario, int idCliente, string fecha, decimal costototal, decimal efectivo, decimal cambio, string estado, string pago, string nombreUsuario, string nombreCliente, string ciCliente,string descripcion)
            :base(idVenta,idUsuario,idCliente,fecha,costototal,efectivo,cambio,estado,pago)
        {
            this.NOMBRECLIENTE = nombreCliente;
            this.NOMBREUSUARIO = nombreUsuario;
            this.CICLIENTE = ciCliente;
            this.DESCRIPCION = descripcion;
        }
    }
}
