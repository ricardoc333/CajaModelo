using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaModelo
{
    public class Correlativo
    {
        public Correlativo() { }

        private int _id;
        private string _tipo;
        private int _valor;

        public int Id { get { return _id; } set { _id = value; } }
        public string Tipo { get { return _tipo; } set { _tipo = value; } }
        public int Valor { get { return _valor; } set { _valor = value; } }
    }
}
