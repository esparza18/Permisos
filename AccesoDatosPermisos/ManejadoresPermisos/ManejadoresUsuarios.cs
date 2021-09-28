using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosPermisos;
using EntidadesPermisos;

namespace ManejadoresPermisos
{
    public class ManejadoresUsuarios
    {
        UsuariosAccesoDatos _usuariosAccesoDatos = new UsuariosAccesoDatos();

        public Tuple<bool, string> ValidarUsuarios(Usuarios usuario)
        {
            bool error = true;
            string cadenaErrores = "";

            
            if (usuario.Nombre.Length == 0 || usuario.Nombre == null)
            {
                cadenaErrores = cadenaErrores + "El campo de la descripcion no puede ser vacio \n";
                error = false;
            }

            if (usuario.Apellidop.Length == 0 || usuario.Apellidop == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (usuario.Apellidom.Length == 0 || usuario.Apellidom == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (usuario.Fechanacimiento.Length == 0 || usuario.Fechanacimiento == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (usuario.Rfc.Length == 0 || usuario.Rfc == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (usuario.Contrasena.Length == 0 || usuario.Contrasena == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }


            if (usuario.Fkidaccesos.Length == 0 || usuario.Fkidaccesos == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }




            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }

        public void GuardarUsuarios(Usuarios usuario)
        {
            try
            {
                _usuariosAccesoDatos.GuardarUsuarios(usuario);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public List<Usuarios> ObtenerUsuarios(string filtro)
        {
            var listaContactos = _usuariosAccesoDatos.ObtenerUsuarios(filtro);
            return listaContactos;
        }

        public void ActualizarUsuarios(Usuarios usuario)
        {
            try
            {
                _usuariosAccesoDatos.ActualizarUsuarios(usuario);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        public void EliminarUsuarios(string usuario)
        {
            try
            {
                _usuariosAccesoDatos.EliminarUsuarios(usuario);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public bool ExisteUsuario(Usuarios usuario)
        {
            var existe = _usuariosAccesoDatos.ExisteUsuario(usuario);
            return existe;
        }
    }
}
