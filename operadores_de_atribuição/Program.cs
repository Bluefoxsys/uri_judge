using System;

namespace operadores_de_atribuição
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            // O "+=" Tambem serve pra contatenação cumulativa de strings
            s += "DEF";
            Console.WriteLine(s);

            //-----------------------------------------------------------------------------------

            //OPERADORES ARITMÉTICOS/ATRIBUIÇÃO

            int x = 10;
            x++;
            Console.WriteLine(x);

            int y = 10;
            y--;
            Console.WriteLine(y);

        }
    }
}
