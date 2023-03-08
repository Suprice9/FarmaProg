using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_productos.Controlador
{
    internal class Datos
    {

        private int id;
        private string presentacion;
        private string descrip;
        private int stock;

        public int Stock { get => stock; set => stock = value; }
        public int Id { get => id; set => id = value; }
        public string Presentacion { get => presentacion; set => presentacion = value; }
        public string Descrip { get => descrip; set => descrip = value; }
    }

  
}
