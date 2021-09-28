using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class Herramientas
    {
        private string _codigoherramienta;
        private string _nombre;
        private string _medida;
        private string _marca;
        private string _descripcion;

        public string Codigoherramienta { get => _codigoherramienta; set => _codigoherramienta = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Medida { get => _medida; set => _medida = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}
