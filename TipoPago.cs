using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace CajaModelo
{
    public class TipoPago
    {
        public TipoPago() { }

        public TipoPago(int id, string descripcion)
        {
            _id = id;
            _descripcion = descripcion;
        }

        private int _id;
        private string _descripcion;

        public int Id { get { return _id; } set { _id = value; } }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
    }

    public class TipoPagoMapper
    {
        private SqlConnection _conexion;
        private SqlCommand _comando;
        private string _procedimiento;

        public BindingList<TipoPago> getTiposPago()
        {
            try
            {
                _conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cursocsharp"].ConnectionString);
                _procedimiento = "GET_TIPOPAGO";
                _conexion.Open();
                _comando = new SqlCommand(_procedimiento, _conexion);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader salida = _comando.ExecuteReader();
                BindingList<TipoPago> lista = new BindingList<TipoPago>();
                while(salida.Read())
                {
                    lista.Add(new TipoPago(salida.GetInt32(salida.GetOrdinal("ID")),
                        salida.GetString(salida.GetOrdinal("DESCRIPCION"))));
                }
                _conexion.Close();
                return lista;
            }
            catch
            {
                if (_conexion != null)
                {
                    if (_conexion.State == ConnectionState.Open)
                    {
                        _conexion.Close();
                    }
                }
                return null;
                //throw exc;
            }
        }

        public int setTipoPago(TipoPago tipoPago)
        {
            //throw new NotImplementedException();
            try
            {
                _conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cursocsharp"].ConnectionString);
                _procedimiento = "SET_TIPOPAGO";
                _conexion.Open();
                _comando = new SqlCommand(_procedimiento, _conexion);
                _comando.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter();
                paramId.Value = tipoPago.Id;
                paramId.SqlDbType = SqlDbType.Int;
                paramId.ParameterName = "ID";
                SqlParameter paramDescripcion = new SqlParameter();
                paramDescripcion.Value = tipoPago.Descripcion;
                paramDescripcion.SqlDbType = SqlDbType.VarChar;
                paramDescripcion.ParameterName = "DESCRIPCION";
                paramDescripcion.Size = 50;
                _comando.Parameters.Add(paramId);
                _comando.Parameters.Add(paramDescripcion);
                int filas = _comando.ExecuteNonQuery();
                _conexion.Close();
                return filas;
            }
            catch
            {
                if (_conexion != null)
                {
                    if (_conexion.State == ConnectionState.Open)
                    {
                        _conexion.Close();
                    }
                }
                return 0;
            }
        }
    }
}
