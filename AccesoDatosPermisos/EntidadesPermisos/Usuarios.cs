using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
   public class Usuarios
    {
        private int _idusuario;
        private string _nombre;
        private string _apellidop;
        private string _apellidom;
        private string _fechanacimiento;
        private string _rfc;
        private string _contrasena;
        private string _fkidaccesos;

        public int Idusuario { get => _idusuario; set => _idusuario = value; }
        public string Apellidop { get => _apellidop; set => _apellidop = value; }
        public string Apellidom { get => _apellidom; set => _apellidom = value; }
        public string Fechanacimiento { get => _fechanacimiento; set => _fechanacimiento = value; }
        public string Rfc { get => _rfc; set => _rfc = value; }
        public string Fkidaccesos { get => _fkidaccesos; set => _fkidaccesos = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
    }
}
