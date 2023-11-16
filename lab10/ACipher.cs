using System;
namespace lab10
{
    public class ACipher : ICipher
    {
        public string Encode(string input)
        {
            char[] encryptedChars = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                char encryptedChar = (char)(currentChar + 1);
                encryptedChars[i] = encryptedChar;
            }
            return new string(encryptedChars);
        }
        public string Decode(string input)
        {
            char[] decryptedChars = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                char decryptedChar = (char)(currentChar - 1);
                decryptedChars[i] = decryptedChar;
            }
            return new string(decryptedChars);
        }
    }
}