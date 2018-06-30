using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.Leilao.Tests
{
    [TestClass]
    public class PalindromoTest
    {
        [TestMethod]
        public void DeveEntenderPalindromoCenario1()
        {
            //Cenário
            string frase = "Socorram-me subi no onibus em Marrocos";

            //Ação
            bool condition = Palindromo.EhPalindromo(frase);

            //Validação
            Assert.IsTrue(condition, frase);
        }

        [TestMethod]
        public void DeveEntederPalindromoCenario2()
        {
            //Cenário
            string frase = "Anotaram a data da maratona";

            //Ação
            bool condition = Palindromo.EhPalindromo(frase);

            //Validação
            Assert.IsTrue(condition, frase);
        }

        [TestMethod]
        public void DeveFalharPalindromoCenario1()
        {
            //Cenário
            string frase = "Anotaram as datas das maratonas";

            //Ação
            bool condition = Palindromo.EhPalindromo(frase);

            //Validação
            Assert.IsFalse(condition, frase);
        }
    }
}
