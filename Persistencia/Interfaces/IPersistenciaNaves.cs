using EntidadesCompartidas.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Persistencia.Interfaces
{
    public interface IPersistenciaNaves
    {
        /// <summary>Metodo Para Crear Nave Lanzadera en base de datos </summary>
        public int AltaNaveLanzadera(Nave nave);
        /// <summary>Metodo Para Crear Nave Tripulada en base de datos </summary>
        public int AltaNaveTripulada(Nave nave);
        /// <summary>Metodo Para Crear Nave No Tripulada en base de datos </summary>
        public int AltaNaveNoTripulada(Nave nave);
        /// <summary>Metodo Para agarrar una tabla con la cantidad de naves en un planeta desde la base de datos </summary>
        public DataSet CantidadDeNavesEnPlaneta(string planeta);
        /// <summary>Metodo para conseguir la cantidad de pasajeros en el espacio </summary>
        public DataSet PasajerosEnElEspacio();

    /// <summary>Metodo Para agarrar una tabla con la cantidad de naves lanzadas desde la base de datos </summary>
        public DataSet CantidadDeNavesLanzadas();

        /// <summary>Metodo Para mandar humano a la tierra y actualizarlo en la base de datos </summary>
        public int MandarHumanoALaTierra(int num, int cant);
        /// <summary>Metodo Para Sacar de actividad una nave y actualizarlo en base de datos </summary>

        public int SacarDeActividaUnaNave(int num, string tipo);
        /// <summary>Metodo Para mandar humano a nave y actualizarlo en la base de datos </summary>
        public int MandarHumanoANave(int num, int cant);
        /// <summary>Metodo Para buscar nave en la base de datos </summary>
        public DataSet BuscarNave(int num);
        /// <summary>Metodo Para buscar naves por tipo en la base de datos devuelve una tabla </summary>

        public DataSet BuscarNavePorTipo(string tipo);
        /// <summary>Metodo para traer una lista de agencias desde  la base de datos </summary>

        public DataSet ListadoAgencias();
        /// <summary>Metodo para traer una lista de planetas desde  la base de datos </summary>

        public DataSet ListadoPlanetas();
        /// <summary>Metodo para traer una lista de motores desde  la base de datos </summary>

        public DataSet ListadoMotores();
        /// <summary>Metodo para traer una lista de lanzadores desde  la base de datos </summary>

        public DataSet ListadoLanzadores();
    }
}
