using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntidadesCompartidas.Entidades
{
    public class Tripulada : Nave
    {
        [Required]
        public string Misiones { get; set; }
        [Required]
        public int Capacidad { get; set; }
        [Required]
        public string Orbita { get; set; }
        public bool Actividad { get; set; }
        [Required]
        public int PersonasABordo { get; set; }

        public Tripulada(int poten, int vel, string prop, string obj, int peso, Agencia agen, string Comb, string Nom, DateTime Despegue, string mision,int cap,string orbit,bool activ,int personas)
            :base(poten, vel, prop, obj, peso, agen, Comb, Nom,Despegue)
        {
            Misiones = mision;
            Capacidad = cap;
            Orbita = orbit;
            Actividad = activ;
            PersonasABordo = personas;
        }
        public Tripulada()
        {

        }

        public override string InfoAvanzadaNave()
        {
            string act = Actividad ? "Activa" : "Inactiva";
            return "Info Avanzada: " + "\nPotencia: " + this.Potencia + "\nVelocidad: " + this.Velocidad + "\nPeso: " + this.Peso + "\nSistema de propulsion: " + this.SistemaDePropulsion + "\nCombustible: " + this.Combustible +
                "\nMision: " + this.Misiones + "\nCapacidad de personas: " + this.Capacidad +"\nPersonas a bordo: "+this.PersonasABordo+"\nOrbita a"+ this.Orbita + "\nEstado: " + act;
        }

        public override string ObjetivoDeLaNave()
        {
            return this.Objetivo;
        }
    }
}
