namespace TALLER.Modelo
{
    public class Usuario
    {
        private int idUsuario;
        private string ciUsuario;
        private string nombres;
        private string apellidos;
        private string telefono;
        private string email;
        private string direccion;
        private string rol;
        private string estado;
        private string contrasena;
        private decimal sueldo;

        public int IDUSUARIO
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string CIUSUARIO
        {
            get { return ciUsuario; }
            set { ciUsuario = value; }
        }
        public string NOMBRES
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string APELLIDOS
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string TELEFONO
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string EMAIL
        {
            get { return email; }
            set { email = value; }

        }

        public string DIRECCION
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string ROL
        {
            get { return rol; }
            set {
                if (value == "0")
                    rol = "VENDEDOR";
                else
                    rol = "ADMINISTRADOR";
            }
        }

        public string ESTADO
        {
            get { return estado; }
            set {
                if (value == "0")
                    estado = "BAJA";
                else
                    estado = "ACTIVO";
            }
        }

        public string CONTRASENA
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public decimal SUELDO
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public Usuario(int idUsuario, string ciUsuario, string nombres, string apellidos, string telefonom, string email, string direccion, string rol, string estado, string contrasena, decimal sueldo)
        {
            this.IDUSUARIO = idUsuario;
            this.CIUSUARIO = ciUsuario;
            this.NOMBRES = nombres;
            this.APELLIDOS = apellidos;
            this.TELEFONO = telefono;
            this.EMAIL = email;
            this.DIRECCION = direccion;
            this.ROL = rol;
            this.ESTADO = estado;
            this.CONTRASENA = contrasena;
            this.SUELDO = sueldo;
        }
    }
}