using System;
using System.Windows.Forms;
using ManejadoresPermisos;
using EntidadesPermisos;

namespace PresentacionesPermisos
{
    public partial class FrmVistasUsuarios : Form
    {
        public static ManejadoresUsuarios _manejadorUsuario;
        private Usuarios _usuario;
        public FrmVistasUsuarios()
        {
            InitializeComponent();
            _manejadorUsuario = new ManejadoresUsuarios();
            _usuario = new Usuarios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVistasUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios("");
        }

        public void CargarUsuarios(string filtro)
        {
            dtgUsuarios.DataSource = _manejadorUsuario.ObtenerUsuarios(filtro);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistro fr = new FrmRegistro();
            fr.banderaGuardar = "guardar";
            fr.ShowDialog();
        }

        private void dtgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmRegistro fc = new FrmRegistro();
            fc.banderaGuardar = "actualizar";

            fc.txtID.Text = dtgUsuarios.CurrentRow.Cells["idusuario"].Value.ToString();
            fc.txtNombre.Text = dtgUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
            fc.txtApellidop.Text = dtgUsuarios.CurrentRow.Cells["apellidop"].Value.ToString();
            fc.txtApellidom.Text = dtgUsuarios.CurrentRow.Cells["apellidom"].Value.ToString();
            fc.txtFecha.Text = dtgUsuarios.CurrentRow.Cells["fechanacimiento"].Value.ToString();
            fc.txtRFC.Text = dtgUsuarios.CurrentRow.Cells["rfc"].Value.ToString();
            fc.txtContraseña.Text = dtgUsuarios.CurrentRow.Cells["contrasena"].Value.ToString();
            fc.cmbEstado.Text = dtgUsuarios.CurrentRow.Cells["fkidaccesos"].Value.ToString();
            fc.txtNombre.Enabled = false;
            fc.txtApellidop.Enabled = false;
            fc.txtApellidom.Enabled = false;
            fc.txtFecha.Enabled = false;
            fc.txtRFC.Enabled = false;
            fc.txtContraseña.Enabled = false;
            fc.cmbEstado.Visible = true;

            fc.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            CargarUsuarios("");
        }

        private void Eliminar()
        {
            if (MessageBox.Show("Desea eliminar el usuario seleccionado", "Eliminar usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var categoria = dtgUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
                _manejadorUsuario.EliminarUsuarios(categoria);
            }


        }

    }
}
