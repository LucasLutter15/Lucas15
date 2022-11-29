using EntidadesCompartidas.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Logica.Interfaces
{
    public interface ILogicaNave
    {
        /// <summary>Metodo Para Crear Nave Lanzadera en base de datos </summary>
        public string AltaNaveLanzadera(Nave nave);
        /// <summary>Metodo Para Crear Nave  Tripulada en base de datos </summary>
        public string AltaNaveTripulada(Nave nave);

        /// <summary>Metodo Para Crear Nave  Tripulada en base de datos </summary>
        public string AltaNaveNoTripulada(Nave nave);
        /// <summary>Metodo Para agarrar una tabla con la cantidad de naves en un planeta desde la base de datos </summary>
        public List<Nave> CantidadDeNavesEnPlaneta(string planeta);
        /// <summary>Metodo Para agarrar una tabla con la cantidad de naves lanzadas desde la base de datos </summary>
        public List<Nave> CantidadDeNavesLanzadas();

        public DataSet PasajerosEnElEspacio();

        /// <summary>Metodo Para Sacar de actividad una nave y actualizarlo en base de datos </summary>
        public string SacarDeActividaUnaNave(int num, string tipo);
        /// <summary>Metodo Para mandar humano a la tierra y actualizarlo en la base de datos </summary>
        public string MandarHumanoALaTierra(int num, int cant);
        /// <summary>Metodo Para mandar humano a nave y actualizarlo en la base de datos </summary>
        public string MandarHumanoALaNave(int num, int cant);
        /// <summary>Metodo Para buscar nave en la base de datos </summary>
        public Nave BuscarNave(int num);
        /// <summary>Metodo Para buscar naves por tipo en la base de datos devuelve una tabla </summary>
        public List<Nave> BuscarNavePorTipo(string tipo);
        /// <summary>Metodo para traer una lista de agencias desde  la base de datos </summary>
        public List<Agencia> ListadoAgencias();

        /// <summary>Metodo para traer una lista de lanzadores desde  la base de datos </summary>

        public List<LanzadorDeEnergia> ListadoLanzadores();

        /// <summary>Metodo para traer una lista de motores desde  la base de datos </summary>

        public List<Motor> ListadoMotores();
        /// <summary>Metodo para traer una lista de planetas desde  la base de datos </summary>
        public List<Planeta> ListadoPlanetas();
    }
}
