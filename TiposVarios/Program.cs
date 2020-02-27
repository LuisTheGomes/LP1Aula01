using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int numero=1;
            uint dank=2U;
            char wtf = '\u01E2';
            char letra = 'A';

            Console.WriteLine(numero);
            Console.WriteLine(dank);
            Console.WriteLine(wtf);
            Console.WriteLine(letra);
        }
    }
}
