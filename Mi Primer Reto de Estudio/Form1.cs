using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;
using System.Data.SqlClient;

namespace Mi_Primer_Reto_de_Estudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.DimGray;
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.DimGray;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = default;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = default;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112, 0xf012, 0);
        }

        private void VenBuscar(Object Form2) 
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            Form Ven1 = Form2 as Form;
            Ven1.TopLevel = false;
            Ven1.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(Ven1);
            this.Contenedor.Tag = Ven1;
            Ven1.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VenBuscar(new VenBuscar());
        }

        private void VenUser(Object Form6)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            Form Ven1 = Form6 as Form;
            Ven1.TopLevel = false;
            Ven1.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(Ven1);
            this.Contenedor.Tag = Ven1;
            Ven1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VenUser(new VenUser());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Datos.OpenDB();
        }

        private void VenEditar(Object Form3)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            Form Ven1 = Form3 as Form;
            Ven1.TopLevel = false;
            Ven1.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(Ven1);
            this.Contenedor.Tag = Ven1;
            Ven1.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VenEditar(new VenEditar());
        }

        private void VenEliminar(Object Form5)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            Form Ven1 = Form5 as Form;
            Ven1.TopLevel = false;
            Ven1.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(Ven1);
            this.Contenedor.Tag = Ven1;
            Ven1.Show();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            VenEditar(new VenEliminar());
        }

        private void VenAgregar(Object Form4)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            Form Ven1 = Form4 as Form;
            Ven1.TopLevel = false;
            Ven1.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(Ven1);
            this.Contenedor.Tag = Ven1;
            Ven1.Show();
        }
        private void btnAgragar_Click(object sender, EventArgs e)
        {
            VenEditar(new VenAgregar());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
