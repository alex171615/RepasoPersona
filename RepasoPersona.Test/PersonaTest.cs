using System;
using Xunit;
using RepasoPersona.Core;

namespace RepasoPersona.Test
{
    public class PersonaTest
    {
        
        Persona Pepito{get;set;}
        
        public PersonaTest ()=> Pepito = new Persona("Pepito","Gomez",0);
        
        [Fact]
        public void Constructor()
        {
           
            Assert.Equal("Pepito",Pepito.Nombre);
            Assert.Equal("Gomez",Pepito.Apellido);
            Assert.Equal(0,Pepito.Efectivo);
        }
        
        [Fact]
        public void acreditarPositivo()
        {
        double esperado=1000;
        Pepito.Acreditar(1000);
        Assert.NotEqual(esperado,Pepito.Efectivo,3);  
      }
    }
}
