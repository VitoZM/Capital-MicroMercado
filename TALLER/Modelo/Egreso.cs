using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER.Modelo
{
    public class Egreso
    {
        private int idEgreso;
        private int idUsuario;
        private string nombreUsuario;
        private string fecha;
        private string categoria;
        private decimal monto;
        private string descripcion;

        public int IDEGRESO
        {
            get { return idEgreso; }
            set { idEgreso = value; }
        }

        public int IDUSUARIO
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string NOMBREUSUARIO
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string FECHA
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string CATEGORIA
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public decimal MONTO
        {
            get { return monto; }
            set { monto = value; }
        }

        public string DESCRIPCION
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Egreso(int idEgreso, int idUsuario, string nombreUsuario, string fecha, string categoria, decimal monto, string descripcion)
        {
            this.IDEGRESO = idEgreso;
            this.IDUSUARIO = idUsuario;
            this.NOMBREUSUARIO = nombreUsuario;
            this.FECHA = fecha;
            this.CATEGORIA = categoria;
            this.MONTO = monto;
            this.DESCRIPCION = descripcion;
        }
    }
}
