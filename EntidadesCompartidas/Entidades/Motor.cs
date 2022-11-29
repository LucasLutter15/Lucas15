using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCompartidas.Entidades
{
    public class Motor
    {
        public string CodFabrica { get; set; }

        public int Cantidad { get; set; }
        public string Tipo { get; set; }
        public Motor(int cant,string cod,string tip)
        {
            Cantidad = cant;
            CodFabrica = cod;
            Tipo = tip;

        }
        public Motor(string cod)
        {
            CodFabrica = cod;
        }
        public Motor()
        {

        }
        public override string ToString()
        {
            return "Cantidad de motores: " + this.Cantidad + "\nTipo de motor: " + this.Tipo;
        }
    }
}
