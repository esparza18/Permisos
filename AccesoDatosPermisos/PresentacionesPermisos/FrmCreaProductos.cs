using System;
using System.Windows.Forms;
using EntidadesPermisos;
using ManejadoresPermisos;

namespace PresentacionesPermisos
{
    public partial class FrmCreaProductos : Form
    {
        private ManejadoresProductos _manejaprod;
        private Productos _producto;

        public static FrmVistasProductos fr = new FrmVistasProductos();
        public string banderaGuardar;
        public FrmCreaProductos(FrmVistasProductos registro)
        {
            InitializeComponent();
            _manejaprod = new ManejadoresProductos();
            _producto = new Productos();
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


        private void GuardarProducto()
        {
            _producto.CodigoBarras = txtCodigo.Text;
            _producto.Nombre = txtNombre.Text;
            _producto.Descripción = txtDescripcion.Text;
            _producto.Marca = txtMarca.Text;
         



            var valida = _manejaprod.ValidarProductos(_producto);

            if (valida.Item1)
            {
                _manejaprod.GuardarProductos(_producto);
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
                GuardarProducto();
                Agregard();
                Close();
            }

            else
            {
                ActualizarProducto();
                Close();
            }
        }

        private void ActualizarProducto()
        {
            _manejaprod.ActualizarProductos(new Productos
            {

                CodigoBarras = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripción = txtDescripcion.Text,
                Marca = txtMarca.Text
                

            });
        }
    }
}
