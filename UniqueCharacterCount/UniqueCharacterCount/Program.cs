using System.Linq;

namespace UniqueCharacterCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string quatrian = "The Moving Finger writes; and having writ,\nMoves on: nor all your Piety nor Wit\nShall lure it back to cancel half a Line,\nNor all your Tears wash out a Word of it.";
            Console.WriteLine(quatrian);
            var grouped = quatrian.ToLower().ToCharArray().GroupBy(q => q);
            Console.WriteLine("\ngrouped whith linq");
            foreach (var group in grouped)
            {
                Console.WriteLine(group.Key + " " + group.Count());
            }

            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            foreach (char c in quatrian.ToLower())
            {
                if (!keyValuePairs.TryAdd(c, 1))
                {
                    keyValuePairs[c] += 1;
                }
            }

            Console.WriteLine("\ngrouped whith Dictionary");
            foreach (var c in keyValuePairs)
            {
                Console.WriteLine(c);
            }
        }
    }
}