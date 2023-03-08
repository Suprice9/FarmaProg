using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_productos
{
    public partial class Form5_compras : Form
    {
        public Form5_compras()
        {
            InitializeComponent();
        }

        private void GB_datoscompra_Enter(object sender, EventArgs e)
        {

        }

        private void btn_menu_principal_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
        }
    }
}
