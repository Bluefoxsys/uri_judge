using System;

namespace conversao_implicita_e_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //conversao implícita de tipos

            float x = 4.5f;

            double y = x;

            Console.WriteLine(y);

            //casting

            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);

            //caso onde feito o casting há perda de informação

            double c;
            int d;

            c = 5.1;
            d = (int)c;

            Console.WriteLine(d);
        }
    }
}
