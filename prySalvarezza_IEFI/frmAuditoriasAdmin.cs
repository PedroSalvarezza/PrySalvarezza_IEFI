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
    public partial class frmAuditoriasAdmin : Form
    {
        private string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\ControlDeUsuarios.accdb";
        public frmAuditoriasAdmin()
        {
            InitializeComponent();
        }

        private void frmAuditoriasAdmin_Load(object sender, EventArgs e)
        {
            CargarRegistros();
        }
        
        private void CargarRegistros()
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    string consulta = "SELECT * FROM Registros ORDER BY idRegistro DESC"; // ordena para ver primero los más recientes
                    OleDbDataAdapter adapter = new OleDbDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvMostrar.DataSource = dt;

                    // Opcional: ajustar columnas para mejor vista
                    dgvMostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvMostrar.ReadOnly = true;
                    dgvMostrar.AllowUserToAddRows = false;
                    dgvMostrar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar registros: " + ex.Message);
            }
        }

    }
}
