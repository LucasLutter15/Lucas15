using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntidadesCompartidas.Entidades
{
    public class NoTripulada : Nave
    {

        [Required]
        public Motor TipoMotor { get; set; }
        [Required]
        public int Empuje { get; set; }
        [Required]
        public Planeta LugarDeEstudio { get; set; }
        public bool Camara { get; set; }
        [Required]
        public string Aterrizador { get; set; }
        public bool Actividad { get; set; }
        public NoTripulada(int poten, int vel, string prop, string obj, int peso, Agencia agen, string Comb, string Nom, DateTime Despegue, Motor mot, int emp, Planeta planet, bool cam, string aterriz, bool activ)
            : base(poten, vel, prop, obj, peso, agen, Comb, Nom, Despegue)
        {
            TipoMotor = mot;
            Empuje = emp;
            LugarDeEstudio = planet;
            Camara = cam;
            Aterrizador = aterriz;
            Actividad = activ;
        }
        public NoTripulada()
        {
        }
        public override string InfoAvanzadaNave()
        {
            string cama = Camara ? "\nTiene Camara" : "\nNo Tiene Camara";

            if (Actividad)
                cama = cama + "\nSe encuentra activa";
            else
                cama = cama + "\nNo esta en actividad";

            return "Info Avanzada: " + "\nPotencia: " + this.Potencia + "\nVelocidad: " + this.Velocidad + "\nPeso: " + this.Peso + "\nSistema de propulsion: " + this.SistemaDePropulsion + "\nCombustible: " + this.Combustible +
                "\nEmpuje: " + this.Empuje + "\nMotor" + this.TipoMotor.ToString() + "\nAterrizaje: " + this.Aterrizador + cama;
        }

        public override string ObjetivoDeLaNave()
        {
            return "Objetivo de la nave: " + this.Objetivo;
        }

        public string LocalizacionActual()
        {
            return "Se encuentra en: " + this.LugarDeEstudio.Nombre;
        }
        public string DemoraDeLlegadaAlPlaneta()
        {
            return "El tiempo de espera es: " + (this.LugarDeEstudio.Distancia / this.Velocidad);
        }
        public string Motorr()
        {
            return TipoMotor.ToString();
        }
    }
}
