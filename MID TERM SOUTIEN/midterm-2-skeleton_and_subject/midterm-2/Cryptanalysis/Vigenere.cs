using System;

namespace Cryptanalysis
{
public class Vigenere
{
    public const float FrenchIndexOfCoincidence = 0.0778F;
    private string Key;
    public Vigenere(string key)
    {
        this.Key = key;
    }

    public string Encrypt(string msg)
    {
        string a = "";
        int count = 0;
        int len = Key.Length;
        foreach (char c in msg)
        {
            if (count == len)
            {
                count = 0;
            }
            a += Tools.RotChar(c, Key[count]);
            count += 1;

        }

        return a;
    }

    public string Decrypt(string cypherText)
    {
        throw new NotImplementedException();
    }

    public static string GuessKeyWithLength(string cypherText, int keyLength)
    {
        throw new NotImplementedException();
    }
    
    public static float IndexOfCoincidence(string str)
    {
        throw new NotImplementedException();
    }

    public static int GuessKeyLength(string cypherText)
    {
        throw new NotImplementedException();
    }
    
    public static string GuessKey(string cypherText)
    {
        throw new NotImplementedException();
    }
}
}
