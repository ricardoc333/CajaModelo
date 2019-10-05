using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaModelo
{
    public class Cliente
    {
        public Cliente() { }

        private int _id;
        private string _nombre;
        private int _RUT;
        private string _digitoVerificador; 
        private string _regionFiscal;
        private string _comunaFiscal;
        private string _ciudadFiscal;
        private string _direccionFiscal;
        private int _telefono;
        private string _correo;
        private List<ListaPrecios> _listas;

        public int Id { get { return _id; } set { _id = value; } }

        public string Nombre { get { return _nombre; } set { _nombre = value; } }

        public int RUT { get { return _RUT; } set { _RUT = value; } }

        public string DigitoVerificador { get { return _digitoVerificador; } set { _digitoVerificador = value; } }

        public string RegionFiscal { get { return _regionFiscal; } set { _regionFiscal = value; } }

        public string ComunaFiscal { get { return _comunaFiscal; } set { _comunaFiscal = value; } }

        public string CiudadFiscal { get { return _ciudadFiscal; } set { _ciudadFiscal = value; } }

        public string DireccionFiscal { get { return _direccionFiscal; } set { _direccionFiscal = value; } }

        public int Telefono { get { return _telefono; } set { _telefono = value; } }

        public string Correo { get { return _correo; } set { _correo = value; } }

        public List<ListaPrecios> Listas { get { return _listas; } set { _listas = value; } }
    }
}
