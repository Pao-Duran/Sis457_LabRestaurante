using ClnRestaurante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpRestaurante
{
    public partial class FrmEmpleado : Form
    {
        bool esNuevo = false;
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var empleados = EmpleadoCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = empleados;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["nombre"].HeaderText = "nombre";
            dgvLista.Columns["primerApellido"].HeaderText = "primerApellido";
            dgvLista.Columns["segundoApellido"].HeaderText = "segundoApellido";
            dgvLista.Columns["telefono"].HeaderText = "telefono";
            dgvLista.Columns["direccion"].HeaderText = "direccion";
            dgvLista.Columns["cargo"].HeaderText = "cargo";
            btnEditar.Enabled = empleados.Count > 0;
            btnEliminar.Enabled = empleados.Count > 0;
            if (empleados.Count > 0) dgvLista.Rows[0].Cells["nombre"].Selected = true;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            Size = new Size(738, 438);
            listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(738, 638);
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(738, 638);

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var empleado = EmpleadoCln.get(id);
            txtNombre.Text = empleado.nombre;
            txtPrimerApellido.Text = empleado.primerApellido;
            txtSegundoApellido.Text = empleado.segundoApellido;
            nudTelefono.Value = empleado.telefono;
            txtDireccion.Text = empleado.direccion;
            txtCargo.Text = empleado.cargo;

        }
        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            nudTelefono.Value = 0;
            txtDireccion.Text = string.Empty;
            txtCargo.Text = string.Empty;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(738, 638);
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();        
        }

        private bool validar()
        {
            bool esValido = true;
            erpNombre.SetError(txtNombre, "");
            erpPrimerApellido.SetError(txtPrimerApellido, "");
            erpSegundoApellido.SetError(txtSegundoApellido, "");
            erpTelefono.SetError(nudTelefono, "");
            erpNombre.SetError(txtNombre, "");
            erpNombre.SetError(txtNombre, "");
        }
    }
}