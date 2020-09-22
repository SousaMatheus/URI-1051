using System;
using System.Globalization;

namespace URI_1051
{
    class Program
    {
        static void Main(string[] args)
        {
           double renda, imposto, dif ;
                      
           renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           if (renda < 2000.0){
               Console.WriteLine("Isento");
           }
           else if (renda > 2000.0 && renda <= 3000.0){
               dif = renda - 2000.0;
               imposto = (dif * 1.08) - dif;
               Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
           }
           else if (renda > 3000.0 && renda <= 4500.0){
               dif = renda - 3000.0;
               imposto =  (dif * 1.18) - dif + 80.00;//imposto 8% sobre 1000
               Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
           }
           else {
               dif = renda - 4500.0;
               imposto = (dif * 1.28) - dif + 350.00;
               Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
           }           
        }
    }
}
