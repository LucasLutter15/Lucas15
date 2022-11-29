using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCompartidas.Entidades
{
    public class Planeta
    {
        public long Distancia { get; set; }
        public string Nombre { get; set; }
        public string Informacion { get; set; }
        public Planeta()
        {

        }
        public override string ToString()
        {
            return "Planeta: " + this.Nombre + "\nInformacion: " + this.Informacion;
        }

    }
}
