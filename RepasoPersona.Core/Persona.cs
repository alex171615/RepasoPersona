using System;
using System.Collections.Generic;
using System.Linq;

namespace RepasoPersona.Core
{
    public class Persona:Abstraccion
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public override double Saldo => base.Saldo + SaldoCuentas;
        public double SaldoCuentas => Cuentas.Sum(x => x.Saldo);
        public List<Cuenta> Cuentas { get; set;}
        public Persona() => Saldo = 0;
        public Persona(string nombre, string apellido, double efectivo)
        {
            Cuentas = new List<Cuenta>();
            Nombre = nombre;
            Apellido = apellido;
            Saldo = efectivo;
        } 
    }
}