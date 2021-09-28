using System;
using System.Windows.Forms;
using ManejadoresPermisos;
using EntidadesPermisos;

namespace PresentacionesPermisos
{
    public partial class FrmCreaHerramientas : Form
    {
        private ManejadoresHerramientas _manejaherra;
        private Herramientas _herramienta;

        public static FrmVistasHerramientas fr = new FrmVistasHerramientas();
        public string banderaGuardar;
        public FrmCreaHerramientas(FrmVistasHerramientas registro)
        {
            InitializeComponent();
            _herramienta = new Herramientas();
            _manejaherra = new ManejadoresHerramientas();
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregard()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }


        private void GuardarHerramienta()
        {
            _herramienta.Codigoherramienta = txtCodigo.Text;
            _herramienta.Nombre = txtNombre.Text;
            _herramienta.Medida = txtMedida.Text;
            _herramienta.Marca = txtMarca.Text;
            _herramienta.Descripcion = txtDescripcion.Text;
           
            

            var valida = _manejaherra.ValidarHerramientas(_herramienta);

            if (valida.Item1)
            {
                _manejaherra.GuardarHerramientas(_herramienta);
            }

            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar == "guardar")
            {
                GuardarHerramienta();
                Agregard();
                Close();
            }

            else
            {
                ActualizarHerramientas();
                Close();
            }
        }

        private void ActualizarHerramientas()
        {
            _manejaherra.ActualizarHerramientas(new Herramientas
            {
                Codigoherramienta = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Medida = txtMarca.Text,
                Marca = txtMarca.Text,
                Descripcion = txtDescripcion.Text
                
            });
        }

    }
}
