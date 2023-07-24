using System.Globalization;

public class Program
{
    public static string CapitalizeSentence(string sentence)
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(sentence.ToLower());
    }

    public static void Main()
    {
        string originalSentence = "bU tasKI metHodla yAzmAliSiz";
        string capitalizedSentence = CapitalizeSentence(originalSentence);
        Console.WriteLine(capitalizedSentence);
    }
}