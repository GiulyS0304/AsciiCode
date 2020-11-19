using System;

namespace AsciiCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un valore numerico o alfanumerico da convertire in codice ASCII");
            char carattere = Convert.ToChar(Console.ReadLine());
            
            int number = carattere;
            // aggiunge 4 al numero decimale corrispondente della lettera iserita
            // number = number + 4;

            Console.WriteLine($"Il carattere digitato nella tabella ASCII cosrrisponde al numero: {number.ToString()}");
            string binario = Convert.ToString(number, 2).PadLeft(8, '0');

            Console.WriteLine($"Il carattere in codice binario corrisponde alla sequenza di bit {binario}");
            Console.ReadKey();
        }
    }
}
