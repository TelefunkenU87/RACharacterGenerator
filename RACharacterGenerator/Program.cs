using System;

namespace RACharacterGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character();
            character1.GenChar();
            Character character2 = new Character();
            character2.GenChar();

            //Console.WriteLine($"Character 1 age is: {character1.Age}");
            //Console.WriteLine($"Character 2 age is: {character2.Age}");
            //Console.WriteLine($"Character 1 sex is: {character1.Sex}");
            //Console.WriteLine($"Character 2 sex is: {character2.Sex}");
            //Console.WriteLine($"Character 1 handedness is: {character1.Handedness}");
            //Console.WriteLine($"Character 2 handedness is: {character2.Handedness}");
            //Console.WriteLine($"Character 1 complexion is: {character1.Complexion}");
            //Console.WriteLine($"Character 2 complexion is: {character2.Complexion}");
            //Console.WriteLine($"Character 1 body type is: {character1.BodyType}");
            //Console.WriteLine($"Character 2 body type is: {character2.BodyType}");
            //Console.WriteLine($"Character 1 distinctive trait is: {character1.DistinctiveTrait}");
            //Console.WriteLine($"Character 2 distinctive trait is: {character2.DistinctiveTrait}");
        }
    }
}
