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
    public partial class frmTareasAdmin : Form
    {
        public frmTareasAdmin()
        {
            InitializeComponent();
        }

        private void frmTareasAdmin_Load(object sender, EventArgs e)
        {
            MostrarTablas();
            Control();
            btnEliminarTarea.Enabled = false;
            btnEliminarLugar.Enabled = false;

            dgvTareas.CellClick += dgvTareas_CellClick;
            dgvLugares.CellClick += dgvLugares_CellClick;
        }
        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            string tarea = txtTareas.Text.Trim();

            using (OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ControlDeUsuarios.accdb"))
            {
                conexion.Open();

                if (!string.IsNullOrEmpty(tarea))
                {
                    string consultaExistencia = "SELECT COUNT(*) FROM Tareas WHERE Tarea = @tarea";
                    using (OleDbCommand verificar = new OleDbCommand(consultaExistencia, conexion))
                    {
                        verificar.Parameters.AddWithValue("@tarea", tarea);
                        int existe = (int)verificar.ExecuteScalar();

                        if (existe > 0)
                        {
                            MessageBox.Show("La tarea ya existe.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string consultaTarea = "INSERT INTO Tareas (Tarea) VALUES (@tarea)";
                    using (OleDbCommand cmd = new OleDbCommand(consultaTarea, conexion))
                    {
                        cmd.Parameters.AddWithValue("@tarea", tarea);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Tarea agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            txtTareas.Clear();
            MostrarTablas();
        }
        private void btnAgregarLugar_Click(object sender, EventArgs e)
        {
            string lugar = txtLugares.Text.Trim();

            using (OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ControlDeUsuarios.accdb"))
            {
                conexion.Open();

                if (!string.IsNullOrEmpty(lugar))
                {
                    string consultaExistencia = "SELECT COUNT(*) FROM Lugares WHERE Lugar = @lugar";
                    using (OleDbCommand verificar = new OleDbCommand(consultaExistencia, conexion))
                    {
                        verificar.Parameters.AddWithValue("@lugar", lugar);
                        int existe = (int)verificar.ExecuteScalar();

                        if (existe > 0)
                        {
                            MessageBox.Show("El lugar ya existe.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string consultaLugar = "INSERT INTO Lugares (Lugar) VALUES (@lugar)";
                    using (OleDbCommand cmd = new OleDbCommand(consultaLugar, conexion))
                    {
                        cmd.Parameters.AddWithValue("@lugar", lugar);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Lugar agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            txtLugares.Clear();
            MostrarTablas();
        }
        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            string tarea = txtTareas.Text.Trim();

            if (string.IsNullOrEmpty(tarea))
            {
                MessageBox.Show("Seleccioná una tarea para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmación = MessageBox.Show($"¿Estás seguro de eliminar la tarea \"{tarea}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmación == DialogResult.No)
                return;

            using (OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ControlDeUsuarios.accdb"))
            {
                conexion.Open();
                string consulta = "DELETE FROM Tareas WHERE Tarea = @tarea";
                using (OleDbCommand cmd = new OleDbCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@tarea", tarea);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Tarea eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTareas.Clear();
            btnEliminarTarea.Enabled = false;
            MostrarTablas();
        }

        private void btnEliminarLugar_Click(object sender, EventArgs e)
        {
            string lugar = txtLugares.Text.Trim();

            if (string.IsNullOrEmpty(lugar))
            {
                MessageBox.Show("Seleccioná un lugar para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmación = MessageBox.Show($"¿Estás seguro de eliminar el lugar \"{lugar}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmación == DialogResult.No)
                return;

            using (OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ControlDeUsuarios.accdb"))
            {
                conexion.Open();
                string consulta = "DELETE FROM Lugares WHERE Lugar = @lugar";
                using (OleDbCommand cmd = new OleDbCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@lugar", lugar);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Lugar eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtLugares.Clear();
            btnEliminarLugar.Enabled = false;
            MostrarTablas();
        }
        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTareas.Text = dgvTareas.Rows[e.RowIndex].Cells["Tarea"].Value?.ToString();
                btnEliminarTarea.Enabled = true;
            }
        }

        private void dgvLugares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtLugares.Text = dgvLugares.Rows[e.RowIndex].Cells["Lugar"].Value?.ToString();
                btnEliminarLugar.Enabled = true;
            }
        }
        private void MostrarTablas()
        {
            string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ControlDeUsuarios.accdb";

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                string consultaTareas = "SELECT Tarea FROM Tareas";
                OleDbDataAdapter adaptadorTareas = new OleDbDataAdapter(consultaTareas, conexion);
                DataTable tablaTareas = new DataTable();
                adaptadorTareas.Fill(tablaTareas);
                dgvTareas.DataSource = tablaTareas;
                dgvTareas.Columns[0].HeaderText = "Tareas disponibles";
                string consultaLugares = "SELECT Lugar FROM Lugares";
                OleDbDataAdapter adaptadorLugares = new OleDbDataAdapter(consultaLugares, conexion);
                DataTable tablaLugares = new DataTable();
                adaptadorLugares.Fill(tablaLugares);
                dgvLugares.DataSource = tablaLugares;
                dgvLugares.Columns[0].HeaderText = "Lugares disponibles";

            }
        }
        public void Control()
        {
            if (txtLugares.Text != "")
            {
                btnAgregarLugar.Enabled = true;
            }
            else
            {
                btnAgregarLugar.Enabled = false;
            }
            if (txtTareas.Text != "")
            {
                btnAgregarTarea.Enabled = true;
            }
            else
            {
                btnAgregarTarea.Enabled = false;
            }
        }
        private void txtTareas_TextChanged_1(object sender, EventArgs e)
        {
            Control();
        }

        private void txtLugares_TextChanged_1(object sender, EventArgs e)
        {
            Control();
        }
    }
}
