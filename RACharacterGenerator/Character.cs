using System;
using System.Collections.Generic;
using System.Text;

namespace RACharacterGenerator
{
    public class Character
    {
        static Random dice = new Random();
        public int Age = GenAge();
        public string Sex = GenSex();
        public string Complexion = GenComplexion();

        static int GenAge()
        {
            return 20 + dice.Next(1, 11);
        }
        static string GenSex()
        {
            if (dice.Next(1, 101) < 51) return "Male";
            else return "Female";
        }
        static string GenComplexion()
        {
            string[] complexion = new string[10] { "Pale", "Fair", "Golden", "Rosy", "Ruddy", "Tan", "Olive", "Dark", "Swarthy", "Dusky" };
            return complexion[(dice.Next(100)/10)];
        }
    }
}
