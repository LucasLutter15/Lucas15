using EntidadesCompartidas.Entidades;
using Persistencia.Helper;
using Persistencia.Interfaces;
using System.Data;

namespace Persistencia.Naves
{
    public class PersistenciaNaves : IPersistenciaNaves
    {
/// <summary>Metodo Para Crear Nave Lanzadera en base de datos </summary>
        public int AltaNaveLanzadera(Nave nave)
        {
            ParametersSql parameters = new ParametersSql();
            parameters.AddStringParameters("@Firma",30, nave.Firma.Nombre);
            parameters.AddStringParameters("@Objetivo",100, nave.Objetivo);
            parameters.AddStringParameters("@Nombre",30, nave.Nombre);
            parameters.AddStringParameters("@Combustible",30, nave.Combustible);
            parameters.AddIntParameters("@Potencia", nave.Potencia);
            parameters.AddIntParameters("@Velocidad", nave.Velocidad);
            parameters.AddStringParameters("@SistemaDePropulsion", 50, nave.SistemaDePropulsion);
            parameters.AddIntParameters("@Peso", nave.Peso);
            parameters.AddIntParameters("@Empuje", ((VehiculoLanzadera)nave).Empuje);
            parameters.AddIntParameters("@Transporte", ((VehiculoLanzadera)nave).Transporte);
            parameters.AddStringParameters("@CodFabrica", 3, ((VehiculoLanzadera)nave).LanzadorDeEnergia.CodFabrica);
            return DataAccessHelper.ExecuteNonQuery("CrearNaveLanzadera", Conexion.STR, parameters);
        }
        /// <summary>Metodo Para Crear Nave Tripulada en base de datos </summary>
        public int AltaNaveTripulada(Nave nave)
        {
            ParametersSql parameters = new ParametersSql();
            parameters.AddStringParameters("@Firma", 30, nave.Firma.Nombre);
            parameters.AddStringParameters("@Objetivo", 100, nave.Objetivo);
            parameters.AddStringParameters("@Nombre", 30, nave.Nombre);
            parameters.AddStringParameters("@Combustible", 30, nave.Combustible);
            parameters.AddIntParameters("@Potencia", nave.Potencia);
            parameters.AddIntParameters("@Velocidad", nave.Velocidad);
            parameters.AddStringParameters("@SistemaDePropulsion", 50, nave.SistemaDePropulsion);
            parameters.AddIntParameters("@Peso", nave.Peso);
            parameters.AddStringParameters("@Misiones", 30, ((Tripulada)nave).Misiones);
            parameters.AddIntParameters("@Capacidad",((Tripulada)nave).Capacidad);
            parameters.AddStringParameters("@Orbita", 3, ((Tripulada)nave).Orbita);
            parameters.AddIntParameters("@Personas", ((Tripulada)nave).PersonasABordo);
            return DataAccessHelper.ExecuteNonQuery("CrearNaveTripulada", Conexion.STR, parameters);
        }
        /// <summary>Metodo Para Crear Nave No Tripulada en base de datos </summary>
        public int AltaNaveNoTripulada(Nave nave)
        {
            ParametersSql parameters = new ParametersSql();
            parameters.AddStringParameters("@Firma", 30, nave.Firma.Nombre);
            parameters.AddStringParameters("@Objetivo", 100, nave.Objetivo);
            parameters.AddStringParameters("@Nombre", 30, nave.Nombre);
            parameters.AddStringParameters("@Combustible", 30, nave.Combustible);
            parameters.AddIntParameters("@Potencia", nave.Potencia);
            parameters.AddIntParameters("@Velocidad", nave.Velocidad);
            parameters.AddStringParameters("@SistemaDePropulsion", 50, nave.SistemaDePropulsion);
            parameters.AddIntParameters("@Peso", nave.Peso);
            parameters.AddDoubleParameters("@Empuje", ((NoTripulada)nave).Empuje);
            parameters.AddStringParameters("@Aterrizador",30, ((NoTripulada)nave).Aterrizador);
            parameters.AddStringParameters("@CodFabrica", 3, ((NoTripulada)nave).TipoMotor.CodFabrica);
            parameters.AddStringParameters("@NombrePlaneta", 30, ((NoTripulada)nave).LugarDeEstudio.Nombre);
            return DataAccessHelper.ExecuteNonQuery("CrearNaveNoTripulada", Conexion.STR, parameters);
        }
        /// <summary>Metodo Para agarrar una tabla con la cantidad de naves en un planeta desde la base de datos </summary>
        public DataSet CantidadDeNavesEnPlaneta(string planeta)
        {
            ParametersSql parameters = new ParametersSql();
            parameters.AddStringParameters("@Planeta", 30, planeta);
            return DataAccessHelper.ExecuteDataSet("CantidadDeNavesEnPlaneta", Conexion.STR, parameters);
        }
        /// <summary>Metodo Para agarrar una tabla con la cantidad de naves lanzadas desde la base de datos </summary>
        public DataSet CantidadDeNavesLanzadas()
        {
            return DataAccessHelper.ExecuteDataSet("CantidadDeNavesLanzadas", Conexion.STR, new ParametersSql());
        }
        /// <summary>Metodo para conseguir la cantidad de pasajeros en el espacio </summary>
        public DataSet PasajerosEnElEspacio()
        {
            return DataAccessHelper.ExecuteDataSet("PasajeroEnElEspacio", Conexion.STR, new ParametersSql());
        }
        /// <summary>Metodo Para mandar humano a la tierra y actualizarlo en la base de datos </summary>

