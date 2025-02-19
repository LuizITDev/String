
class Program
{

    static void Main(string[] args)
    {
        var paragrafo = "   C# é uma linguaguem moderna e versátil, " +
                        "Com C# consigo desenvolver para Web, Desktop, Jogos,  " +
                        "Mobile, entre outros. ";

// Length conta tudo o que tem 
        var tamanho = paragrafo.Length;
        Console.WriteLine(tamanho);
// Empaty vazio
        var vazio = string.Empty;
        Console.WriteLine(vazio);
// ToLower, ToUpper
        var paragrafoMinusculo = paragrafo.ToLower();
        Console.WriteLine(paragrafoMinusculo);
        var paragrafoMaiusculo = paragrafo.ToUpper();
        Console.WriteLine(paragrafoMaiusculo);

// Split
        var frases = paragrafo.Split('.');
        Console.WriteLine(frases);

//Trim, TrimEnd, TrimStart
        var paragrafoTrim = paragrafo.Trim();
        Console.WriteLine(paragrafoTrim);
        var paragrafoTrimend = paragrafo.TrimEnd();
        Console.WriteLine(paragrafoTrimend);
        var paragrafoTrimStart = paragrafo.TrimStart();
        Console.WriteLine(paragrafoTrimStart);

// IsNullOrWhiteSpace
        var IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(paragrafo);
        Console.WriteLine(IsNullOrWhiteSpace);

// Replace
        var ParagrafoCsharp = paragrafo.Replace("C#", "C-sharp");
        Console.WriteLine(ParagrafoCsharp);

        Console.ReadKey();
    }
    
}