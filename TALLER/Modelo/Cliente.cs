using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER.Modelo
{
    public class Cliente
    {
        private int idCliente;
        private string ciCliente;
        private string nombres;
        private string telefono;

        public int IDCLIENTE
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string CICLIENTE
        {
            get { return ciCliente; }
            set { ciCliente = value; }
        }
        public string NOMBRES
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string TELEFONO
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public Cliente(int idCliente, string ciCliente, string nombres, string telefono)
        {
            this.IDCLIENTE = idCliente;
            this.CICLIENTE = ciCliente;
            this.NOMBRES = nombres;
            this.TELEFONO = telefono;
        }
    }
}
