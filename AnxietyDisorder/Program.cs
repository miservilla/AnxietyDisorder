using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnxietyDisorder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this program will help you complete the GAD-7 anxiety questionnaire.\n\n"
                + "Use the following responses to answer ALL 7 questions:\n"
                + "0 = Not at all, 1 = Several days, 2 = More than half the days, 3 = Nearly every day.\n\n"
                + "Over the past 2 weeks, how often have you been bothered by the following problems:\n");
            int Item1 = GetValue("Feeling nervous, anxious, or on edge? ");
            int Item2 = GetValue("Not being able to stop or control worrying? ");
            int Item3 = GetValue("Worrying too much about different things? ");
            int Item4 = GetValue("Having trouble relaxing? ");
            int Item5 = GetValue("Being so restless that it is hard to sit still? ");
            int Item6 = GetValue("Becoming easily annoyed or irritable? ");
            int Item7 = GetValue("Feeling afraid, as if something awful might happen? ");

            int totalScore = (Item1 + Item2 + Item3 + Item4 + Item5 + Item6 + Item7);
            Console.ForegroundColor = System.ConsoleColor.Red;

            switch (totalScore)
            {

                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    {
                        Console.WriteLine("\nMinimal anxiety.");
                        break;
                    }
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    {
                        Console.WriteLine("\nMild, probably subclinical anxiety, and monitoring is recommended.");
                        break;
                    }
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                    {
                        Console.WriteLine("\nModerate, possible clinically significant anxiety, and further evaluation and treatment (if needed) are recommended.");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("\nSevere, probably clinically significant anxiety, and treatment is probably warranted.");
                        break;

                    }
            }
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();

        }

        private static int GetValue(string label)
        {
            int value;
            while (true)
            {
                Console.Write(label);
                string input = Console.ReadLine();
                if ((int.TryParse(input, out value)) && value >= 0 && value <= 3)
                {
                    return value;
                }
                else
                {
                    Console.ForegroundColor = System.ConsoleColor.Red;
                    Console.WriteLine("Input error, try again!)");
                    Console.ForegroundColor = System.ConsoleColor.White;
                }
            }
        }
    }
}
