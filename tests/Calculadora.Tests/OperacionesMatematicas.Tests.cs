using Calculadora;

namespace Calculadora.Tests;

public class OperacionesMatematicasTests
{
    private readonly OperacionesMatematicas _operacionesMatematicas = new();

    [Fact]
    public void Sumar_DosPositivos_RetornaLaSuma()
    {
        //Arrange
        var operacionesMatematicas = new OperacionesMatematicas();
        int a = 3,
            b = 6;

        //Act
        double resultado = operacionesMatematicas.Sumar(a, b);

        //Assert
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void Sumar_NegativoMasPositivo_RetornaValorCorrecto()
    {
        var operacionesMatematicas = new OperacionesMatematicas();
        int a = -2,
            b = 6;

        double resultado = _operacionesMatematicas.Sumar(a, b);

        Assert.Equal(4, resultado);
    }

    [Fact]
    public void Sumar_CeroMasCero_RetornaCero()
    {
        int a = 0,
            b = 0;

        double resultado = _operacionesMatematicas.Sumar(a, b);

        Assert.Equal(0, resultado);
    }

    [Fact]
    public void Restar_DosPositivos_RetornaLaResta()
    {
        //Arrange
        var operacionesMatematicas = new OperacionesMatematicas();
        int a = 8,
            b = 3;

        //Act
        double resultado = operacionesMatematicas.Restar(a, b);

        //Assert
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Restar_NegativoMenosPositivo_RetornaValorCorrecto()
    {
        var operacionesMatematicas = new OperacionesMatematicas();
        int a = -2,
            b = 6;

        double resultado = _operacionesMatematicas.Restar(a, b);

        Assert.Equal(-8, resultado);
    }

    [Fact]
    public void Restar_CeroMenosCero_RetornaCero()
    {
        int a = 0,
            b = 0;

        double resultado = _operacionesMatematicas.Restar(a, b);

        Assert.Equal(0, resultado);
    }
}
