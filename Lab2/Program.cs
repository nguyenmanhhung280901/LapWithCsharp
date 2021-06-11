using System;

namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("SIN Validator");
            Console.WriteLine("===============");
            
            while (true)
            {
                Console.Write("SIN (0 to quit):");
                var sin = Console.ReadLine();
                if (sin != null && sin.Equals("0"))
                {
                    Console.WriteLine("Heve a nice day!");
                    break;
                }
                else
                {
                    Console.WriteLine(CheckValidSin(sin) ? "This is valid SIN." : "This is not a valid SIN.");
                }
            }
            {
                var sin = Console.ReadLine();
                if (sin != null && sin.Equals("0"))
                {
                    Console.WriteLine("Heve a nice day!");
                }
                else
                {
                    if (CheckValidSin(sin))
                    {
                    
                    }
                }
            }

            Console.WriteLine(CheckValidSin("193456787"));
        }

        public static bool CheckValidSin(string sin)
        {
            
            int lastNumber;
            var totalEvenLineNumber = 0;
            var totalOddLineNumber = 0;
                
            var sinInCharArray = sin.ToCharArray();
            int[] numberOfSin = new int[9];
            int currentIndexOfNumberArray = 0;
            for (int i = 0; i < sinInCharArray.Length; i++)
            {
                if (sinInCharArray[i].ToString().Trim().Length == 0)
                {
                    continue;
                }

                numberOfSin[currentIndexOfNumberArray] = Convert.ToInt32(sinInCharArray[i].ToString());
                currentIndexOfNumberArray++;
            }

            lastNumber = numberOfSin[currentIndexOfNumberArray - 1];
            for (int i = 0; i < numberOfSin.Length - 1; i++) 
            {
                if ((i + 1) % 2 != 0)
                {
                    totalOddLineNumber += numberOfSin[i];
                }
                else
                {
                    var doubleOfNumber = numberOfSin[i] * 2;
                    var charArray = doubleOfNumber.ToString().ToCharArray();
                    for (int j = 0; j < charArray.Length; j++)
                    {
                        
                        totalEvenLineNumber += Convert.ToInt32(charArray[j].ToString());
                    }
                }
                
            }

            // Console.WriteLine($"Last number = {lastNumber}");
            // Console.WriteLine($"Total number of line odd = {totalOddLineNumber}");
            // Console.WriteLine($"Total number of line even calculate = {totalEvenLineNumber}");
            var total2Line = totalOddLineNumber + totalEvenLineNumber;
            var nextHighestNumberEndingInZero = Math.Ceiling(Convert.ToDouble(total2Line) / 10) * 10;

            if (Math.Abs(nextHighestNumberEndingInZero - total2Line - lastNumber) == 0)
            {
                Console.WriteLine("Valid SIN");
            }
            else
            {
                Console.WriteLine("Invalid SIN");
            }

            return false;
        }
    }
}