using System;

namespace CeasarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci una parola: ");
            string plaintext = Console.ReadLine();
            int key;
            CaesarCode ml;

            try
            {
                do
                {
                    Console.WriteLine("inserisci la chiave");
                    key = int.Parse(Console.ReadLine());
                } while (key < 0 || key > 25);

                ml = new CaesarCode(plaintext, key);
                Console.WriteLine($"Il testo cifrato è: {ml.CipherText}");

            }
            catch (Exception ex)
            {


                Console.WriteLine(ex.Message);
               
            }



            Console.ReadLine();
        }
    }
}
