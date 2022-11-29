using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntidadesCompartidas.Entidades
{
    public class VehiculoLanzadera : Nave
    {
        [Required]
        public int Empuje { get; set; }
        [Required]
        public LanzadorDeEnergia LanzadorDeEnergia { get; set; }
        [Required]
        public int Transporte { get; set; }
        public VehiculoLanzadera(int poten, int vel, string prop, string obj, int peso, Agencia agen, string Comb, string Nom, DateTime Despegue, int empuj, LanzadorDeEnergia Lanz, int Transp)
            : base(poten, vel, prop, obj, peso, agen, Comb, Nom, Despegue)
        {
            Empuje = empuj;
            LanzadorDeEnergia = Lanz;
            Transporte = Transp;
        }
        public VehiculoLanzadera()
        {

        }

        public override string InfoAvanzadaNave()
        {
            return "Info Avanzada: " + "\nPotencia: " + this.Potencia + "\nVelocidad: " + this.Velocidad + "\nPeso: " + this.Peso + "\nSistema de propulsion: " + this.SistemaDePropulsion + "\nCombustible: " + this.Combustible +
                "\nEmpuje: " + this.Empuje + "\nLanzador de energia: " + LanzadorDeEnergia.ToString() + "Transporte(kg): " + this.Transporte;
        }

        public override string ObjetivoDeLaNave()
        {
            return "Objetivo de la nave: " + this.Objetivo;
        }
    }
}
