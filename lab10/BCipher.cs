using System;
namespace lab10
{
    public class BCipher : ICipher
    {
        public string Encode(string input)
        {
            char[] characters = input.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                if (char.IsLetter(characters[i]))
                {
                    characters[i] = EncryptCharacter(characters[i]);
                }
            }
            return new string(characters);
        }
        public string Decode(string input)
        {
            char[] characters = input.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                if (char.IsLetter(characters[i]))
                {
                    characters[i] = DecryptCharacter(characters[i]);
                }
            }
            return new string(characters);
        }
        private char EncryptCharacter(char character)
        {
            char baseChar = char.IsUpper(character) ? 'A' : 'a';
            int position = character - baseChar;
            if (char.IsUpper(character))
            {
                int encryptedPosition = ('Z' - baseChar) - position;
                return (char)(baseChar + encryptedPosition);
            }
            else
            {
                int encryptedPosition = ('z' - baseChar) - position;
                return (char)(baseChar + encryptedPosition);
            }
        }
        private char DecryptCharacter(char character)
        {
            char baseChar = char.IsUpper(character) ? 'A' : 'a';
            if (char.IsUpper(character))
            {
                int position = ('Z' - baseChar) - (character - baseChar);
                int decryptedPosition = position;
                return (char)(baseChar + decryptedPosition);
            }
            else
            {
                int position = ('z' - baseChar) - (character - baseChar);
                int decryptedPosition = position;
                return (char)(baseChar + decryptedPosition);
            }
        }
    }
}
