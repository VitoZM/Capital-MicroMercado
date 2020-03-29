using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER.Modelo
{
    public class ControlP
    {
        private int idLote;
        private string codigo;
        private string producto;
        private int cantidad;
        private string expiracion;

        public int IDLOTE
        {
            get { return idLote; }
            set { idLote = value; }
        }

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

        public int CANTIDAD
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string EXPIRACION
        {
            get { return expiracion; }
            set { expiracion = DateTime.Parse(value).ToShortDateString(); }
        }

        public ControlP(int idLote, string codigo, string producto, int cantidad, string expiracion)
        {
            this.IDLOTE = idLote;
            this.CODIGO = codigo;
            this.PRODUCTO = producto;
            this.CANTIDAD = cantidad;
            this.EXPIRACION = expiracion;
        }
    }
}
