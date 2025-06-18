using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySalvarezza_IEFI
{
    public partial class frmUsuarioAdmin : Form
    {
        public frmUsuarioAdmin()
        {
            InitializeComponent();
        }
        clsConexión conexion = new clsConexión();

        private void frmUsuarioAdmin_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            LimpiarCampos();
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.conexión.Open();
                string consultaValidación = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario OR DNI = @DNI";
                using (OleDbCommand validarCmd = new OleDbCommand(consultaValidación, conexion.conexión))
                {
                    validarCmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text.Trim());
                    validarCmd.Parameters.AddWithValue("@DNI", txtDNI.Text.Trim());
                    int existe = (int)validarCmd.ExecuteScalar();
                    if (existe > 0)
                    {
                        MessageBox.Show("Ya existe un usuario con ese nombre o DNI.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string consulta = "INSERT INTO Usuarios (Usuario, Contraseña, Cargo, Mail, Telefono, Direccion, DNI) VALUES (@Usuario, @Contraseña, @Cargo, @Mail, @Telefono, @Direccion, @DNI)";

                using (OleDbCommand comando = new OleDbCommand(consulta, conexion.conexión))
                {
                    comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text.Trim());
                    comando.Parameters.AddWithValue("@Contraseña", txtContraseña.Text.Trim());
                    comando.Parameters.AddWithValue("@Cargo", cmbCargo.Text.Trim());
                    comando.Parameters.AddWithValue("@Mail", txtMail.Text.Trim());
                    comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                    comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                    comando.Parameters.AddWithValue("@DNI", txtDNI.Text.Trim());

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarCampos();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.conexión.State == ConnectionState.Open)
                    conexion.conexión.Close();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMostrar.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un usuario de la grilla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuarioAEliminar = dgvMostrar.CurrentRow.Cells["Usuario"].Value.ToString();

            DialogResult confirmación = MessageBox.Show(
                $"¿Estás seguro de que querés eliminar el usuario \"{usuarioAEliminar}\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmación == DialogResult.No)
                return;

            try
            {
                string consulta = "DELETE FROM Usuarios WHERE Usuario = @Usuario";

                using (OleDbCommand comando = new OleDbCommand(consulta, conexion.conexión))
                {
                    comando.Parameters.AddWithValue("@Usuario", usuarioAEliminar);
                    conexion.conexión.Open();
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.conexión.State == ConnectionState.Open)
                    conexion.conexión.Close();
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMostrar.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un usuario de la grilla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuarioOriginal = dgvMostrar.CurrentRow.Cells["Usuario"].Value.ToString();

            try
            {
                conexion.conexión.Open();

                string validar = "SELECT COUNT(*) FROM Usuarios WHERE (Usuario = @NuevoUsuario OR DNI = @NuevoDNI) AND Usuario <> @UsuarioOriginal";

                using (OleDbCommand validarCmd = new OleDbCommand(validar, conexion.conexión))
                {
                    validarCmd.Parameters.AddWithValue("@NuevoUsuario", txtUsuario.Text.Trim());
                    validarCmd.Parameters.AddWithValue("@NuevoDNI", txtDNI.Text.Trim());
                    validarCmd.Parameters.AddWithValue("@UsuarioOriginal", usuarioOriginal);

                    int duplicado = (int)validarCmd.ExecuteScalar();
                    if (duplicado > 0)
                    {
                        MessageBox.Show("Ya existe otro usuario con ese nombre o DNI.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                string consulta = "UPDATE Usuarios SET Usuario = @Usuario, Contraseña = @Contraseña, Cargo = @Cargo, Mail = @Mail, Telefono = @Telefono, Direccion = @Direccion, DNI = @DNI WHERE Usuario = @UsuarioOriginal";

                using (OleDbCommand comando = new OleDbCommand(consulta, conexion.conexión))
                {
                    comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text.Trim());
                    comando.Parameters.AddWithValue("@Contraseña", txtContraseña.Text.Trim());
                    comando.Parameters.AddWithValue("@Cargo", cmbCargo.Text.Trim());
                    comando.Parameters.AddWithValue("@Mail", txtMail.Text.Trim());
                    comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                    comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                    comando.Parameters.AddWithValue("@DNI", txtDNI.Text.Trim());
                    comando.Parameters.AddWithValue("@UsuarioOriginal", usuarioOriginal);

                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.conexión.State == ConnectionState.Open)
                    conexion.conexión.Close();
            }
        }
        private void CargarUsuarios()
        {
            try
            {
                string consulta = "SELECT * FROM Usuarios";

                using (OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion.conexión))
                {
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    dgvMostrar.DataSource = dt;
                    dgvMostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvMostrar.ReadOnly = true;
                    dgvMostrar.AllowUserToAddRows = false;
                    dgvMostrar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            cmbCargo.SelectedIndex = -1;
            txtMail.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtDNI.Clear();
        }
        public void controlDeDatos(TextBox txt, TextBox txt2, ComboBox cmb, TextBox txt3, TextBox txt4, TextBox txt5, TextBox txt6)
        {
            if (txtUsuario.Text != "")
            {
                bool camposCompletos = txt.Text != "" && txt2.Text != "" && cmb.SelectedIndex != -1 && txt3.Text != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "";

                btnAgregar.Enabled = camposCompletos;
                btnModificar.Enabled = camposCompletos;
                btnEliminar.Enabled = camposCompletos;
            }
            else
            {
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }
        private bool EsEmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            controlDeDatos(txtUsuario, txtContraseña, cmbCargo, txtMail, txtTelefono, txtDireccion, txtDNI);
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            controlDeDatos(txtUsuario, txtContraseña, cmbCargo, txtMail, txtTelefono, txtDireccion, txtDNI);
        }
        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlDeDatos(txtUsuario, txtContraseña, cmbCargo, txtMail, txtTelefono, txtDireccion, txtDNI);
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (!EsEmailValido(txtMail.Text))
            {
                txtMail.BackColor = Color.LightPink;
            }
            else
            {
                txtMail.BackColor = Color.White;
            }

            controlDeDatos(txtUsuario, txtContraseña, cmbCargo, txtMail, txtTelefono, txtDireccion, txtDNI);    
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Length < 8 || txtTelefono.Text.Length > 15)
            {
                txtTelefono.BackColor = Color.LightPink;
            }
            else
            {
                txtTelefono.BackColor = Color.White;
            }

            controlDeDatos(txtUsuario, txtContraseña, cmbCargo, txtMail, txtTelefono, txtDireccion, txtDNI);
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            controlDeDatos(txtUsuario, txtContraseña, cmbCargo, txtMail, txtTelefono, txtDireccion, txtDNI);
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (txtDNI.Text.Length < 8 || txtDNI.Text.Length > 9)
            {
                txtDNI.BackColor = Color.LightPink;
            }
            else
            {
                txtDNI.BackColor = Color.White;
            }

            controlDeDatos(txtUsuario, txtContraseña, cmbCargo, txtMail, txtTelefono, txtDireccion, txtDNI);
        }
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvMostrar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMostrar.CurrentRow != null)
            {
                DataGridViewRow fila = dgvMostrar.CurrentRow;

                txtUsuario.Text = fila.Cells["Usuario"].Value?.ToString();
                txtContraseña.Text = fila.Cells["Contraseña"].Value?.ToString();
                txtMail.Text = fila.Cells["Mail"].Value?.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString();
                txtDNI.Text = fila.Cells["DNI"].Value?.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value?.ToString();
                cmbCargo.Text = fila.Cells["Cargo"].Value?.ToString();
                btnAgregar.Enabled = false;
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
