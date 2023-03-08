using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using sistema_de_productos.Modelo;
using sistema_de_productos.Controlador;

namespace sistema_de_productos
{
    public partial class Form2_productos : Form
    {
        Conexion conexion = new Conexion();
        public Form2_productos()
        {
            InitializeComponent();
        }

        class limpiar
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sucursales_Click(object sender, EventArgs e)
        {
            Form formulario = new Form6_sucursales();
            formulario.Show();
        }

        private void btn_buscar_product_Click(object sender, EventArgs e)
        {
            int Id= Convert.ToInt32(txtbox_id_buscar_product.Text);
            string  Presentacion = txtbox_presentacion_buscar_product.Text;
            string Descrip = txtbox_descripcion_buscar_product.Text;
            



            MySqlDataReader reader = null;

            MySqlCommand cmd = new MySqlCommand("select * from producto  where codigo = '" + Id + "'or nombreproduc = '" + Presentacion + "'",conexion.establecerConexion());

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            data_gv_listadoproduct.DataSource = tabla;
        }
    }
}
