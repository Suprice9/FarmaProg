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

namespace sistema_de_productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender , EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "Sendmessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wparam, int lparam);

        private void barratitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2_productos(); //cuando precione del boton de productos se abre el segundo form
            formulario.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3_clientes();
            formulario.Show();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            Form formulario = new Form4_ventas();
            formulario.Show();

        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            Form formulario = new Form5_compras();
            formulario.Show();
        }
    }
}
