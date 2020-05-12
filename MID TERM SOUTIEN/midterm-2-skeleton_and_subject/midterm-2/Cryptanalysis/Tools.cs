using System;

namespace Cryptanalysis
{
public static class Tools
{
    public static int Modulus(int a, int b)
    {
        if (b < 0)
            b = -b;
        
        var mod = a % b;
        return mod < 0 ? b + mod : mod;
    }

    public static int LetterIndex(char c)
    {
        int tempo = -1;
        string alpha1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string alpha2 = "abcdefghijklmnopqrstuvwxyz";
        for (int i = 0; i < alpha1.Length; ++i)
        {
            if (alpha1[i] == c)
            {
                tempo = i;
            }
        }

        for (int j = 0; j < alpha2.Length; ++j)
        {
            if (alpha2[j] == c)
            {
                tempo = j;
            }
        }
        
        return tempo;
    }
    
    public static char RotChar(char c, int n)
    {
        throw new NotImplementedException();
    }

    public static int[] Histogram(string str)
    {
        throw new NotImplementedException();
    }
    
    public static string FilterLetters(string str)
    {
        throw new NotImplementedException();
    }

    public static string Extract(string str, int start, int step)
    {
        throw new NotImplementedException();
    }
}
}
