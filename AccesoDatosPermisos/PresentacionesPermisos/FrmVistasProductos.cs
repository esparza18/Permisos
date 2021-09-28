using System;
using System.Windows.Forms;
using EntidadesPermisos;
using ManejadoresPermisos;

namespace PresentacionesPermisos
{
    public partial class FrmVistasProductos : Form
    {
        public static ManejadoresProductos _manejapro;
        private Productos _producto;
        public FrmVistasProductos()
        {
            InitializeComponent();
            _manejapro = new ManejadoresProductos();
            _producto = new Productos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCreaProductos fc = new FrmCreaProductos(this);
            fc.banderaGuardar = "guardar";
            fc.UpdateEventHandler += Fc_UpdateEventHandler;
            fc.ShowDialog();
        }

        private void Fc_UpdateEventHandler(object sender, FrmCreaProductos.UpdateEventArgs args)
        {
            CargarProductos("");
        }

        public void CargarProductos(string filtro)
        {
            dtgProductos.DataSource = _manejapro.ObtenerProductos(filtro);
        }

        private void FrmVistasProductos_Load(object sender, EventArgs e)
        {
            CargarProductos("");
        }

        private void dtgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCreaProductos fc = new FrmCreaProductos(this);
            fc.banderaGuardar = "actualizar";
            
           
            fc.txtCodigo.Text = dtgProductos.CurrentRow.Cells["CodigoBarras"].Value.ToString();
            fc.txtNombre.Text = dtgProductos.CurrentRow.Cells["nombre"].Value.ToString();
            fc.txtDescripcion.Text = dtgProductos.CurrentRow.Cells["descripción"].Value.ToString();
            fc.txtMarca.Text = dtgProductos.CurrentRow.Cells["marca"].Value.ToString();
            fc.txtCodigo.Enabled = false;

            fc.ShowDialog();
        }

        private void Eliminar()
        {
            if (MessageBox.Show("Desea eliminar el producto seleccionado", "Eliminar categoria", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var categoria = dtgProductos.CurrentRow.Cells["nombre"].Value.ToString();
                _manejapro.EliminarProductos(categoria);
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            CargarProductos("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
