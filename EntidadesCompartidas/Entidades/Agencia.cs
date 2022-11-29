using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCompartidas.Entidades
{
    public class Agencia
    {

        public string Nombre { get; set; }
        public string Pais { get; set; }
        public Agencia(string nom,string pais)
        {
            Nombre = nom;
            Pais = pais;
        }
        public Agencia()
        {

        }
        public override string ToString()
        {
            return "Agencia: " + Nombre + "\nPais: " + Pais;
        }
    }
}
