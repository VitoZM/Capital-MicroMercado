using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER.Modelo
{
    public class Compra
    {
        private int idCompra;
        private string fecha;
        private decimal costoTotal;
        private string descripcion;
        private int idDistribuidora;
        private int idUsuario;

        public int IDCOMPRA
        {
            get { return idCompra; }
            set { idCompra = value; }
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

        public string DESCRIPCION
        {
            get { return descripcion; }
            set
            {
                descripcion = value;
            }
        }

        public int IDDISTRIBUIDORA
        {
            get { return idDistribuidora; }
            set { idDistribuidora = value; }
        }

        public int IDUSUARIO
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public Compra(int idCompra, string fecha, decimal costototal, string descripcion, int idDistribuidora, int idUsuario)
        {
            this.IDCOMPRA = idCompra;
            this.FECHA = fecha;
            this.COSTOTOTAL = costototal;
            this.DESCRIPCION = descripcion;
            this.IDDISTRIBUIDORA = idDistribuidora;
            this.IDUSUARIO = idUsuario;
        }
    }
}
