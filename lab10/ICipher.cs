using System;
namespace lab10
{
    internal interface ICipher
    {
        String Encode(String input);
        String Decode(String input);
    }
}
