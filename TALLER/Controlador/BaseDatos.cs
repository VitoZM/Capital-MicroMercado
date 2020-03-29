using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TALLER.Modelo;
using TALLER.ClasesVista;
using TALLER.Properties;
using System.IO;
using System.Windows.Forms;

namespace TALLER.Controlador
{
    class BaseDatos
    {
        private SqlConnection conn;
        public BaseDatos()
        {
            string cadenaConexion = Settings.Default.CAPITALConnectionString;
            this.conn = new SqlConnection(cadenaConexion);
        }

        public void backUp()
        {
            this.conn.Open();
            string fichero = Directory.GetCurrentDirectory() + "\\backups\\CAPITALB " + DateTime.Now.ToString("dd_MM_yyyy") + " " + DateTime.Now.ToString("hh_mm_ss");
            string comando = @"BACKUP DATABASE [CAPITAL3] TO  DISK = N'" + fichero + ".bak' WITH NOFORMAT, NOINIT,  NAME = N'CAPITAL-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

            SqlCommand cmd = new SqlCommand(comando);
            cmd.Connection = conn;
            cmd.CommandText = comando;
            cmd.ExecuteNonQuery();

            this.conn.Close();
        }

        public decimal obtenerComprasHoy(int iDUSUARIO)
        {
            try
            {
                string comando = "OBTENERMONTOCOMPRASHOY " + iDUSUARIO;
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                decimal compras = convertirDecimal(cmd.ExecuteScalar().ToString());
                this.conn.Close();
                return compras;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
            return 0;
        }

        public void insertarInversion(Inversion inversion)
        {
            try
            {
                string comando = "EXEC INSERTARINVERSION '" + inversion.CIINVERSOR + "','" + inversion.NOMBREINVERSOR + "'," + inversion.IDUSUARIO + "," + sinComas(inversion.MONTO) + ",'" + inversion.DESCRIPCION + "'";
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                this.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
        }

        public void cerrarCaja(int idUsuario, decimal monto)
        {
            try
            {
                string comando = "EXEC CERRARCAJA " + idUsuario + "," + sinComas(monto);
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                this.conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
        }
        public decimal obtenerGastosHoy(int iDUSUARIO)
        {
            try
            {
                string comando = "OBTENERGASTOSHOY " + iDUSUARIO;
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                decimal gastos = convertirDecimal(cmd.ExecuteScalar().ToString());
                this.conn.Close();
                return gastos;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
            return 0;
        }

        public decimal obtenerCambios(int iDUSUARIO)
        {
            try
            {
                string comando = "OBTENERCAMBIOSHOY " + iDUSUARIO;
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                decimal cambios = convertirDecimal(cmd.ExecuteScalar().ToString());
                this.conn.Close();
                return cambios;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
            return 0;
        }

        public Usuario cajaAbierta()
        {
            try
            {
                string comando = "EXEC CAJAABIERTA";
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                SqlDataReader myReader = null;
                myReader = cmd.ExecuteReader();
                Usuario usuario = null;
                while (myReader.Read())
                {
                    int idUsuario = convertirEntero(myReader["IDUSUARIO"].ToString());
                    string nombres = myReader["NOMBRES"].ToString();
                    string apellidos = myReader["APELLIDOS"].ToString();

                    usuario = new Usuario(idUsuario, "", nombres, apellidos, "", "", "", "", "", "", 0);
                }
                this.conn.Close();
                return usuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
            return null;
        }

        public void abrirCaja(Usuario usuario, decimal cambios)
        {
            try
            {
                string comando = "EXEC ABRIRCAJA " + usuario.IDUSUARIO + "," + sinComas(cambios);
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                this.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
        }

        public decimal obtenerMontoVentasHoy(int iDUSUARIO, string tipo)
        {
            try
            {
                string comando = "EXEC OBTENERMONTOVENTASHOY " + iDUSUARIO + ",'" + tipo + "'";
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                decimal ventas = convertirDecimal(cmd.ExecuteScalar().ToString());
                this.conn.Close();
                return ventas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
            return 0;
        }

        internal decimal obtenerInversionesHoy(int iDUSUARIO)
        {
            try
            {
                string comando = "EXEC OBTENERINVERSIONESHOY " + iDUSUARIO;
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                decimal inversiones = convertirDecimal(cmd.ExecuteScalar().ToString());
                this.conn.Close();
                return inversiones;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
            return 0;
        }

        public List<Egreso> listarEgresos()
        {
            try
            {
                string comando = "SELECT * FROM LISTAREGRESOS";
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                SqlDataReader myReader = null;
                myReader = cmd.ExecuteReader();
                List<Egreso> lis = new List<Egreso>();
                while (myReader.Read())
                {
                    int idEgreso = convertirEntero(myReader["IDEGRESO"].ToString());
                    string nombreUsuario = myReader["USUARIO"].ToString();
                    string fecha = myReader["FECHA"].ToString();
                    string categoria = myReader["CATEGORIA"].ToString();
                    decimal monto = convertirDecimal(myReader["MONTO"].ToString());
                    string descripcion = myReader["DESCRIPCION"].ToString();

                    Egreso egr = new Egreso(idEgreso, 0, nombreUsuario, fecha, categoria, monto, descripcion);
                    lis.Add(egr);
                }
                this.conn.Close();
                return lis;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
            return null;
        }

        public List<ListaLoteVenta> arqueoVentasHoy(int iDUSUARIO)
        {
            try
            {
                string comando = "EXEC ARQUEOVENTASHOY " + iDUSUARIO;
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                SqlDataReader myReader = null;
                myReader = cmd.ExecuteReader();
                List<ListaLoteVenta> lis = new List<ListaLoteVenta>();
                while (myReader.Read())
                {
                    int idVenta = convertirEntero(myReader["idventa"].ToString());
                    string codigo = myReader["CODIGO"].ToString();
                    string producto = myReader["PRODUCTO"].ToString();
                    string contenido = myReader["CONTENIDO"].ToString();
                    decimal precioVenta = convertirDecimal(myReader["PRECIOVENTA"].ToString());
                    int cantidad = convertirEntero(myReader["CANTIDAD"].ToString());
                    decimal costo = convertirDecimal(myReader["COSTO"].ToString());

                    ListaLoteVenta lote = new ListaLoteVenta(idVenta, 0, cantidad, precioVenta, "", costo, codigo, producto, "", contenido);
                    lis.Add(lote);
                }
                this.conn.Close();
                return lis;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
            return null;
        }

        public List<Egreso> listarEgresos(int idUsuario)
        {
            try
            {
                string comando = "EXEC LISTARMISEGRESOS " + idUsuario;
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                SqlDataReader myReader = null;
                myReader = cmd.ExecuteReader();
                List<Egreso> lis = new List<Egreso>();
                while (myReader.Read())
                {
                    int idEgreso = convertirEntero(myReader["IDEGRESO"].ToString());
                    string nombreUsuario = myReader["USUARIO"].ToString();
                    string fecha = myReader["FECHA"].ToString();
                    string categoria = myReader["CATEGORIA"].ToString();
                    decimal monto = convertirDecimal(myReader["MONTO"].ToString());
                    string descripcion = myReader["DESCRIPCION"].ToString();

                    Egreso egr = new Egreso(idEgreso, 0, nombreUsuario, fecha, categoria, monto, descripcion);
                    lis.Add(egr);
                }
                this.conn.Close();
                return lis;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
            return null;
        }

        public void insertarEgreso(Egreso egreso)
        {
            try
            {
                string comando = "EXEC INSERTAREGRESO " + egreso.IDUSUARIO + ",'" + egreso.CATEGORIA + "'," + sinComas(egreso.MONTO) + ",'" + egreso.DESCRIPCION + "'";
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                this.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
        }

        public void editarCliente(Cliente cliente)
        {
            try
            {
                string comando = "EXEC INSERTARCLIENTE " + cliente.IDCLIENTE + ",'" + cliente.CICLIENTE + "','" + cliente.NOMBRES + "','" + cliente.TELEFONO + "'";
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                this.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
        }

        public List<ListaLote> listarLote(int iDCOMPRA)
        {
            try
            {
                string comando;
                comando = "EXEC LISTARLOTECOMPRA " + iDCOMPRA;
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                SqlDataReader myReader = null;
                myReader = cmd.ExecuteReader();
                List<ListaLote> lis = new List<ListaLote>();
                while (myReader.Read())
                {
                    int idCompra = convertirEntero(myReader["IDCOMPRA"].ToString());
                    int idLote = convertirEntero(myReader["IDLOTE"].ToString());
                    string codigo = myReader["CODIGO"].ToString();
                    string producto = myReader["PRODUCTO"].ToString();
                    string contenido = myReader["CONTENIDO"].ToString();
                    decimal precioCompra = convertirDecimal(myReader["PRECIOCOMPRA"].ToString());
                    int cantidad = convertirEntero(myReader["CANTIDAD"].ToString());
                    decimal costo = convertirDecimal(myReader["COSTO"].ToString());
                    int cantidadPaquete = convertirEntero(myReader["CANTIDADPAQUETE"].ToString());
                    int cantidadEnPaquete = convertirEntero(myReader["CANTIDADENPAQUETE"].ToString());
                    string expiracion = myReader["EXPIRACION"].ToString();

                    ListaLote ll = new ListaLote(idLote, 0, idCompra, expiracion, cantidad, precioCompra, costo, cantidadPaquete, cantidadEnPaquete, codigo, producto, contenido);
                    lis.Add(ll);
                }
                this.conn.Close();
                return lis;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
            return null;
        }

        public List<Cliente> listarClientes()
        {
            try
            {
                string comando = "SELECT * FROM LISTARCLIENTES";
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                SqlDataReader myReader = null;
                myReader = cmd.ExecuteReader();
                List<Cliente> lis = new List<Cliente>();
                while (myReader.Read())
                {
                    int idCliente = convertirEntero(myReader["IdCliente"].ToString());
                    string ci = myReader["CICliente"].ToString();
                    string nombres = myReader["Nombres"].ToString();
                    string telefono = myReader["Telefono"].ToString();

                    Cliente cli = new Cliente(idCliente, ci, nombres, telefono);
                    lis.Add(cli);
                }
                this.conn.Close();
                return lis;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
            return null;
        }

        public List<ListaCompra> listarCompras(Usuario usuario)
        {
            try
            {
                string comando;
                comando = "SELECT * FROM LISTARCOMPRASHOY WHERE IDUSUARIO = " + usuario.IDUSUARIO;
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                SqlDataReader myReader = null;
                myReader = cmd.ExecuteReader();
                List<ListaCompra> lis = new List<ListaCompra>();
                while (myReader.Read())
                {
                    int id = convertirEntero(myReader["IDCOMPRA"].ToString());
                    string nombreUsuario = myReader["USUARIO"].ToString();
                    string nombreDistribuidora = myReader["DISTRIBUIDORA"].ToString();
                    string fecha = myReader["fecha"].ToString();
                    decimal costoTotal = convertirDecimal(myReader["costototal"].ToString());
                    string descripcion = myReader["DESCRIPCION"].ToString();

                    ListaCompra lc = new ListaCompra(id, fecha, costoTotal, descripcion, 0, 0, nombreUsuario, nombreDistribuidora);
                    lis.Add(lc);
                }
                this.conn.Close();
                return lis;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
            return null;
        }

        public void insertarDistribuidora(Distribuidora distribuidora)
        {
            try
            {
                string comando = "INSERTARDISTRIBUIDORA '" + distribuidora.NOMBRE + "','" + distribuidora.DIRECCION + "','" + distribuidora.TELEFONO + "','" + distribuidora.CATEGORIA + "'";
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                this.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
        }

        public void editarDistribuidora(Distribuidora distribuidora)
        {
            try
            {
                string comando = "EDITARDISTRIBUIDORA " + distribuidora.IDDISTRIBUIDORA + ",'" + distribuidora.NOMBRE + "','" + distribuidora.DIRECCION + "','" + distribuidora.TELEFONO + "','" + distribuidora.CATEGORIA + "'";
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                this.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
        }

        public void ojala()
        {
            string comando;
            comando = "SELECT * FROM LISTARPRODUCTOS";
            SqlCommand cmd = new SqlCommand();
            this.conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = comando;
            SqlDataReader myReader = null;
            myReader = cmd.ExecuteReader();
            List<Producto> lis = new List<Producto>();
            while (myReader.Read())
            {
                int id = int.Parse(myReader["IdProducto"].ToString());
                string nombre = myReader["Nombre"].ToString();

                Producto pro = new Producto(id, "", nombre, "", "", 0, 0, "", "", 0, "", "");
                lis.Add(pro);
            }

            this.conn.Close();
            this.conn.Open();

            foreach (Producto p in lis)
            {
                string[] nombreCompleto = p.NOMBRE.Split(' ');
                string nombre = nombreCompleto[0];
                string marca = nombreCompleto[1];
                for (int i = 2; i < nombreCompleto.Count(); i++)
                    marca += " " + nombreCompleto[i];
                comando = "EXEC SEPARAR " + p.IDPRODUCTO + ",'" + nombre + "','" + marca + "'";
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
            }

            this.conn.Close();
        }
        public decimal convertirDecimal(string texto)
        {
            try
            {
                if (texto == "")
                    return 0;
                decimal convertido;
                string aux = "";
                foreach (char letra in texto)
                    if (letra == '.')
                        aux += ",";
                    else
                        aux += letra;

                convertido = decimal.Parse(aux);
                return convertido;
            }
            catch(Exception ex)
            {

            }
            return 0;
        }

        public void cancelarVenta(int idVenta,string descripcion)
        {
            try
            {
                string comando = "EXEC DARBAJAVENTA " + idVenta + ",'" + descripcion + "'";
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                SqlDataReader myReader = cmd.ExecuteReader();
                List<LoteVenta> lis = new List<LoteVenta>();
                while (myReader.Read())
                {
                    int idProducto = convertirEntero(myReader["idProducto"].ToString());
                    int cantidad = convertirEntero(myReader["Cantidad"].ToString());

                    LoteVenta lo = new LoteVenta(idVenta, idProducto, cantidad, 0, "0", 0);
                    lis.Add(lo);
                }

                this.conn.Close();
                this.conn.Open();

                foreach (LoteVenta lo in lis)
                {
                    string comando2 = "EXEC DARBAJALOTEVENTA " + idVenta + "," + lo.IDPRODUCTO + "," + lo.CANTIDAD;
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandText = comando2;
                    cmd2.ExecuteNonQuery();
                }

                this.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
        }

        public int convertirEntero(string texto)
        {
            try
            {
                return texto == "" ? 0 : int.Parse(texto);
            }
            catch(Exception ex)
            {

            }
            return 0;
        }

        public string sinComas(decimal p)
        {
            string[] aux = p.ToString().Split(',');
            return aux.Count() > 1 ? aux[0] + "." + aux[1] : aux[0];
        }

        public Cliente getCliente(string ci)
        {
            try
            {
                string comando;
                comando = "EXEC GETCLIENTE '" + ci + "'";
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                SqlDataReader myReader = null;
                myReader = cmd.ExecuteReader();
                Cliente cli = null;
                while (myReader.Read())
                {
                    int id = int.Parse(myReader["IdCliente"].ToString());
                    string nombres = myReader["Nombres"].ToString();
                    string telefono = myReader["Telefono"].ToString();

                    cli = new Cliente(id, ci, nombres, telefono);
                }
                this.conn.Close();
                return cli;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
            return null;
        }

        public Producto getProducto(string codigo)
        {
            string comando;
            comando = "EXEC GETPRODUCTO '" + codigo + "'";
            SqlCommand cmd = new SqlCommand();
            this.conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = comando;
            SqlDataReader myReader = null;
            myReader = cmd.ExecuteReader();
            Producto pro = null;
            while (myReader.Read())
            {
                int id = int.Parse(myReader["IdProducto"].ToString());
                string nombre = myReader["Nombre"].ToString();
                string marca = myReader["MARCA"].ToString();
                string contenido = myReader["CONTENIDO"].ToString();
                string categoria = myReader["Categoria"].ToString();
                string presentacion = "";
                decimal precioCompra = convertirDecimal(myReader["PrecioCompra"].ToString());
                decimal precioVenta = convertirDecimal(myReader["PrecioVenta"].ToString());
                string descripcion = myReader["Descripcion"].ToString();
                string ubicacion = myReader["Ubicacion"].ToString();
                int cantidad = int.Parse(myReader["cantidad"].ToString());

                pro = new Producto(id, codigo, nombre, categoria, presentacion, precioCompra, precioVenta, descripcion, ubicacion, cantidad, marca, contenido);
            }
            this.conn.Close();
            return pro;
        }

        public Usuario loginSystem(string ci, string contrasena)
        {
            string comando;
            comando = "EXEC LOGINSYSTEM '" + ci + "','" + contrasena + "'";
            SqlCommand cmd = new SqlCommand();
            this.conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = comando;
            SqlDataReader myReader = null;
            myReader = cmd.ExecuteReader();
            Usuario usu = null;
            while (myReader.Read())
            {
                int id = int.Parse(myReader["IdUsuario"].ToString());
                string nombres = myReader["Nombres"].ToString();
                string apellidos = myReader["Apellidos"].ToString();
                string rol = myReader["Rol"].ToString();

                usu = new Usuario(id, ci, nombres, apellidos, rol, "", "", rol, "1", contrasena, 0);
            }
            this.conn.Close();
            return usu;
        }

        public List<Usuario> listarUsuarios()
        {
            string comando = "SELECT * FROM LISTARUSUARIOS";
            SqlCommand cmd = new SqlCommand();
            this.conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = comando;
            SqlDataReader myReader = null;
            myReader = cmd.ExecuteReader();
            List<Usuario> lis = new List<Usuario>();
            while (myReader.Read())
            {
                int idUsuario = int.Parse(myReader["IdUsuario"].ToString());
                string ci = myReader["CIUsuario"].ToString();
                string nombres = myReader["Nombres"].ToString();
                string apellidos = myReader["apellidos"].ToString();
                string telefono = myReader["telefono"].ToString();
                string email = myReader["email"].ToString();
                string direccion = myReader["direccion"].ToString();
                string rol = myReader["rol"].ToString();
                string estado = myReader["estado"].ToString();
                string contrasena = myReader["contrasena"].ToString();
                decimal sueldo = convertirDecimal(myReader["sueldo"].ToString());

                Usuario usu = new Usuario(idUsuario, ci, nombres, apellidos, telefono, email, direccion, rol, estado, contrasena, sueldo);
                lis.Add(usu);
            }
            this.conn.Close();
            return lis;
        }

        public List<Producto> listarProductos()
        {
            string comando;
            comando = "SELECT * FROM LISTARPRODUCTOS";
            SqlCommand cmd = new SqlCommand();
            this.conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = comando;
            SqlDataReader myReader = null;
            myReader = cmd.ExecuteReader();
            List<Producto> lis = new List<Producto>();
            while (myReader.Read())
            {
                int id = convertirEntero(myReader["IdProducto"].ToString());
                string codigo = myReader["Codigo"].ToString();
                string nombre = myReader["Nombre"].ToString();
                string marca = myReader["MARCA"].ToString();
                string contenido = myReader["CONTENIDO"].ToString();
                string categoria = myReader["categoria"].ToString();
                string presentacion = "";
                decimal precioCompra = convertirDecimal(myReader["precioCompra"].ToString());
                decimal precioVenta = convertirDecimal(myReader["precioVenta"].ToString());
                string descripcion = myReader["descripcion"].ToString();
                string ubicacion = myReader["ubicacion"].ToString();
                int cantidad = convertirEntero(myReader["cantidad"].ToString());

                Producto pro = new Producto(id, codigo, nombre, categoria, presentacion, precioCompra, precioVenta, descripcion, ubicacion, cantidad, marca, contenido);
                lis.Add(pro);
            }
            this.conn.Close();
            return lis;
        }

        public void insertarVenta(Venta venta, Cliente cliente, List<LoteVenta> lista)
        {
            try
            {
                string comando = "EXEC INSERTARVENTA '" + venta.IDUSUARIO + "','" + cliente.CICLIENTE + "','" + cliente.NOMBRES + "','" + cliente.TELEFONO + "'," + sinComas(venta.COSTOTOTAL) + "," + sinComas(venta.EFECTIVO) + "," + sinComas(venta.CAMBIO) + ",'" + venta.PAGO + "'";
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                cmd.ExecuteScalar();

                comando = "EXEC GETULTIMAVENTA";
                cmd.CommandText = comando;
                int idVenta = convertirEntero(cmd.ExecuteScalar().ToString());

                foreach (LoteVenta l in lista)
                {
                    comando = "EXEC INSERTARLOTEVENTA " + idVenta + "," + l.IDPRODUCTO + "," + l.CANTIDAD + "," + sinComas(l.PRECIOVENTA) + "," + sinComas(l.COSTO);
                    cmd.CommandText = comando;
                    cmd.ExecuteScalar();
                }

                comando = "EXEC CERRARVENTA " + idVenta;
                cmd.CommandText = comando;
                cmd.ExecuteScalar();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }

        }

        public void insertarCliente(Cliente cliente)
        {
            string comando = "EXEC INSERTARCLIENTE -1,'" + cliente.CICLIENTE + "','" + cliente.NOMBRES + "','" + cliente.TELEFONO + "'";
            SqlCommand cmd = new SqlCommand();
            this.conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = comando;
            cmd.ExecuteNonQuery();
            this.conn.Close();
        }
        public void insertarCompra(Compra compra, Distribuidora distribuidora, List<Lote> lista)
        {
            try
            {
                string comando = "EXEC INSERTARCOMPRA " + sinComas(compra.COSTOTOTAL) + ",'" + compra.DESCRIPCION + "','" + distribuidora.NOMBRE + "','" + distribuidora.DIRECCION + "','" + distribuidora.TELEFONO + "','" + distribuidora.CATEGORIA + "'," + compra.IDUSUARIO;
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                cmd.ExecuteScalar();

                comando = "EXEC GETULTIMACOMPRA";
                cmd.CommandText = comando;
                int idCompra = convertirEntero(cmd.ExecuteScalar().ToString());

                foreach (Lote l in lista)
                {
                    comando = "EXEC INSERTARLOTE " + l.IDPRODUCTO + "," + idCompra + ",'" + voltearFecha(l.EXPIRACION) + "'," + sinComas(l.COSTO) + "," + l.CANTIDADPAQUETE + "," + l.CANTIDADENPAQUETE + "," + sinComas(l.PRECIOCOMPRA);
                    cmd.CommandText = comando;
                    cmd.ExecuteScalar();
                }

                comando = "EXEC CERRARCOMPRA " + idCompra;
                cmd.CommandText = comando;
                cmd.ExecuteScalar();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
        }

        private string voltearFecha(string fecha)
        {
            return DateTime.Parse(fecha).ToString("yyyy/MM/dd");
        }

        public void insertarProducto(Producto producto)
        {
            string comando = "EXEC INSERTARPRODUCTO -1,'" + producto.CODIGO + "','" + producto.NOMBRE + "','" + producto.MARCA + "','" + producto.CONTENIDO + "','" + producto.CATEGORIA + "',0," + sinComas(producto.PRECIOVENTA) + ",'" + producto.DESCRIPCION + "','" + producto.UBICACION + "'";
            SqlCommand cmd = new SqlCommand();
            this.conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = comando;
            cmd.ExecuteScalar();
            this.conn.Close();
        }

        public void editarProducto(Producto producto)
        {
            string comando = "EXEC INSERTARPRODUCTO " + producto.IDPRODUCTO + ",'" + producto.CODIGO + "','" + producto.NOMBRE + "','" + producto.MARCA + "','" + producto.CONTENIDO + "','" + producto.CATEGORIA + "'," + producto.PRECIOCOMPRA + "," + sinComas(producto.PRECIOVENTA) + ",'" + producto.DESCRIPCION + "','" + producto.UBICACION + "'";
            SqlCommand cmd = new SqlCommand();
            this.conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = comando;
            cmd.ExecuteScalar();
            this.conn.Close();
        }

        public List<ListaVenta> listarVentas(Usuario usuario)
        {
            string comando;
            comando = "SELECT * FROM LISTARVENTASHOY WHERE IDUSUARIO = " + usuario.IDUSUARIO;
            SqlCommand cmd = new SqlCommand();
            this.conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = comando;
            SqlDataReader myReader = null;
            myReader = cmd.ExecuteReader();
            List<ListaVenta> lis = new List<ListaVenta>();
            while (myReader.Read())
            {
                int id = convertirEntero(myReader["IDVENTA"].ToString());
                string vendedor = myReader["VENDEDOR"].ToString();
                string cliente = myReader["CLIENTE"].ToString();
                string ciCliente = myReader["CICLIENTE"].ToString();
                string fecha = myReader["fecha"].ToString();
                decimal costoTotal = convertirDecimal(myReader["costototal"].ToString());
                decimal efectivo = convertirDecimal(myReader["efectivo"].ToString());
                decimal cambio = convertirDecimal(myReader["cambio"].ToString());
                string pago = myReader["pago"].ToString();
                string estado = myReader["estado"].ToString();
                string descripcion = myReader["DESCRIPCION"].ToString();

                ListaVenta ven = new ListaVenta(id, -1, -1, fecha, costoTotal, efectivo, cambio, estado, pago, vendedor, cliente, ciCliente, descripcion);
                lis.Add(ven);
            }
            this.conn.Close();
            return lis;
        }

        public List<Distribuidora> listarDistribuidoras()
        {
            string comando = "SELECT * FROM LISTARDISTRIBUIDORAS ORDER BY NOMBRE";
            SqlCommand cmd = new SqlCommand();
            this.conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = comando;
            SqlDataReader myReader = null;
            myReader = cmd.ExecuteReader();
            List<Distribuidora> lis = new List<Distribuidora>();
            while (myReader.Read())
            {
                int id = convertirEntero(myReader["IDDISTRIBUIDORA"].ToString());
                string nombre = myReader["NOMBRE"].ToString();
                string direccion = myReader["DIRECCION"].ToString();
                string telefono = myReader["TELEFONO"].ToString();
                string categoria = myReader["CATEGORIA"].ToString();

                Distribuidora dis = new Distribuidora(id, nombre, direccion, telefono, categoria);
                lis.Add(dis);
            }
            this.conn.Close();
            return lis;
        }

        public List<ListaLoteVenta> listarLoteVenta(int idVenta)
        {
            try
            {
                string comando;
                comando = "EXEC LISTARLOTEVENTA " + idVenta;
                SqlCommand cmd = new SqlCommand();
                this.conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = comando;
                SqlDataReader myReader = null;
                myReader = cmd.ExecuteReader();
                List<ListaLoteVenta> lis = new List<ListaLoteVenta>();
                while (myReader.Read())
                {
                    string codigo = myReader["CODIGO"].ToString();
                    string nombre = myReader["NOMBRE"].ToString();
                    string marca = myReader["MARCA"].ToString();
                    string contenido = myReader["CONTENIDO"].ToString();
                    decimal precioVenta = convertirDecimal(myReader["PRECIOVENTA"].ToString());
                    int cantidad = convertirEntero(myReader["CANTIDAD"].ToString());
                    decimal costo = convertirDecimal(myReader["COSTO"].ToString());

                    ListaLoteVenta lote = new ListaLoteVenta(idVenta, -1, cantidad, precioVenta, "", costo, codigo, nombre, marca, contenido);
                    lis.Add(lote);
                }
                this.conn.Close();
                return lis;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.conn.Close();
            }
            return null;
        }

        public void insertarDesdeTexto()
        {
            string fichero = Directory.GetCurrentDirectory() + "\\insertar.txt";
            string archivo = String.Empty;
            if (File.Exists(fichero))
            {
                archivo = File.ReadAllText(fichero);
                string[] lineas = archivo.Split('\n');
                foreach (string linea in lineas)
                {
                    string[] l = linea.Split(',');
                    string codigo = l[0];
                    string nombre = l[1];
                    string marca = l[2];
                    string contenido = l[3];
                    decimal precio = convertirDecimal(l[4]);
                    string categoria = l[5];
                    string ubicacion = l[6];

                    Producto pro = new Producto(-1, codigo, nombre, categoria, "", 0, precio, "", ubicacion, 0, marca, contenido);
                    insertarProducto(pro);
                }
            }

        }

        public List<ControlP> listarControles()
        {
            string comando;
            comando = "SELECT * FROM LISTARCONTROL ORDER BY EXPIRACION";
            SqlCommand cmd = new SqlCommand();
            this.conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = comando;
            SqlDataReader myReader = null;
            myReader = cmd.ExecuteReader();
            List<ControlP> lis = new List<ControlP>();
            while (myReader.Read())
            {
                int idLote = convertirEntero(myReader["IdLote"].ToString());
                string codigo = myReader["Codigo"].ToString();
                string producto = myReader["producto"].ToString();
                int cantidad = convertirEntero(myReader["cantidad"].ToString());
                string expiracion = myReader["expiracion"].ToString();

                ControlP cp = new ControlP(idLote, codigo, producto, cantidad, expiracion);
                lis.Add(cp);
            }
            this.conn.Close();
            return lis;
        }
        
    }
}
