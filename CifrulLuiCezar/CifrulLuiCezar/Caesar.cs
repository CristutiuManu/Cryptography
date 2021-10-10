using System.Linq;
using System.Security.Cryptography;

namespace CifrulLuiCezar
{
    public static class Caesar
    {
        public static string Encipher(string inputText, int key)
        {
            return inputText.Aggregate(string.Empty, (current, c) => current + Cipher(c, key));
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