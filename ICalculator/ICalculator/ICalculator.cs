namespace My.Calculator.Tests.CalculatorComplex
{
    internal interface ICalculator<T>
    {
        Complex<double> Add(Complex<double> complex1, Complex<double> complex2);
        Complex<double> Subtracht(Complex<double> complex1, Complex<double> complex2);
        Complex<double> Multiply(Complex<double> complex1, Complex<double> complex2);
    }
}