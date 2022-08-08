using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Mi_Primer_Reto_de_Estudio
{
    public partial class VenBuscar : Form
    {
        public VenBuscar()
        {
            InitializeComponent();
        }

        private void VenBuscar_Load(object sender, EventArgs e)
        {
            Datos.OpenDB();

            dataGridView1.DataSource = LlenarTable();
        }

        public DataTable LlenarTable() 
        {
            Datos.OpenDB();
            DataTable dt = new DataTable();
            string Consulta = "SELECT * FROM Mercancías";
            SqlCommand cmd = new SqlCommand(Consulta, Datos.OpenDB());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
