using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaModelo
{
    public class Despacho
    {
        public Despacho() { }

        private int _id;
        private Cliente _cliente;
        private string _region;
        private string _comuna;
        private string _ciudad;
        private string _direccion;
        private int _telefono;
        private string _correo;
        private string _horario;

        public int Id { get { return _id; } set { _id = value; } }
        public Cliente Cliente { get { return _cliente; } set { _cliente = value; } }
        public string Region { get { return _region; } set { _region = value; } }
        public string Comuna { get { return _comuna; } set { _comuna = value; } }
        public string Ciudad { get { return _ciudad; } set { _ciudad = value; } }
        public string Direccion { get { return _direccion; } set { _direccion = value; } }
        public int Telefono { get { return _telefono; } set { _telefono = value; } }
        public string Correo { get { return _correo; } set { _correo = value; } }
        public string Horario { get { return _horario; } set { _horario = value; } }
    }
}
