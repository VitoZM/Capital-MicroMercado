using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER.Modelo
{
    public class Inversion
    {
        private int idInversion;
        private string ciInversor;
        private string nombreInversor;
        private int idUsuario;
        private decimal monto;
        private string fecha;
        private string descripcion;

        public int IDINVERSION
        {
            get { return idInversion; }
            set { idInversion = value; }
        }

        public string CIINVERSOR
        {
            get { return ciInversor; }
            set { ciInversor = value; }
        }

        public string NOMBREINVERSOR
        {
            get { return nombreInversor; }
            set { nombreInversor = value; }
        }

        public int IDUSUARIO
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public decimal MONTO
        {
            get { return monto; }
            set { monto = value; }
        }

        public string FECHA
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string DESCRIPCION
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Inversion(int idInversion, string ciInversor, string nombreInversor, int idUsuario, decimal monto, string fecha, string descripcion)
        {
            this.IDINVERSION = idInversion;
            this.CIINVERSOR = ciInversor;
            this.NOMBREINVERSOR = nombreInversor;
            this.IDUSUARIO = idUsuario;
            this.MONTO = monto;
            this.FECHA = fecha;
            this.DESCRIPCION = descripcion;
        }
    }
}
