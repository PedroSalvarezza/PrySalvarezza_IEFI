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
            
        }

        private void btnAgregrar_Click(object sender, EventArgs e)
        {
            string tarea = txtTareas.Text.Trim();
            string lugar = txtLugares.Text.Trim();

            using (OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ControlDeUsuarios.accdb"))
            {
                conexion.Open();

                if (!string.IsNullOrEmpty(tarea))
                {
                    string consultaTarea = "INSERT INTO Tareas (Tarea) VALUES (@tarea)";
                    using (OleDbCommand cmd = new OleDbCommand(consultaTarea, conexion))
                    {
                        cmd.Parameters.AddWithValue("@tarea", tarea);
                        cmd.ExecuteNonQuery();
                    }
                }

                if (!string.IsNullOrEmpty(lugar))
                {
                    string consultaLugar = "INSERT INTO Lugares (Lugar) VALUES (@lugar)";
                    using (OleDbCommand cmd = new OleDbCommand(consultaLugar, conexion))
                    {
                        cmd.Parameters.AddWithValue("@lugar", lugar);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Datos agregados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtTareas.Clear();
            txtLugares.Clear();

            MostrarTablas(); // Actualiza las grillas
        }
        private void MostrarTablas()
        {
            string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ControlDeUsuarios.accdb";

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                // Mostrar TAREAS
                string consultaTareas = "SELECT * FROM Tareas";
                OleDbDataAdapter adaptadorTareas = new OleDbDataAdapter(consultaTareas, conexion);
                DataTable tablaTareas = new DataTable();
                adaptadorTareas.Fill(tablaTareas);
                dgvTareas.DataSource = tablaTareas;

                // Mostrar LUGARES
                string consultaLugares = "SELECT * FROM Lugares";
                OleDbDataAdapter adaptadorLugares = new OleDbDataAdapter(consultaLugares, conexion);
                DataTable tablaLugares = new DataTable();
                adaptadorLugares.Fill(tablaLugares);
                dgvLugares.DataSource = tablaLugares;
            }
        }

        public void Control()
        {
            if (txtLugares.Text !="" ||  txtTareas.Text != "")
            {
                btnAgregrar.Enabled = true;
            }
            else
            {
                btnAgregrar.Enabled = false;
            }
        }

        private void txtTareas_TextChanged(object sender, EventArgs e)
        {
            Control();
        }

        private void txtLugares_TextChanged(object sender, EventArgs e)
        {
            Control() ;
        }
    }
}
