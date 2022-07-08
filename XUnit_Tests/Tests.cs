using Test_Calculator;

namespace XUnit_Tests;

public class Tests
{

    [Fact]
    public void Test_Int_DivideByZero()
    {
        var calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.DivInt(4, 0));

    }

    [Fact]
    public void Test_Double_DivideByZero()
    {
        Calculator calc = new Calculator();
        var res = calc.DivDouble(5.0, 0.0);

        Assert.True(double.IsInfinity(res));

    }

    [Fact]
    public void Test_Double_DivideByZero_ThrownException()
    {
        var calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Div(35.0, 0.0));

    }

    [Fact]
    public void Test_Multiple_DivideByZero()
    {
        var calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Div(35, 1, 5, 0));

    }


    [Theory]
    [InlineData(148.5, 36.9, 185.4)]
    [InlineData(250, 50, 300)]
    [InlineData(-250, -50, -300)]
    [InlineData(-250, 50, -200)]
    public void Test_Add_TwoValues(double n1, double n2, double expected)
    {
        var calc = new Calculator();
        double res = calc.Add(n1, n2);
        Assert.Equal(expected, res);
    }


    [Theory]
    [InlineData(new double[]{145, 20, 60, 19, 25}, 269)]
    [InlineData(new double[] { -300, -30, -10, -15 }, -355)]
    [InlineData(new double[] { -300, -30, 10, 15 }, -305)]
    [InlineData(new double[] { 300, -30, -10, -15 }, 245)]
    public void Test_Add_MultipleValues(double[] n, double expected)
    {
        var calc = new Calculator();
        double res = calc.Add(n);
        Assert.Equal(expected, res);
    }

    [Theory]
    [InlineData(126, 36, 90)]
    [InlineData(-250, -50, -200)] /* (-200) - (-50) */
    [InlineData(250, -50, 300)] /* 250 - (-50) */
    [InlineData(-250, 50, -300)] /* (-250) - 50  */
    public void Test_Subtract_TwoValues(double n1, double n2, double expected)
    {
        var calc = new Calculator();
        double res = calc.Sub(n1, n2);
        Assert.Equal(expected, res);
    }

    [Theory]
    [InlineData(new double[] { 180, 35, 15, 10, 6}, 114)]
    [InlineData(new double[] { -180, -35, -15, -10, -6 }, -114)]
    [InlineData(new double[] { 180, -35, -15, -10, -6 }, 246)]
    [InlineData(new double[] { -180, -35, 15, 10, 6 }, -176)]
    [InlineData(new double[] { 180, 35, -15, -10, 6 }, 164)]
    public void Test_Subtract_MultipleValues(double[] n, double expected)
    {
        var calc = new Calculator();
        double res = calc.Sub(n);
        Assert.Equal(expected, res);
    }


    [Theory]
    [InlineData(25, 3, 75)]
    [InlineData(-25, 3, -75)]
    [InlineData(3.6, 2.6, 9.360000000000001)]
    public void Test_Multiply_TwoValues(double n1, double n2, double expected)
    {
        var calc = new Calculator();
        double res = calc.Mult(n1, n2);
        Assert.Equal(expected, res);
    }


    [Theory]
    [InlineData(new double[] { 15, 6, 2, 9, 3 }, 4860)]
    [InlineData(new double[] { -15, 6, 2, 9, 3 }, -4860)]
    [InlineData(new double[] { 1.2, 2.5, 1.3, 0.3, 1.6 }, 1.8720000000000003)]
    [InlineData(new double[] { 15, 6, 2, 9, 0 }, 0)]
    public void Test_Multiply_MultipleValues(double[] n, double expected)
    {
        var calc = new Calculator();
        double res = calc.Mult(n);
        Assert.Equal(expected, res);
    }

    [Theory]
    [InlineData(75, 3, 25)]
    [InlineData(-75, 3, -25)]
    [InlineData(8.2, 2.2, 3.7272727272727266)]
    public void Test_Divide_TwoValues(double n1, double n2, double expected)
    {
        var calc = new Calculator();
        double res = calc.Div(n1, n2);
        Assert.Equal(expected, res);
    }


    [Theory]
    [InlineData(new double[] { 120, 4, 3, 5 }, 2)]
    [InlineData(new double[] { -120, 4, 3, 5 }, -2)]
    [InlineData(new double[] { 900, 3, 3, 5, 2 }, 10)]
    [InlineData(new double[] { 48.8, 4.2, 2.6, 3.3 }, 1.3542013542013542)]
    public void Test_Divide_MultipleValues(double[] n, double expected)
    {
        var calc = new Calculator();
        double res = calc.Div(n);
        Assert.Equal(expected, res);
    }


    [Theory]
    [InlineData(160, 6, 4)]
    [InlineData(160, 8, 0)]
    [InlineData(120, 9, 3)]
    public void Test_Remainder(int dividend, int divisor, int expected)
    {
        var calc = new Calculator();
        int res = calc.Remainder(dividend, divisor);
        Assert.Equal(expected, res);
    }

    [Theory]
    [InlineData(5, 120)]
    [InlineData(6, 720)]
    [InlineData(8, 40320)]
    public void Test_Factorial(double n, double expected)
    {
        var calc = new Calculator();
        double res = calc.Fact(n);
        Assert.Equal(expected, res);
    }

    [Fact]
    public void Test_Factorial_NegativeNumbers()
    {
        var calc = new Calculator();
        Assert.Throws<Exception>(() => calc.Fact(-4));

    }



}
