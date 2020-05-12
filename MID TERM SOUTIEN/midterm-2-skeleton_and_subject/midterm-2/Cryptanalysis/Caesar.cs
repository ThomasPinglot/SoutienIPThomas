using System;
using System.ComponentModel.DataAnnotations;

namespace Cryptanalysis
{
public class Caesar
{
    private int Key;
    public Caesar(int key)
    {
        this.Key = key;
    }

    public string Encrypt(string msg)
    {
        string a = "";
        foreach (char c in msg)
        {
            a += Tools.RotChar(c, Key);
        }

        return a;
    }

    public string Decrypt(string cypherText)
    {
        string a = "";
        foreach (char c in cypherText)
        {
            a += Tools.RotChar(c, -Key);
        }

        return a;
    }

    public static int GuessKey(string cypherText)
    {
        int[] list = Tools.Histogram(cypherText);
        int max = 0;
        int count = 0;
        int occ = 0;
        foreach (int x in list)
        {

            if (x > max)
            {
                occ = count;
                max = x;
            }
            count += 1;
        }

        return occ - 5;



    }
}
}