using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntidadesPermisos;


namespace AccesoDatosPermisos
{
    public class UsuariosAccesoDatos
    {
        ConexionAccesoDatos _conexion;
        public UsuariosAccesoDatos()
        {

            try
            {
                _conexion = new ConexionAccesoDatos("localhost", "root", "123456789", "permisos", 3306);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la conexion" + ex.Message);
            }
        }
         //---------------------------------METODOS PARA HERRAMIENTAS----------------------------------------------

        public void GuardarHerramientas(Herramientas herramienta)
        {
            try
            {
                string consulta = string.Format("insert into herramientas values ('{0}','{1}','{2}','{3}','{4}')",
                    herramienta.Codigoherramienta, herramienta.Nombre,herramienta.Medida,herramienta.Marca,herramienta.Descripcion);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public void EliminarHerramientas(string herramienta)
        {
            try
            {
                string consulta = string.Format("delete from herramientas where CodigoHerramienta ='{0}')", herramienta);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public void ActualizarHerramientas(Herramientas herramienta)
        {
            try
            {
                string consulta = string.Format("update herramientas set nombre = '{0}', medida = '{1}', marca = '{2}',descripcion = '{3}' where CodigoHerramienta = '{4}'",
                herramienta.Nombre, herramienta.Medida, herramienta.Marca, herramienta.Descripcion,herramienta.Codigoherramienta);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        public List<Herramientas> ObtenerHerramientas(string filtro)
        {
            var ListaHerramientas = new List<Herramientas>();
            var ds = new DataSet();
            string consulta = string.Format("select * from herramientas where nombre like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "herramientas");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {

                var herra = new Herramientas
                {
                    Codigoherramienta = row["CodigoHerramienta"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Medida = row["medida"].ToString(),
                    Marca = row["marca"].ToString(),
                    Descripcion = row["descripcion"].ToString()

                };


                ListaHerramientas.Add(herra);

            }

            return ListaHerramientas;
        }

        //--------------------METODOS PARA USUARIOS-----------------------------------------------------------------

        public void GuardarUsuarios(Usuarios usuario)
        {
            try
            {
                string consulta = string.Format("insert into usuarios values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    usuario.Idusuario, usuario.Nombre, usuario.Apellidop, usuario.Apellidom, usuario.Fechanacimiento,usuario.Rfc,
                  usuario.Contrasena,usuario.Fkidaccesos);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public void EliminarUsuarios(string usuario)
        {
            try
            {
                string consulta = string.Format("delete from usuarios where idusuario ='{0}')", usuario);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public void ActualizarUsuarios(Usuarios usuario)
        {
            try
            {
                string consulta = string.Format("update usuarios set nombre = '{0}', apellidop = '{1}'," +
                    " apellidom = '{2}',fechanacimiento = '{3}',rfc = '{4}',contrasena = '{5}',fkidaccesos = '{6}'" +
                    " where idusuario = '{7}'",
                usuario.Nombre, usuario.Apellidop, usuario.Apellidom, usuario.Fechanacimiento, usuario.Rfc,usuario.Contrasena,
                usuario.Fkidaccesos, usuario.Idusuario);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        public List<Usuarios> ObtenerUsuarios(string filtro)
        {
            var ListaUsuarios = new List<Usuarios>();
            var ds = new DataSet();
            string consulta = string.Format("select * from usuarios where nombre like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "usuarios");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {

                var usu = new Usuarios
                {
                    Idusuario = int.Parse(row["idusuario"].ToString()),
                    Nombre = row["nombre"].ToString(),
                    Apellidop = row["apellidop"].ToString(),
                    Apellidom = row["apellidom"].ToString(),
                    Fechanacimiento = row["fechanacimiento"].ToString(),
                    Contrasena = row["contrasena"].ToString(),
                    Rfc = row["rfc"].ToString(),
                    Fkidaccesos = row["fkidaccesos"].ToString(),

                };


                ListaUsuarios.Add(usu);

            }

            return ListaUsuarios;
        }


        public bool ExisteUsuario(Usuarios usuario)
        {
            try
            {
                string consulta = string.Format("select count(*) from usuarios where nombre ='{0}' and contrasena = '{1}'", usuario.Nombre, usuario.Contrasena);
                var existe = _conexion.Existencia(consulta);
                if (existe == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la consulta" + ex.Message);
                return false;
            }
        }


        //--------------------METODOS PARA PRODUCTOS-----------------------------------------------------------------

        public void GuardarProductos(Productos producto)
        {
            try
            {
                string consulta = string.Format("insert into productos values ('{0}','{1}','{2}','{3}')",
                    producto.CodigoBarras, producto.Nombre, producto.Marca, producto.Descripción);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public void EliminarProductos(string producto)
        {
            try
            {
                string consulta = string.Format("delete from productos where CodigoBarras ='{0}')", producto);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public void ActualizarProductos(Productos producto)
        {
            try
            {
                string consulta = string.Format("update productos set nombre = '{0}', descripción = '{1}', marca = '{2}' where CodigoBarras = '{3}'",
                producto.Nombre, producto.Descripción, producto.Marca, producto.CodigoBarras);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        public List<Productos> ObtenerProductos(string filtro)
        {
            var ListaProductos = new List<Productos>();
            var ds = new DataSet();
            string consulta = string.Format("select * from productos where nombre like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "productos");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {

                var pro = new Productos
                {
                    CodigoBarras = row["CodigoBarras"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Descripción = row["descripción"].ToString(),
                    Marca = row["marca"].ToString()

                };


                ListaProductos.Add(pro);

            }

            return ListaProductos;
        }


    }
}
