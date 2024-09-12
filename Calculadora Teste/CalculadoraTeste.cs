namespace Calculadora.Teste
{
    public class CalculadoraTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4,calculadoraexemple.Calculadora.Somar(2, 2));
            Assert.Equal(2, calculadoraexemple.Calculadora.Subtrair(4, 2));
            Assert.Equal(4, calculadoraexemple.Calculadora.Vezes(2, 2));
            Assert.Equal(2, calculadoraexemple.Calculadora.Divisao(4, 2));

        }
    }
}