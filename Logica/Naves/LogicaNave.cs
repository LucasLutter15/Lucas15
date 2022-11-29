using Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using EntidadesCompartidas.Entidades;
using Persistencia;
using Persistencia.Interfaces;
using System.Data;

namespace Logica.Naves
{
    public class LogicaNave : ILogicaNave
    {
        private readonly IPersistenciaNaves _persistencia;

        public LogicaNave(IPersistenciaNaves persistencia)
        {
            _persistencia = persistencia;
        }
        public string AltaNaveLanzadera(Nave nave)
        {
            var resultado = _persistencia.AltaNaveLanzadera(nave);
            switch (resultado)
            {
                case 1:
                    return "Agregado con exito";
                case -1:
                    return "No existe la agencia";
                case -2:
                    return "No existe el lanzador de energia";
                case -3:
                    return "ERROR";
                default:
                    return "No se pudo agregar";
            }
        }
        public string AltaNaveTripulada(Nave nave)
        {
            var resultado = _persistencia.AltaNaveTripulada(nave);
            switch (resultado)
            {
                case 1:
                    return "Agregado con exito";
                case -1:
                    return "No existe la agencia";
                case -2:
                    return "La cantidad de personas a bordo es mayor a la capacidad de la nave";
                case -3:
                    return "ERROR";
                default:
                    return "No se pudo agregar";
            }
        }
        public string AltaNaveNoTripulada(Nave nave)
        {
            var resultado = _persistencia.AltaNaveNoTripulada(nave);
            switch (resultado)
            {
                case 1:
                    return "Agregado con exito";
                case -1:
                    return "No existe la agencia";
                case -2:
                    return "No existe el codigo de motor";
                case -3:
                    return "NO existe el planeta";
                default:
                    return "No se pudo agregar";
            }
        }
        public List<Nave> CantidadDeNavesEnPlaneta(string planeta)
        {
            List<Nave> naves = new List<Nave>();
            var resultado = _persistencia.CantidadDeNavesEnPlaneta(planeta);
            if (resultado != null && resultado.Tables.Count > 0)
            {
                var rows = resultado.Tables[0].Rows;
                foreach (DataRow row in rows)
                {
                    naves.Add(CrearNaveNoTripulada(row));
                }
            }
            return naves;
        }


