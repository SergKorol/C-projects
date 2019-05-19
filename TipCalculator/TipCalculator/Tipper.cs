using System;
namespace TipCalculator
{
    public class Tipper
    {
        public double Amount { get; set; }

        public double CalculateTip(double precentage) 
        {
            return Amount*precentage/100; 
        }

        public double CalculateTip()
        {
            return CalculateTip(15.0);
        }

        public double Divvy(int visitors)
        {
            return Amount / visitors;
        }
    }
}
