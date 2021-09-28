using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesPermisos;
using AccesoDatosPermisos;

namespace ManejadoresPermisos
{
    public class ManejadoresHerramientas
    {
        UsuariosAccesoDatos _usuariosAccesoDatos = new UsuariosAccesoDatos();

        public Tuple<bool, string> ValidarHerramientas(Herramientas herra)
        {
            bool error = true;
            string cadenaErrores = "";

            if (herra.Codigoherramienta.Length == 0 || herra.Codigoherramienta == null)
            {
                cadenaErrores = cadenaErrores + "El campo Nombre no puede ser vacio \n";
                error = false;
            }

            if (herra.Nombre.Length == 0 || herra.Nombre == null)
            {
                cadenaErrores = cadenaErrores + "El campo de la descripcion no puede ser vacio \n";
                error = false;
            }

            if (herra.Medida.Length == 0 || herra.Medida == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (herra.Marca.Length == 0 || herra.Marca == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (herra.Descripcion.Length == 0 || herra.Descripcion == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }

        public void GuardarHerramientas(Herramientas herramienta)
        {
            try
            {
                _usuariosAccesoDatos.GuardarHerramientas(herramienta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public List<Herramientas> ObtenerHerramientas(string filtro)
        {
            var listaContactos = _usuariosAccesoDatos.ObtenerHerramientas(filtro);
            return listaContactos;
        }

        public void ActualizarHerramientas(Herramientas herramienta)
        {
            try
            {
                _usuariosAccesoDatos.ActualizarHerramientas(herramienta);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        public void EliminarHerramientas(string herramienta)
        {
            try
            {
                _usuariosAccesoDatos.EliminarHerramientas(herramienta);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }
    }
}
