using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER.Modelo
{
    public class Distribuidora
    {
        private int idDistribuidora;
        private string nombre;
        private string direccion;
        private string telefono;
        private string categoria;

        public int IDDISTRIBUIDORA
        {
            get { return idDistribuidora; }
            set { idDistribuidora = value; }
        }

        public string NOMBRE
        {
            get { return nombre; }
            set{ nombre = value; }
        } 

        public string DIRECCION
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string TELEFONO
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string CATEGORIA
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public Distribuidora(int id, string nombre, string direccion, string telefono, string categoria)
        {
            this.IDDISTRIBUIDORA = id;
            this.NOMBRE = nombre;
            this.DIRECCION = direccion;
            this.TELEFONO = telefono;
            this.CATEGORIA = categoria;
        }
    }
}
