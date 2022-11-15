namespace NumbersInWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Please type number in words: ");
            WordsToNumbers wtn = new WordsToNumbers();
            s = Console.ReadLine();
            Console.WriteLine((s));
        }

        
    }
}