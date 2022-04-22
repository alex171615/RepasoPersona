using System;

namespace RepasoPersona.Core
{
    public class Cuenta:Abstraccion
    {
        public int CBU { get;  private set;}
        public Persona Cliente { get; set; }

        public Cuenta(int cbu, double saldo)
        {
            Cliente = new Persona();
            CBU = cbu;
            Saldo = saldo;
        }
    }
}