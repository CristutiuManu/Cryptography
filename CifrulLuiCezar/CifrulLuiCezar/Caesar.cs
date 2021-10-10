using System.Security.Cryptography;

namespace CifrulLuiCezar
{
    public static class Caesar
    {
        public static string Encipher(string inputText, int key)
        {
            string output = string.Empty;
            foreach (char c in inputText)
            {
                output += Cipher(c, key);
            }
            
            return output;
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }
        
        private static char Cipher(char c, int key)
        {
            if (!char.IsLetter(c))
            {
                return c;
            }

            char d = char.IsUpper(c) ? 'A' : 'a';
            return (char) ((((c + key) - d) % 26) + d);
        }
    }
}