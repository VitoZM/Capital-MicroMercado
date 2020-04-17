using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TALLER.Modelo;

namespace TALLER.ClasesVista
{
    public class ListaCompra : Compra
    {
        private string nombreUsuario;
        private string nombreDistribuidora;
        public string NOMBREUSUARIO
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string NOMBREDISTRIBUIDORA
        {
            get {
                return nombreDistribuidora;
            }
            set { nombreDistribuidora = value; }
        }

        public ListaCompra(int idCompra, string fecha, decimal costototal, string descripcion, int idDistribuidora, int idUsuario, decimal descuento, decimal costoFinal, string nombreUsuario, string nombreDistribuidora) : base(idCompra, fecha, costototal, descripcion, idDistribuidora, idUsuario, descuento, costoFinal)
        {
            this.NOMBREUSUARIO = nombreUsuario;
            this.NOMBREDISTRIBUIDORA = nombreDistribuidora;
        }
    }
}
