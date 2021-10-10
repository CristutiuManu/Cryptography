using System;

namespace CifrulLuiCezar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your text: ");
            string UserString = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Enter your key: ");
            int key = int.Parse(Console.ReadLine());  
            
            Console.WriteLine("\n");
            
            Console.WriteLine("Encrypted Data");  
            
            string cipherText = Caesar.Encipher(UserString, key);  
            Console.WriteLine(cipherText);  
            Console.Write("\n");
            
            Console.WriteLine("Decrypted Data:");  
  
            string t = Caesar.Decipher(cipherText, key);  
            Console.WriteLine(t);  
            Console.Write("\n");  

        }
    }
}