using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaModelo
{
    public class Documento
    {
        public Documento() { }

        private int _id;
        private DateTime _fechaEmision;
        private DateTime _fechaVencimiento;
        private Correlativo _correlativo;
        private Cliente _cliente;
        private BindingList<DetalleDocumento> _detalles;
        private BindingList<CondicionPago> _condiciones;
        private TipoPago _tipoPago;
        private Despacho _direccionDespacho;
        private TipoDocumento _tipoDocumento;

        public int Id { get { return _id; } set { _id = value; } }
        public DateTime FechaEmision { get { return _fechaEmision; } set { _fechaEmision = value; } }
        public DateTime FechaVencimiento { get { return _fechaVencimiento; } set { _fechaVencimiento = value; } }
        public Correlativo Correlativo { get { return _correlativo; } set { _correlativo = value; } }
        public Cliente Cliente { get { return _cliente; } set { _cliente = value; } }
        public BindingList<DetalleDocumento> Detalles { get { return _detalles; } set { _detalles = value; } }
        public BindingList<CondicionPago> Condiciones { get { return _condiciones; } set { _condiciones = value; } }
        public TipoPago TipoPago { get { return _tipoPago; } set { _tipoPago = value; } }
        public Despacho DireccionDespacho { get { return _direccionDespacho; } set { _direccionDespacho = value; } }
        public TipoDocumento TipoDocumento { get { return _tipoDocumento; } set { _tipoDocumento = value; } }
    }
}
