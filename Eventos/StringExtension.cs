using Microsoft.VisualBasic;

public static class StringExtension
{
    public static string InvertString(this string str)
    {
        var invertedStr = "";
        for(var i = str.Length-1; i >= 0; i--)
            invertedStr += str[i];

        return invertedStr;
    }

    public static string InvertString2(this string str)
    {
        char[] charArr = str.ToCharArray();
        Array.Reverse(charArr);
        return new string(charArr);
    }
}