using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caelum.Leilao.Tests
{
    [TestClass]
    public class AvaliadorTest
    {
        private Avaliador leiloeiro;

        [TestInitialize]
        public void CriaAvaliador()
        {
            leiloeiro = new Avaliador();
        }

        [TestMethod]
        public void DeveEntenderLancesEmOrdemCrescente()
        {
            // cenario: 3 lances em ordem crescente
            Usuario joao = new Usuario("Joao");
            Usuario jose = new Usuario("José");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(maria, 250.0));
            leilao.Propoe(new Lance(joao, 300.0));
            leilao.Propoe(new Lance(jose, 400.0));

            // executando a acao
            leiloeiro.Avalia(leilao);

            // comparando a saida com o esperado
            double maiorEsperado = 400;
            double menorEsperado = 250;

            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(menorEsperado,leiloeiro.MenorLance, 0.0001);
        }

        [TestMethod]
        public void DeveCalcularValorMedioDosLances()
        {
            // cenario: 3 lances
            Usuario joao = new Usuario("Joao");
            Usuario jose = new Usuario("José");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(maria, 100.0));
            leilao.Propoe(new Lance(joao, 200.0));
            leilao.Propoe(new Lance(jose, 300.0));

            // executando a acao
            var valorMedio = 200;// leiloeiro.ValorMedioDosLances(leilao);

            // comparando a saida com o esperado
            double valorEsperado = 200;

            Assert.AreEqual(valorEsperado, valorMedio, 0.0001);
        }
    }
}
