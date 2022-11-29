using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntidadesCompartidas.Entidades
{
    public abstract class Nave
    {
        public DateTime FechaDespegue { get; set; }
        public int Numero { get; set; }
        [Required]
        public int Potencia { get; set; }
        [Required]
        public int Velocidad { get; set; }
        [Required]
        public string SistemaDePropulsion { get; set; }
        [Required]
        public string Objetivo { get; set; }
        [Required]

        public int Peso { get; set; }
        [Required]
        public string Combustible { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public Agencia Firma { get; set; }


        public Nave(int poten,int vel,string prop,string obj,int peso, Agencia agen, string Comb,string Nom,DateTime Despegue)
        {
            this.Numero = 0;
            this.Velocidad = vel;
            this.SistemaDePropulsion = prop;
            this.Objetivo = obj;
            this.Peso = peso;
            this.Firma = agen;
            this.Combustible = Comb;
            this.Nombre = Nom;
            FechaDespegue = Despegue;
            this.Potencia = poten;
        }
        public Nave()
        {

        }

        public virtual string InfoNave()
        {
            return "Nave numero:" + Numero + "\nNombre de la nave: " + Nombre  + "\nDespego el: " + this.FechaDespegue.ToShortDateString() + "\nAgencia" + this.Firma.ToString();
        }

        public abstract string InfoAvanzadaNave();
        public abstract string ObjetivoDeLaNave();



    }

}
