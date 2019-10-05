using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CajaModelo
{
    [DataContract]
    public class CondicionPago
    {
        public CondicionPago() { }

        public CondicionPago(int id, string descripcion, int dias) {
            _id = id;
            _descripcion = descripcion;
            _dias = dias;
        }

        private int _id;
        private string _descripcion;
        private int _dias;

        [DataMember]
        public int Id { get { return _id; } set { _id = value; } }
        [DataMember]
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        [DataMember]
        public int Dias { get { return _dias; } set { _dias = value; } }
    }

    /*
    public class CondicionPagoMapper
    {
        private SqlConnection _conexion;
        private SqlCommand _comando;
        private string _procedimiento;

        public BindingList<CondicionPago> getCondicionesPago()
        {
            try
            {
                _conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cursocsharp"].ConnectionString);
                _procedimiento = "GET_CONDICIONPAGO";
                _conexion.Open();
                _comando = new SqlCommand(_procedimiento, _conexion);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader salida = _comando.ExecuteReader();
                BindingList<CondicionPago> lista = new BindingList<CondicionPago>();
                while (salida.Read())
                {
                    lista.Add(new CondicionPago(salida.GetInt32(salida.GetOrdinal("ID")),
                        salida.GetString(salida.GetOrdinal("DESCRIPCION")), salida.GetInt32(salida.GetOrdinal("DIAS"))));
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

        public int setCondicionPago(CondicionPago condicionPago)
        {
            //throw new NotImplementedException();
            try
            {
                _conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cursocsharp"].ConnectionString);
                _procedimiento = "SET_CONDICIONPAGO";
                _conexion.Open();
                _comando = new SqlCommand(_procedimiento, _conexion);
                _comando.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter();
                paramId.Value = condicionPago.Id;
                paramId.SqlDbType = SqlDbType.Int;
                paramId.ParameterName = "ID";
                SqlParameter paramDescripcion = new SqlParameter();
                paramDescripcion.Value = condicionPago.Descripcion;
                paramDescripcion.SqlDbType = SqlDbType.VarChar;
                paramDescripcion.ParameterName = "DESCRIPCION";
                paramDescripcion.Size = 50;
                SqlParameter paramDias = new SqlParameter();
                paramDias.Value = condicionPago.Id;
                paramDias.SqlDbType = SqlDbType.Int;
                paramDias.ParameterName = "DIAS";
                _comando.Parameters.Add(paramId);
                _comando.Parameters.Add(paramDescripcion);
                _comando.Parameters.Add(paramDias);
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
    */
}
