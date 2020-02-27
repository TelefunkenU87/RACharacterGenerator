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

            Console.WriteLine($"Char 1 Q1: {character1.HistoryQs[0, 0]} Answer: {character1.HistoryQs[0, 1]}");
            Console.WriteLine($"Char 1 Q2: {character1.HistoryQs[1, 0]} Answer: {character1.HistoryQs[1, 1]}");
            for(int i = 0; i < character1.SkillLevel.Length; i++)
            {
                Console.WriteLine($"{character1.SkillName[i]}: {character1.SkillLevel[i]}");
            }

            Console.WriteLine($"Char 2 Q1: {character2.HistoryQs[0, 0]} Answer: {character2.HistoryQs[0, 1]}");
            Console.WriteLine($"Char 2 Q2: {character2.HistoryQs[1, 0]} Answer: {character2.HistoryQs[1, 1]}");
            for (int i = 0; i < character2.SkillLevel.Length; i++)
            {
                Console.WriteLine($"{character2.SkillName[i]}: {character2.SkillLevel[i]}");
            }

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
