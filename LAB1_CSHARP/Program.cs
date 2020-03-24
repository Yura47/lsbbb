using System;
namespace LAB1_CSHARP
{
    public class Program
    {
        static public double Perimetr(int x1, int y1, int x2, int y2, int x3, int y3 )
        {
            double a = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double b = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double c = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            double p = a + b + c;
            return p;
        }
        static public double Ploscha(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            double a = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double b = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double c = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c)) ;
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть координату x1 ");
            string S1 = Console.ReadLine();
            int x1 = int.Parse(S1);
            Console.WriteLine("Введiть координату y1 ");
            string S2 = Console.ReadLine();
            int y1 = int.Parse(S2);
            Console.WriteLine("Введiть координату x2 ");
            string S3 = Console.ReadLine();
            int x2 = int.Parse(S3);
            Console.WriteLine("Введiть координату y2 ");
            string S4 = Console.ReadLine();
            int y2 = int.Parse(S4);
            Console.WriteLine("Введiть координату x3 ");
            string S5 = Console.ReadLine();
            int x3 = int.Parse(S5);
            Console.WriteLine("Введiть координату y3 ");
            string S6 = Console.ReadLine();
            int y3 = int.Parse(S6);
           
            double P = Perimetr(x1,y1,x2,y2,x3,y3);
            double S = Ploscha(x1, y1, x2, y2, x3, y3);
            Console.WriteLine("P = "+P.ToString() + " , S = "+S.ToString()+" ;");
        }
    }
}
