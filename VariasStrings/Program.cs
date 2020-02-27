using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=1;
            string laugh = "ahahahah";
            string cringe = "yikes";
            string verbatim = @"\barras";
            string aspas = @"aspas""aspas";
            string soma= "ola "+"tudo bem, "+ "tudo fixe?";
            string mistura = "numero " + 1;
            string conc =$"numero {x}";
            string forma = String.Format("Nivel {1} : Masmorra {0}",1,"Lmao");

            Console.WriteLine(laugh);
            Console.WriteLine(cringe);
            Console.WriteLine(verbatim);
            Console.WriteLine(aspas);
            Console.WriteLine(soma);
            Console.WriteLine(mistura);
            Console.WriteLine(conc);
            Console.WriteLine(forma);
            Console.WriteLine("Fresh {0} and {1}","memes","fruit");
        }
    }
}
