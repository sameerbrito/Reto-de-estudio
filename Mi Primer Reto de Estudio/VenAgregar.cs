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
    public partial class VenAgregar : Form
    {
        public VenAgregar()
        {
            InitializeComponent();
        }

        private void VenAgregar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos.OpenDB();
            string INSERTAR = "INSERT INTO Mercancías (Descripcion,Existencia,Comentario,Status,NoEliminable) " +
                "VALUES (@Descripcion,@Existencia,@Comentario,@Status,@NoEliminable)";

            SqlCommand cmd1 = new SqlCommand(INSERTAR, Datos.OpenDB());

            cmd1.Parameters.AddWithValue("@Descripcion",Descripcion.Text);
            cmd1.Parameters.AddWithValue("@Existencia", Existencia.Text);
            cmd1.Parameters.AddWithValue("@Comentario", Comentario.Text);
            cmd1.Parameters.AddWithValue("@Status", Status.Text);
            cmd1.Parameters.AddWithValue("@NoEliminable", NoEliminable.Checked);

            cmd1.ExecuteNonQuery();
            MessageBox.Show("Los datos se agregaron exitosamente");
        }

        private void Descripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
