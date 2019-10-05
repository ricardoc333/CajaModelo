using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaModelo
{
    public class DetalleListaPrecios
    {
        public DetalleListaPrecios() { }

        private int _id;
        private ListaPrecios _listaPrecios;
        private Producto _producto;
        private decimal _precio;

        public int Id { get { return _id; } set { _id = value; } }
        public ListaPrecios ListaPrecios { get { return _listaPrecios; } set { _listaPrecios = value; } }
        public Producto Producto { get { return _producto; } set { _producto = value; } }
        public decimal Precio { get { return _precio; } set { _precio = value; } }
    }
}
