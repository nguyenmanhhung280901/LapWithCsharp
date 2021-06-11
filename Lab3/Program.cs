using System;

namespace Lab3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            var atoms = new Atom[10];
            var currentIndex = 0;
            Console.WriteLine("Atomic Information");
            Console.WriteLine("=================");
            while (true)
            {
                if (currentIndex >= 10)
                {
                    break;
                }
                var atom = new Atom();
                var result = atom.Accept();
                if (result )
                {
                    atoms[currentIndex] = atom;
                    currentIndex++;
                }else if (atom.Number == 0)
                {
                    break;
                }

                Console.WriteLine("No Sym Name Weight");
                Console.WriteLine("--------------------------");
                for (int i = 0; i < currentIndex; i++)
                {
                    atoms[i].Display();
                }
            }
        }
    }
}