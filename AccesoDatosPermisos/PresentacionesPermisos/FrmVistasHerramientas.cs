using System;
using System.Windows.Forms;
using EntidadesPermisos;
using ManejadoresPermisos;

namespace PresentacionesPermisos
{
    public partial class FrmVistasHerramientas : Form
    {
        public static ManejadoresHerramientas _manejaherra;
        private Herramientas _herramienta;
        public FrmVistasHerramientas()
        {
            InitializeComponent();
            _manejaherra = new ManejadoresHerramientas();
            _herramienta = new Herramientas();
        }

        private void FrmVistasHerramientas_Load(object sender, EventArgs e)
        {
            CargarHerramientas("");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCreaHerramientas fc = new FrmCreaHerramientas(this);
            fc.banderaGuardar = "guardar";
            fc.UpdateEventHandler += Fc_UpdateEventHandler;
            fc.ShowDialog();
            
        }

        private void Fc_UpdateEventHandler(object sender, FrmCreaHerramientas.UpdateEventArgs args)
        {
            CargarHerramientas("");
        }

        public void CargarHerramientas(string filtro)
        {
            dtgHerramientas.DataSource = _manejaherra.ObtenerHerramientas(filtro);
        }

        private void dtgHerramientas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCreaHerramientas fc = new FrmCreaHerramientas(this);
            fc.banderaGuardar = "actualizar";
            
         
            fc.txtCodigo.Text = dtgHerramientas.CurrentRow.Cells["CodigoHerramienta"].Value.ToString();
            fc.txtMedida.Text = dtgHerramientas.CurrentRow.Cells["medida"].Value.ToString();
            fc.txtNombre.Text = dtgHerramientas.CurrentRow.Cells["nombre"].Value.ToString();
            fc.txtDescripcion.Text = dtgHerramientas.CurrentRow.Cells["descripcion"].Value.ToString();
            fc.txtMarca.Text = dtgHerramientas.CurrentRow.Cells["marca"].Value.ToString();
            fc.txtCodigo.Enabled = false;
          
            fc.ShowDialog();

        }

        private void Eliminar()
        {
            if (MessageBox.Show("Desea eliminar la herramienta seleccionada", "Eliminar categoria", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var categoria = dtgHerramientas.CurrentRow.Cells["nombre"].Value.ToString();
                _manejaherra.EliminarHerramientas(categoria);
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            CargarHerramientas("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
