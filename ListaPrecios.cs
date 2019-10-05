using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaModelo
{
    public class ListaPrecios
    {
        public ListaPrecios() { }

        private int _id;
        private string _descripcion;
        private BindingList<DetalleListaPrecios> _detalles;

        public int Id { get { return _id; } set { _id = value; } }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public BindingList<DetalleListaPrecios> Detalles { get { return _detalles; } set { _detalles = value; } }
    }
}
