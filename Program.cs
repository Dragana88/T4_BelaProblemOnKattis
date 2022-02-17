using System;

namespace T4_BelaProblemOnKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();                      // Read user input 
            int space = line.IndexOf(' ');                         // Finding if space is present within the string 
            int hands = int.Parse(line.Substring(0, space)) * 4;   // Converting to int by parsing from first element [0] and multiplyng by 4 to have a hand
            char suit = line[space + 1];                           // Adding space to remaning lines of user's input
            int points = 0;                                        // Declare variable for points 

            for (int i = 0; i < hands; i ++)
            {
                string s = Console.ReadLine();
                switch (s[0])
                {
                    case 'A':
                        points += 11;
                        break;
                    case 'K':
                        points += 4;
                        break;
                    case 'Q':
                        points += 3;
                        break;
                    case 'J':
                        if (s[1] == suit)
                            points += 20;
                        else
                            points += 2;
                        break;
                    case 'T':
                        points += 10;
                        break;
                    case '9':
                        if (s[1] == suit)
                            points += 14;
                        break;
                }
            }
            Console.WriteLine(points);
        }
    }
}
