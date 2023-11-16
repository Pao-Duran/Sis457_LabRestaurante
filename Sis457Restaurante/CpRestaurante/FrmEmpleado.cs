using CadRestaurante;
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
            txtTelefono.Text = empleado.telefono;
            txtDireccion.Text = empleado.direccion;
            txtCargo.Text = empleado.cargo;

        }
        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            txtTelefono.Text = string.Empty;
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
            erpTelefono.SetError(txtTelefono, "");
            erpNombre.SetError(txtNombre, "");
            erpNombre.SetError(txtNombre, "");
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                esValido = false;
                erpNombre.SetError(txtNombre, "el campo nombre es obligatorio");
            }
            if (string.IsNullOrEmpty(txtPrimerApellido.Text))
            {
                esValido = false;
                erpNombre.SetError(txtPrimerApellido, "el campo apellido paterno es obligatorio");
            }
            if (string.IsNullOrEmpty(txtSegundoApellido.Text))
            {
                esValido = false;
                erpNombre.SetError(txtSegundoApellido, "el campo apellido materno es obligatorio");
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                esValido = false;
                erpNombre.SetError(txtTelefono, "el campo telefono es obligatorio");
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                esValido = false;
                erpNombre.SetError(txtDireccion, "el campo direccion es obligatorio");
            }
            if (string.IsNullOrEmpty(txtCargo.Text))
            {
                esValido = false;
                erpNombre.SetError(txtCargo, "el campo cargo es obligatorio");
            }
            return esValido;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var empleado = new Empleado();
                empleado.nombre = txtNombre.Text.Trim();
                empleado.primerApellido = txtPrimerApellido.Text.Trim();
                empleado.segundoApellido = txtSegundoApellido.Text.Trim();
                empleado.telefono = txtTelefono.Text.Trim();
                empleado.direccion = txtDireccion.Text.Trim();
                empleado.cargo = txtCargo.Text.Trim();

                if (esNuevo)
                {
                    empleado.fechaRegistro = DateTime.Now;
                    empleado.estado = 1;
                    EmpleadoCln.insertar(empleado);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    empleado.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    EmpleadoCln.actualizar(empleado);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Empleado guardado correctamente", "::: Restaurante - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string nombre = dgvLista.Rows[index].Cells["nombre"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja el producto {nombre}?",
               "::: Restaurante - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                EmpleadoCln.eliminar(id, "SIS457");
                listar();
                MessageBox.Show("Producto dado de baja correctamente", "::: Restaurante - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}