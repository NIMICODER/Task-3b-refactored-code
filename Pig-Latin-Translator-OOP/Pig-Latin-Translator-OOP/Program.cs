using System;

namespace Pig_Latin_Translator_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Text to convert to Pig-Latin word: ");
            string text = Console.ReadLine();
            TranslateToPigLatin tpl = new TranslateToPigLatin();
            string pigLatin = tpl.TranslateToPigLat(text);
            Console.WriteLine($"Translation: {pigLatin}");
            Console.WriteLine();

            Console.WriteLine("Enter a Pig-Latin word to convert back English: ");
            string pigword = Console.ReadLine();
            TranslateBackToEnglish tbe = new TranslateBackToEnglish();
            string plainText = tbe.TranslateBackToEng(pigword);
            Console.WriteLine($"Translation: {plainText}");

        }

       
        
    }
}