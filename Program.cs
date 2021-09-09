using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string FraseDigitada, fraseComDislalia;
            
            Console.Write(" Você dizendo:"); 
            FraseDigitada = Console.ReadLine();
            fraseComDislalia = FraseDigitada.Replace("R", "L").Replace("r", "l");

            Console.WriteLine();
            
            Console.Write(" O Cebolinha Dizendo:");
            Console.WriteLine(fraseComDislalia);
            
        }
    }
}
