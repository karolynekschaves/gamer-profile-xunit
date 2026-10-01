using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using GamerProfile.App;

namespace GamerProfile.Tests
{
    public class PerfilJogadorServiceTests
    {
        private readonly PerfilJogadorService _service;

        public PerfilJogadorServiceTests()
        {
            _service = new PerfilJogadorService();
        }

        [Fact]
        public void GerarTagUsuario_DeveRetornarTagFormatadaCorretamente()
        {
            // Arrange
            string nickname = "Aragorn";
            string codigo = "1042";

            // Act
            string resultado = _service.GerarTagUsuario(nickname, codigo);

            // Assert
            Assert.Equal("Aragorn#1042", resultado);
        }

        [Fact]
        public void CalcularXPTotal_DeveSomarXPDasFasesEAplicarBonusDe100()
        {
            // Arrange
            int xpFase1 = 200;
            int xpFase2 = 300;
            int valorEsperado = 600; // 200 + 300 + 100 de bônus

            // Act
            int resultado = _service.CalcularXPTotal(xpFase1, xpFase2);

            // Assert
            Assert.Equal(valorEsperado, resultado);
        }

        [Fact]
        public void EEligivelParaRanked_DeveValidarElegibilidadeCorretamente()
        {
            // Act & Assert
            // Jogador com nível igual ou superior a 15 deve ser elegível (True)
            Assert.True(_service.EEligivelParaRanked(15));
            Assert.True(_service.EEligivelParaRanked(20));

            // Jogador com nível abaixo de 15 NÃO deve ser elegível (False)
            Assert.False(_service.EEligivelParaRanked(14));
            Assert.False(_service.EEligivelParaRanked(1));
        }
    }
}