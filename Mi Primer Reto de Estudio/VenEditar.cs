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
    public partial class VenEditar : Form
    {
        public VenEditar()
        {
            InitializeComponent();
        }

        private void VenEditar_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id_Mercancía.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Descripcion.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Existencia.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Comentario.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Status.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                NoEliminable.Checked = dataGridView1.CurrentRow.Cells[5].ValueType.IsValueType;

            }
            catch 
            { 

            }
        }
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Datos.OpenDB();
            string EDITAR = "UPDATE Mercancías SET Descripcion=@Descripcion,Existencia=@Existencia," +
                "Comentario=@Comentario,Status=@Status,NoEliminable=@NoEliminable WHERE Id_Mercancía=@Id_Mercancía";

            SqlCommand cmd3 = new SqlCommand(EDITAR, Datos.OpenDB());

            cmd3.Parameters.AddWithValue("@Id_Mercancía", Id_Mercancía.Text);
            cmd3.Parameters.AddWithValue("@Descripcion", Descripcion.Text);
            cmd3.Parameters.AddWithValue("@Existencia", Existencia.Text);
            cmd3.Parameters.AddWithValue("@Comentario", Comentario.Text);
            cmd3.Parameters.AddWithValue("@Status", Status.Text);
            cmd3.Parameters.AddWithValue("@NoEliminable", NoEliminable.Checked);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Datos actualizados exitosamente");

            dataGridView1.DataSource = LlenarTable();
        }

        private void Descripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