        public List<Nave> CantidadDeNavesLanzadas()
        {
            List<Nave> naves = new List<Nave>();
            var resultado = _persistencia.CantidadDeNavesLanzadas();
            if (resultado != null && resultado.Tables[0].Rows.Count > 0)
            {
                var rows = resultado.Tables[0].Rows;
                foreach (DataRow row in rows)
                {
                    var tipo = (int)row["Tipo"];
                    if(tipo==1)
                    {
                        naves.Add(CrearNaveLanzadera(row));
                    }
                    else if(tipo==2)
                    {
                        naves.Add(CrearNaveNoTripulada(row));
                    }
                    else if(tipo==3)
                    {
                        naves.Add(CrearNaveTripulada(row));
                    }
                }
            }
            return naves;
        }
        private NoTripulada CrearNaveNoTripulada(DataRow row)
        {
            return new NoTripulada()
            {
                Numero = (int)row["Numero"],
                Firma = new Agencia()
                {
                    Nombre = (string)row["Firma"]
                },
                Objetivo = (string)row["Objetivo"],
                Nombre = (string)row["Nombre"],
                Combustible = (string)row["Combustible"],
                Potencia = (int)row["Potencia"],
                Velocidad = (int)row["Velocidad"],
                FechaDespegue = (DateTime)row["FechaDespegue"],
                SistemaDePropulsion = (string)row["SistemaDePropulsion"],
                Peso = (int)row["Peso"],
                Empuje = (int)row["EmpujeN"],
                Camara = (bool)row["Camara"],
                Aterrizador = (string)row["Aterrizador"],
                Actividad = (bool)row["ActividadN"],
                TipoMotor = new Motor()
                {
                    CodFabrica = (string)row["CodFabricaM"]               
                },
                LugarDeEstudio = new Planeta()
                {
                    Nombre = (string)row["NombrePlaneta"],
                }
            };
        }
        private Tripulada CrearNaveTripulada(DataRow row)
        {
            return new Tripulada()
            {
                Numero = (int)row["Numero"],
                Firma = new Agencia()
                {
                    Nombre = (string)row["Firma"]
                },
                Objetivo = (string)row["Objetivo"],
                Nombre = (string)row["Nombre"],
                Combustible = (string)row["Combustible"],
                Potencia = (int)row["Potencia"],
                Velocidad = (int)row["Velocidad"],
                FechaDespegue = (DateTime)row["FechaDespegue"],
                SistemaDePropulsion = (string)row["SistemaDePropulsion"],
                Peso = (int)row["Peso"],
                Misiones = (string)row["Misiones"],
                Capacidad=(int)row["Capacidad"],
                Orbita=(string)row["Orbita"],
                Actividad=(bool)row["Actividad"],
                PersonasABordo=(int)row["PersonasABordo"]
            };
        }
        private VehiculoLanzadera CrearNaveLanzadera(DataRow row)
        {
            return new VehiculoLanzadera()
            {
                Numero = (int)row["Numero"],
                Firma = new Agencia()
                {
                    Nombre = (string)row["Firma"]
                },
                Objetivo = (string)row["Objetivo"],
                Nombre = (string)row["Nombre"],
                Combustible = (string)row["Combustible"],
                Potencia = (int)row["Potencia"],
                Velocidad = (int)row["Velocidad"],
                FechaDespegue = (DateTime)row["FechaDespegue"],
                SistemaDePropulsion = (string)row["SistemaDePropulsion"],
                Peso = (int)row["Peso"],
                Empuje = (int)row["Empuje"],
                Transporte = (int)row["Transporte"],
                LanzadorDeEnergia = new LanzadorDeEnergia()
                {
                    CodFabrica = (string)row["CodFabricaV"]
                }
            };
        }
        private Agencia CrearAgencia(DataRow row)
        {
            return new Agencia()
            {
                Nombre = (string)row["Nombre"],
                Pais = (string)row["Pais"]
            };
        }
        private Motor CrearMotor(DataRow row)
        {
            return new Motor()
            {
                CodFabrica = (string)row["CodFabrica"],
                Cantidad = (int)row["Cantidad"],
                Tipo = (string)row["Tipo"]
            };
        }
        private Planeta CrearPlaneta(DataRow row)
        {
            return new Planeta()
            {
                Nombre = (string)row["Nombre"],
                Informacion = (string)row["Informacion"],
                Distancia = (long)row["Distancia"]
            };
        }
        private LanzadorDeEnergia CrearLanzador(DataRow row)
        {
            return new LanzadorDeEnergia()
            {
                CodFabrica = (string)row["CodFabrica"],
                Peso = (int)row["Peso"],
                Tamaño = (int)row["Tamaño"]
            };
        }

