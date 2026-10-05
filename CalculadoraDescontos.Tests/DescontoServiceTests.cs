using CalculadoraDescontos.App;
using Xunit;

namespace CalculadoraDescontos.Tests;

public class DescontoServiceTests
{
    [Theory]
    [InlineData(2, "BRONZE")]
    [InlineData(7, "PRATA")]
    [InlineData(15, "OURO")]
    public void ObterCategoriaCliente_DeveRetornarCategoriaCorreta(
        int totalCompras, string categoriaEsperada)
    {
        var service = new DescontoService();

        var resultado = service.ObterCategoriaCliente(totalCompras);

        Assert.Equal(categoriaEsperada, resultado);
    }

    [Theory]
    [InlineData(100, 10, 90)]
    [InlineData(200, 20, 160)]
    [InlineData(50, 0, 50)]
    public void CalcularDescontoPorPercentual_DeveRetornarValorCorreto(
        int valorOriginal, int percentualDesconto, int valorEsperado)
    {
        var service = new DescontoService();

        var resultado = service.CalcularDescontoPorPercentual(
            valorOriginal, percentualDesconto);

        Assert.Equal(valorEsperado, resultado);
    }

    [Theory]
    [InlineData(20, false, true)]
    [InlineData(16, true, true)]
    [InlineData(17, false, false)]
    public void EValidoParaCupom_DeveRetornarResultadoCorreto(
        int idade, bool primeiraCompra, bool resultadoEsperado)
    {
        var service = new DescontoService();

        var resultado = service.EValidoParaCupom(
            idade, primeiraCompra);

        Assert.Equal(resultadoEsperado, resultado);
    }
}