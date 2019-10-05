using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaModelo
{
    public class DetalleDocumento
    {
        public DetalleDocumento() { }

        private int _id;
        private Documento _documento;
        private Producto _producto;
        private TipoDescuento _tipoDescuento;
        private decimal _descuento;
        private ListaPrecios _listaPrecios;
        private decimal _precio;
        private int _cantidad;

        public int Id { get { return _id; } set { _id = value; } }
        public Documento Documento { get { return _documento; } set { _documento = value; } }
        public Producto Producto { get { return _producto; } set { _producto = value; } }
        public TipoDescuento TipoDescuento { get { return _tipoDescuento; } set { _tipoDescuento = value; } }
        public decimal Descuento { get { return _descuento; } set { _descuento = value; } }
        public ListaPrecios ListaPrecios { get { return _listaPrecios; } set { _listaPrecios = value; } }
        public decimal Precio { get { return _precio; } set { _precio = value; } }
        public int Cantidad { get { return _cantidad; } set { _cantidad = value; } }
    }
}
