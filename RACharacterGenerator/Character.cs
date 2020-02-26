using System;
using System.Collections.Generic;
using System.Text;

namespace RACharacterGenerator
{
    public class Character
    {
        static Random dice = new Random();
        public int Age;
        public string Sex;
        public string Handedness;
        public string Complexion;
        public string BodyType;
        public string DistinctiveTrait;

        public void GenChar()
        {
            Age = GenAge();
            Sex = GenSex();
            Handedness = GenHandedness();
            Complexion = GenComplexion();
            BodyType = GenBodyType();
            DistinctiveTrait = GenDistinctTrait();
        }
        int GenAge()
        {
            return 20 + dice.Next(1, 11);
        }
        string GenSex()
        {
            if (dice.Next(1, 101) < 51) return "Male";
            else return "Female";
        }
        string GenHandedness()
        {
            int roll = dice.Next(1, 101);
            if (roll <= 89) return "Right Handed";
            else if (roll <= 99) return "Left Handed";
            else return "Ambidextrous";
        }
        string GenComplexion()
        {
            string[] complexion = new string[10] { "Pale", "Fair", "Golden", "Rosy", "Ruddy", "Tan", "Olive", "Dark", "Swarthy", "Dusky" };
            return complexion[(dice.Next(100)/10)];
        }
        string GenBodyType()
        {
            string[,] bodyType = new string[7, 2] { { "Scrawny", "Petite" }, { "Lean", "Slender" }, { "Athletic", "Fit" }, { "Average", "Average" }, { "Brawny", "Muscular" }, { "Stocky", "Buxom" }, { "Heavy", "Plump" } };
            int roll = dice.Next(1, 101);
            int sexIndex;
            if (Sex == "Male") sexIndex = 0;
            else sexIndex = 1;
            if (roll <= 10) return bodyType[0, sexIndex];
            else if (roll <= 25) return bodyType[1, sexIndex];
            else if (roll <= 40) return bodyType[2, sexIndex];
            else if (roll <= 60) return bodyType[3, sexIndex];
            else if (roll <= 75) return bodyType[4, sexIndex];
            else if (roll <= 90) return bodyType[5, sexIndex];
            else return bodyType[6, sexIndex];
        }
        string GenDistinctTrait()
        {
            string[] trait = new string[49] { "Androgynous.", "Animal tattoos.", "Bald head.", "Bow-Legged.", "Close-set eyes.", "Crooked nose.", "Crooked teeth.", "Excess body hair.", "Exotropic eyes.", "Extensive liquid burn marks.", "Extreme scarring on legs.", "Eyebrow piercings.", "Gang tattoos.", "Glasgow Smile.", "Healed chemical burn marks.", "Heavy scarring on face.", "Huge scarring on back.", "Lip piercing.", "Long fingers.", "Major electrical burn marks.", "Military tattoos.", "Missing ear.", "Missing finger.", "Missing teeth.", "Missing toe.", "Mythological tattoos.", "Nervous facial tic.", "Nose piercing.", "Old brand on face.", "Old brand on neck.", "Old brands on arms.", "Old brands on arms.", "Old brands on torso.", "Overbite.", "Plant tattoos.", "Pockmarked skin.", "Protruding brow and chin.", "Religious tattoos.", "Scarring on arms.", "Severe flame burn marks.", "Stain-mark on arm.", "Stain-mark on face.", "Stain-mark on neck.", "Stain-mark on torso.", "Terrible scarring on chest.", "Tribal tattoos.", "Underbite.", "Unpleasant odour.", "Vitiligo." };
            int roll = dice.Next(100);
            return trait[roll / 2];
        }
    }
}
