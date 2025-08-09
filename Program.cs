using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] votes = new string[10];

            Console.WriteLine("Vote for one of the following candidates: Angela, Stella, Faye");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Vote {i + 1}: ");
                votes[i] = Console.ReadLine().Trim().ToLower();
            }
            int angelaVotes = 0;
            int stellaVotes = 0;
            int fayeVotes = 0;

            foreach (string vote in votes)
            {
                if (vote == "angela")
                {
                    angelaVotes++;
                }
                else if (vote == "stella")
                {
                    stellaVotes++;
                }
                else if (vote == "faye")
                {
                    fayeVotes++;
                }
                else
                {
                    Console.WriteLine($"Invalid vote: {vote}. This vote will not be counted.");
                }
            }
            Console.WriteLine("\nVote Totals:");
            Console.WriteLine($"Angela: {angelaVotes} votes");
            Console.WriteLine($"Stella: {stellaVotes} votes");
            Console.WriteLine($"Faye: {fayeVotes} votes");

            if (angelaVotes > stellaVotes && angelaVotes > fayeVotes)
            {
                Console.WriteLine("The winner is Angela!");
            }
            else if (stellaVotes > angelaVotes && stellaVotes > fayeVotes)
            {
                Console.WriteLine("The winner is Stella!");
            }
            else if (fayeVotes > angelaVotes && fayeVotes > stellaVotes)
            {
                Console.WriteLine("The winner is Faye!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}
                