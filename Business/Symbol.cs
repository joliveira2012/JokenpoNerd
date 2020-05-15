using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokenpo.Business
{
    public class Symbol
    {
        public static string Rock { get; set; } = "rock";
        public static string Paper { get; set; } = "paper";
        public static string Scissors { get; set; } = "scissors";
        public static string Lizard { get; set; } = "lizard";
        public static string Spock { get; set; } = "spock";

        public static bool IsValid(string symbol)
        {

            Console.WriteLine(Rock);
            string[] symbols = { Rock, Paper, Scissors, Lizard, Spock };
           return  Array.Exists(symbols, s => s.Equals(symbol));
        }
    }
}
