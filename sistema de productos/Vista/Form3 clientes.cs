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

namespace sistema_de_productos
{
    public partial class Form3_clientes : Form
    {
        Conexion con = new Conexion();
        public Form3_clientes()
        {
            InitializeComponent();
        }

        private void Form3_clientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string laboratorio = txtLaboratorio.Text;
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            string consulta = ("Insert into proveedores (laboratorio,codigo,direccion,telefono) values ('" + laboratorio + "','" + codigo + "','" + direccion + "','" + telefono + "'");

            MySqlCommand cmd = new MySqlCommand(consulta,con.establecerConexion());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha insertado exitoxamente" + laboratorio);


        } 

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
