using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia.Helper
{
    public class DataAccessHelper
    {
        /// <summary>Metodo para crear un DataSet y contener datos de la base de datos para encapsularlos en tablas. </summary>

        public static DataSet ExecuteDataSet(string store, string conexion, ParametersSql parameters)
        {
            DataSet dataset = null;
            try
            {
                using (var connection = new SqlConnection(conexion))
                {
                    connection.Open();
                    using(var command = new SqlCommand(store,connection))
                    {
                        foreach (SqlParameter parameter in parameters.Parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                        command.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        dataset = new DataSet();
                        adapter.Fill(dataset);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dataset;
        }
        /// <summary>Metodo para alterar algo en una base de datos </summary>
        public static int ExecuteNonQuery(string store, string conexion, ParametersSql parameters)
        {
            int resultado = -6;
            try
            {
                parameters.AddReturnParameter("@Retorno");
                using (var connection = new SqlConnection(conexion))
                {
                    connection.Open();
                    using (var command = new SqlCommand(store, connection))
                    {
                        foreach (SqlParameter parameter in parameters.Parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                        command.CommandType = CommandType.StoredProcedure;
                        command.ExecuteNonQuery();
                        resultado = (int)command.Parameters["@Retorno"].Value;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }
    }
}
