using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosPermisos;
using EntidadesPermisos;

namespace ManejadoresPermisos
{
    public class ManejadoresProductos
    {
        UsuariosAccesoDatos _usuariosAccesoDatos = new UsuariosAccesoDatos();

        public Tuple<bool, string> ValidarProductos(Productos producto)
        {
            bool error = true;
            string cadenaErrores = "";

            if (producto.CodigoBarras.Length == 0 || producto.CodigoBarras == null)
            {
                cadenaErrores = cadenaErrores + "El campo Nombre no puede ser vacio \n";
                error = false;
            }

            if (producto.Nombre.Length == 0 || producto.Nombre == null)
            {
                cadenaErrores = cadenaErrores + "El campo de la descripcion no puede ser vacio \n";
                error = false;
            }

            if (producto.Descripción.Length == 0 || producto.Descripción == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }

            if (producto.Marca.Length == 0 || producto.Marca == null)
            {
                cadenaErrores = cadenaErrores + "El campo del encargado no puede ser vacio \n";
                error = false;
            }


            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }

        public void GuardarProductos(Productos producto)
        {
            try
            {
                _usuariosAccesoDatos.GuardarProductos(producto);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public List<Productos> ObtenerProductos(string filtro)
        {
            var listaContactos = _usuariosAccesoDatos.ObtenerProductos(filtro);
            return listaContactos;
        }

        public void ActualizarProductos(Productos producto)
        {
            try
            {
                _usuariosAccesoDatos.ActualizarProductos(producto);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        public void EliminarProductos(string producto)
        {
            try
            {
                _usuariosAccesoDatos.EliminarProductos(producto);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }
    }
}
