using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaModelo
{
    public class Producto
    {
        public Producto() { }

        private int _id;
        private string _codigo;
        private string _barra;
        private string _descripcion;
        private int _cantidad;

        public int Id { get { return _id; } set { _id = value; } }
        public string Codigo { get { return _codigo; } set { _codigo = value; } }
        public string Barra { get { return _barra; } set { _barra = value; } }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public int Cantidad { get { return _cantidad; } set { _cantidad = value; } }
    }
}
