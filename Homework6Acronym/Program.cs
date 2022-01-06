using System;

namespace Homework6Acronym
{
    class Program
    {
        static void Main(string[] args)
        {
            Acronym acronym = new Acronym("The Best idea");
            Console.WriteLine(acronym.TheAcronym);
            Acronym acronym2 = new Acronym("Portable Network Graphics");
            Console.WriteLine(acronym2.TheAcronym);
        }
    }
}
