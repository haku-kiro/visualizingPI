using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace visualizingPI
{
    class Program
    {
        public static int[] readingPiPer(int num = 1000000) //default of 1,000,000
        {
            string path = @"piMillion.txt";
            string text = File.ReadAllText(path);
            string justRem = text.Substring(2, text.Length-2); //good to know that substring cuts from one and isnt a zero based index

            char[] charsOfPI = justRem.ToCharArray(); //create an array of chars with each digit of pi (up to a million)
            int[] countInstances = new int[10];
            for (int i = 0; i < num; i++)
            {
                switch (charsOfPI[i])
                {
                    case '0':
                        countInstances[0]++;
                        break;
                    case '1':
                        countInstances[1]++;
                        break;
                    case '2':
                        countInstances[2]++;
                        break;
                    case '3':
                        countInstances[3]++;
                        break;
                    case '4':
                        countInstances[4]++;
                        break;
                    case '5':
                        countInstances[5]++;
                        break;
                    case '6':
                        countInstances[6]++;
                        break;
                    case '7':
                        countInstances[7]++;
                        break;
                    case '8':
                        countInstances[8]++;
                        break;
                    case '9':
                        countInstances[9]++;
                        break;
                    default:
                        break;
                }
            }

            return countInstances;
           // Console.WriteLine(justRem);
        }

        static double[] percentageCount(int[] instances, int total)
        {
            double[] percentages = new double[10];

            for (int i = 0; i < percentages.Length; i++)
            {
                double instanceVal = instances[i];
                double totalVal = total;
                double math = instanceVal / totalVal * 100;

                percentages[i] = math;
            }

            return percentages;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of digits: ");
            string sAmount = Console.ReadLine();
            int amount;

            if (int.TryParse(sAmount, out amount)) //if parse succeeds
            {
                int[] instances = readingPiPer(amount);
                double[] percent = percentageCount(instances, amount);

                for (var i = 0; i < instances.Length; i++)
                {
                    Console.WriteLine("The number {0} occurs {1} times, with a percentage of: {2}%", i, instances[i].ToString(), percent[i]);
                }                
            }
            else
            {
                Console.WriteLine("Invalid input");
            }



            Console.ReadLine();

        }
    }
}
