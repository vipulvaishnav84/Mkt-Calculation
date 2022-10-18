using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mkt_Calculation
{
   public static class mktcalculationcls
    {

        public const double DeltaH = 83.14472;
        public const double GasConstantR = 0.008314472;
        public const double MinusDeltaH = -83.14472;
        public const double CalculateNumerator = 10000;
        public const double Minusone = -1;

        public static float CelsiustoKelvin(float celsius)
        {
            float c =celsius + float.Parse("273.15");
            return c;
        }

        public static float KelvintoCelsius(float Kelvin)
        {
            float k = Kelvin - float.Parse("273.15");
            return k;
        }

        public static double CalculationOfDenominator(double KelvinTemerature)
        {
            double a = GasConstantR * KelvinTemerature;
            double b = MinusDeltaH;
            double c = b / a;
            double d = Math.Exp(c);
            return d; 
        }

        public static List<float> mktreading = new List<float>();

        public static void addmktreading(float datareading)
        {
           mktreading.Add(datareading);
          
        }
    }

}
