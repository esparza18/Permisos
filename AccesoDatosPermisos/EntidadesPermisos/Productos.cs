using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class Productos
    {
        private string _codigoBarras;
        private string _nombre;
        private string _descripción;
        private string _marca;

        public string CodigoBarras { get => _codigoBarras; set => _codigoBarras = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripción { get => _descripción; set => _descripción = value; }
        public string Marca { get => _marca; set => _marca = value; }
    }
}
