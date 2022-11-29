using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCompartidas.Entidades
{
    public class LanzadorDeEnergia
    {
        public string CodFabrica { get; set; }
        public int Tamaño { get; set; }
        public int Peso { get; set; }
        public LanzadorDeEnergia(int tmño,int pso,string cod)
        {
            Tamaño = tmño;
            Peso = pso;
            CodFabrica = cod;
        }
        public LanzadorDeEnergia()
        {

        }
        public override string ToString()
        {
            return "Tamaño del Lanzador de energia: " + this.Tamaño + "\nPeso del Lanzador de energia: " + this.Peso;
        }

    }
}
