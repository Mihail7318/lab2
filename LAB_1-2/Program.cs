using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            double x;
            while(a){
            Console.Write("X: ");
            if(Double.TryParse(Console.ReadLine(),out x)){
            
            Console.WriteLine("F: "+ GetF(x));
            Console.ReadKey();
            a = false;
            }else{
            Console.WriteLine("Неверный ввод!!! ОШИБКА \n P.S. Введите десятичное или целое число НАПРИМЕР 15 или 15.36");
            Form1 form = new Form1();
            form.ShowDialog();
            }
            }
        }

        public static double GetF(double x) {
            double F, p, p1;
            p = Math.Cos(x) - ((Math.Pow(Math.Sin(x * x), 4) + (x * x)) / x) - ((Math.Pow(x, 4) + 0.96 * x - 1) / (Math.Pow(x, 4) + Math.Pow(x, 3) - 2.37));
            p1 = Math.Pow(Math.Sin(x), 2) + Math.Pow(p, 3) + Math.Sqrt(x);
            F = Math.Pow(p1, 4);
            return Math.Round(F, 3);
        }
    }
}