        public int MandarHumanoALaTierra(int num, int cant)
        {
            ParametersSql parameters = new ParametersSql();
            parameters.AddIntParameters("@Numero", num);
            parameters.AddIntParameters("@Cantidad", cant);
            return DataAccessHelper.ExecuteNonQuery("MandarHumanoALaTierra", Conexion.STR, parameters);
        }
        /// <summary>Metodo Para Sacar de actividad una nave y actualizarlo en base de datos </summary>
        public int SacarDeActividaUnaNave(int num,string tipo)
        {
            ParametersSql parameters = new ParametersSql();
            parameters.AddIntParameters("@Numero", num);
            parameters.AddStringParameters("@TripuladaoNoTripulada",20, tipo);
            return DataAccessHelper.ExecuteNonQuery("SacarDeActividaUnaNave", Conexion.STR, parameters);
        }
        /// <summary>Metodo Para mandar humano a nave y actualizarlo en la base de datos </summary>
        public int MandarHumanoANave(int num, int cant)
        {
            ParametersSql parameters = new ParametersSql();
            parameters.AddIntParameters("@Numero", num);
            parameters.AddIntParameters("@Cantidad", cant);
            return DataAccessHelper.ExecuteNonQuery("MandarHumanoANave", Conexion.STR, parameters);
        }
        /// <summary>Metodo Para buscar nave en la base de datos </summary>
        public DataSet BuscarNave(int num)
        {
            ParametersSql parameters = new ParametersSql();
            parameters.AddIntParameters("@Numero", num);
            return DataAccessHelper.ExecuteDataSet("BuscarNave", Conexion.STR, parameters);
        }
        /// <summary>Metodo Para buscar naves por tipo en la base de datos devuelve una tabla </summary>
        public DataSet BuscarNavePorTipo(string tipo)
        {
            ParametersSql parameters = new ParametersSql();
            parameters.AddStringParameters("@Tipo",20, tipo);
            return DataAccessHelper.ExecuteDataSet("BuscarNavePorTipo", Conexion.STR, parameters);
        }
        /// <summary>Metodo para traer una lista de agencias desde  la base de datos </summary>
        public DataSet ListadoAgencias()
        {
            return DataAccessHelper.ExecuteDataSet("ListadoAgencias", Conexion.STR, new ParametersSql());
        }
        /// <summary>Metodo para traer una lista de planetas desde  la base de datos </summary>
        public DataSet ListadoPlanetas()
        {
            return DataAccessHelper.ExecuteDataSet("ListadoPlanetas", Conexion.STR, new ParametersSql());
        }
        /// <summary>Metodo para traer una lista de motores desde  la base de datos </summary>
        public DataSet ListadoMotores()
        {
            return DataAccessHelper.ExecuteDataSet("ListadoMotores", Conexion.STR, new ParametersSql());
        }
        /// <summary>Metodo para traer una lista de lanzadores desde  la base de datos </summary>
        public DataSet ListadoLanzadores()
        {
            return DataAccessHelper.ExecuteDataSet("ListadoLanzadores", Conexion.STR, new ParametersSql());
        }
    }
}
