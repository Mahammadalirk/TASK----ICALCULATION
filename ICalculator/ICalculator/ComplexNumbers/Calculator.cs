using My.Calculator.Tests.CalculatorComplex;

namespace ComplexNumbers
{
    internal class ICalculator : ICalculator<Complex<double>>
    {
        Complex<double> ICalculator<Complex<double>>.Add(Complex<double> complex1, Complex<double> complex2)
        {
            throw new System.NotImplementedException();
        }

        Complex<double> ICalculator<Complex<double>>.Multiply(Complex<double> complex1, Complex<double> complex2)
        {
            throw new System.NotImplementedException();
        }

        Complex<double> ICalculator<Complex<double>>.Subtracht(Complex<double> complex1, Complex<double> complex2)
        {
            throw new System.NotImplementedException();
        }
    }
}