        public DataSet PasajerosEnElEspacio()
        {
            var resultado = _persistencia.PasajerosEnElEspacio();
            return resultado;
        }
        public string SacarDeActividaUnaNave(int num, string tipo)
        {
            var resultado = _persistencia.SacarDeActividaUnaNave(num, tipo);
            switch (resultado)
            {
                case 1:
                    return "Agregado con exito";
                case -1:
                    return "No existe la nave";
                case -2:
                    return "La nave tiene pasajeros a bordo.";
                default:
                    return "ERROR";
            }
        }
        public string MandarHumanoALaTierra(int num,int cant)
        {
            var resultado = _persistencia.MandarHumanoALaTierra(num, cant);
            switch (resultado)
            {
                case 1:
                    return "Enviados con exito";
                case -1:
                    return "No existe el codigo de nave";
                case -2:
                    return "No hay tantas personas a bordo";
                default:
                    return "ERROR";
            }
        }
        public string MandarHumanoALaNave(int num,int cant)
        {
            var resultado = _persistencia.MandarHumanoANave(num, cant);
            switch (resultado)
            {
                case 1:
                    return "Enviados con exito";
                case -1:
                    return "No existe el codigo de nave";
                case -2:
                    return "Mayor a la capacidad de la nave";
                default:
                    return "ERROR";
            }
        }
        public Nave BuscarNave(int num)
        {
            Nave nave = null;
            var resultado = _persistencia.BuscarNave(num);
            if (resultado != null && resultado.Tables[0].Rows.Count > 0)
            {
                //var rows = resultado.Tables[0].Rows;
                var row = resultado.Tables[0].Rows[0];
                var tipo = (int)row["Tipo"];
                if (tipo == 1)
                {
                    nave = CrearNaveLanzadera(row);
                }
                else if (tipo == 2)
                {
                    nave = CrearNaveNoTripulada(row);
                }
                else if (tipo == 3)
                {
                    nave = CrearNaveTripulada(row);
                }
            }
            return nave;
        }
        public List<Nave> BuscarNavePorTipo(string tipo)
        {
            List<Nave> naves = new List<Nave>();
            var resultado = _persistencia.BuscarNavePorTipo(tipo);
            if(resultado!=null && resultado.Tables[0].Rows.Count>0)
            {
                if(tipo=="Tripulada")
                {
                    var rows = resultado.Tables[0].Rows;
                    foreach (DataRow row in rows)
                    {
                        naves.Add(CrearNaveTripulada(row));                        
                    }
                }
                if(tipo=="No Tripulada")
                {
                    var rows = resultado.Tables[0].Rows;
                    foreach (DataRow row in rows)
                    {
                        naves.Add(CrearNaveNoTripulada(row));
                    }
                }
                if(tipo=="Vehiculo Lanzadera")
                {
                    var rows = resultado.Tables[0].Rows;
                    foreach (DataRow row in rows)
                    {
                        naves.Add(CrearNaveLanzadera(row));
                    }
                }
            }
            return naves;
        }
        public List<Agencia> ListadoAgencias()
        {
            var resultado = _persistencia.ListadoAgencias();
            List<Agencia> agencias = new List<Agencia>();
            if (resultado != null && resultado.Tables[0].Rows.Count > 0)
            {
                var rows = resultado.Tables[0].Rows;
                foreach (DataRow row in rows)
                {
                    agencias.Add(CrearAgencia(row));
                }
            }
            return agencias;
        }
        public List<Planeta> ListadoPlanetas()
        {
            List<Planeta> planetas = new List<Planeta>();
            var resultado = _persistencia.ListadoPlanetas();
            if(resultado!=null&& resultado.Tables[0].Rows.Count>0)
            {
                var rows = resultado.Tables[0].Rows;
                foreach (DataRow row in rows)
                {
                    planetas.Add(CrearPlaneta(row));
                }
            }
            return planetas;
        }
        public List<Motor> ListadoMotores()
        {
            List<Motor> motores = new List<Motor>();
            var resultado = _persistencia.ListadoMotores();
            if(resultado!=null && resultado.Tables[0].Rows.Count>0)
            {
                var rows = resultado.Tables[0].Rows;
                foreach (DataRow row in rows)
                {
                    motores.Add(CrearMotor(row));

                }
            }
            return motores;
        }
        public List<LanzadorDeEnergia> ListadoLanzadores()
        {
            List<LanzadorDeEnergia> lanzadores = new List<LanzadorDeEnergia>();
            var resultado = _persistencia.ListadoLanzadores();
            if (resultado != null && resultado.Tables[0].Rows.Count > 0)
            {
                var rows = resultado.Tables[0].Rows;
                foreach (DataRow row in rows)
                {
                    lanzadores.Add(CrearLanzador(row));
                }
            }
            return lanzadores;
        }
    }
}

