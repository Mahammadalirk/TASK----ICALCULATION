namespace ICalculator
{
    internal interface ISalaryCalculator
    {
        string NumberOfDays { get; }
        string DailyWages { get; }
        string Salary { get; }

        void SalaryCalculate();
    }
}