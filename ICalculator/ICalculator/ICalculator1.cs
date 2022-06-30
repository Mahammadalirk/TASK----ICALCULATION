namespace ICalculator
{
    internal interface ICalculation
    {
        double FirstNumber { get; set; }
        string Process { get; set; }
        double SecondNumber { get; set; }
        string Result { get; }

        void Calculate();
    }
}