using System;

namespace Lab3
{
    public class Atom
    {
        
        public int Number { get; set; }
        public string Symbol { get; set; }
        public string Fullname { get; set; }
        public float Weight { get; set; }

        public bool Accept()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter atomic number : ");
                    if (int.TryParse(Console.ReadLine(), out var number))
                    {
                        Number = number;
                        if (Number == 0)
                        {
                            return false;
                        }
                        
                        break;
                    }
                    
                }
                Console.Write("Enter symbol:");
                Symbol = Console.ReadLine();
                Console.Write("Enter full name:");
                Fullname = Console.ReadLine();
                while (true)
                {
                    Console.Write("Enter atomic weight:");
                    Weight = float.Parse(Console.ReadLine());
                    if (float.TryParse(Console.ReadLine(), out var number))
                    {
                        Weight = number;
                        break;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }

            return false;
        }

        public void Display()
        {
            Console.WriteLine($"{Number},{Symbol},{Fullname},{Weight}");
        }
    }
}