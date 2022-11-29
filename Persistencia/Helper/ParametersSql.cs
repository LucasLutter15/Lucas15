using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntidadesCompartidas.Entidades;

namespace Persistencia.Helper
{
    public class ParametersSql
    {
        public List<SqlParameter> Parameters { get; set; }
        /// <summary>Constructo de list de parametrosql </summary>
        public ParametersSql()
        {
            Parameters = new List<SqlParameter>();
        }

        /// <summary>Agregar SqlParameter int </summary>
        public void AddIntParameters(string parameters,int value)
        {
            SqlParameter parameter = new SqlParameter(parameters,SqlDbType.Int);
            parameter.Value = value;
            Parameters.Add(parameter);
        }
        /// <summary>Agregar SqlParameter String </summary>
        public void AddStringParameters(string parameters, int largo, string value)
        {
            SqlParameter parameter = new SqlParameter(parameters,SqlDbType.VarChar,largo);
            parameter.Value = value;
            Parameters.Add(parameter);
        }
        /// <summary>Agregar SqlParameter double </summary>
        public void AddDoubleParameters(string parameters, double value)
        {
            SqlParameter parameter = new SqlParameter(parameters, SqlDbType.BigInt);
            parameter.Value = value;
            Parameters.Add(parameter);
        }
        /// <summary>Agregar SqlParameter return, para recibir la respuesta de la base de datos. </summary>
        public void AddReturnParameter(string parameters)
        {
            SqlParameter parameter = new SqlParameter(parameters, SqlDbType.Int);
            parameter.Direction = ParameterDirection.ReturnValue;
            Parameters.Add(parameter);
        }
    }
}
