using System;
using RepasoPersona.Core;
using Xunit;

namespace RepasoPersona.Test
{
    public class PersonaTest
    {
        public Persona Pepito { get; set; }

        public PersonaTest() => Pepito = new Persona("Juan", "Gomez", 0);

        [Fact]
        public void Constructor()
        {
            Assert.Equal("Juan", Pepito.Nombre);
            Assert.Equal("Gomez", Pepito.Apellido);
            Assert.Equal(0, Pepito.Saldo);
        }

        [Fact]
        public void AcreditarPositivo()
        {
            double esperado = 1000;
            Pepito.Acreditar(esperado);
            
            Assert.Equal(esperado, Pepito.Saldo, 3);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-157.34)]
        public void AcreditarCeroONegativo(double monto)
        {
            var ex = Assert.Throws<ArgumentException>(() => Pepito.Acreditar(0));
            Assert.Equal("El monto tiene que ser mayor a cero.", ex.Message);
        }

        [Fact]
        public void Debitar()
        {
            double monto = 500.45;
            double debito = 135.45;
            Pepito.Acreditar(monto);
            Pepito.Debitar(debito);

            Assert.Equal(monto - debito, Pepito.Saldo, 2);
        }

        [Fact]
        public void DebitarInsuficiente()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => Pepito.Debitar(1000));
            Assert.Equal("El monto supera al efectivo.", ex.Message);
        }

        public Cuenta MercadoPago { get; set; } 
        public Cuenta Paypal { get; set; }
        
        [Fact]
        public double SumaCuentas()
        {
            MercadoPago = new Cuenta(1241, 400);
            Paypal = new Cuenta(31241, 787);
            return Pepito.SaldoCuentas;
        }
    }
}