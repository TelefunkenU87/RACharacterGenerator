using System;
using System.Collections.Generic;
using System.Text;

namespace RACharacterGenerator
{
    public class Character
    {
        static Random dice = new Random();
        public int[] SkillLevel = new int[20] { 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30 };
        public string[] SkillName = new string[20] { "Athletics", "Burglary", "Constitution", "Drive", "Fight", "Perception", "Might", "Shoot", "Stealth", "Broad-Craft", "Deceive", "Diplomacy", "Fine-Craft", "Intimidate", "Intuition", "Investigate", "Logic", "Special", "Wealth", "Will" };
        public string[,] HistoryQs = new string[27, 2];
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
            HistQ0();
            HistQ1();
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
        void IncreaseSkills(int a, int b)
        {
            SkillLevel[a] += dice.Next(1, 6);
            SkillLevel[b] += dice.Next(1, 6);
            return;
        }
        void HistQ0()
        {
            HistoryQs[0, 0] = "What was your earliest memory?";
            switch (dice.Next(100) / 10)
            {
                case 0:
                    HistoryQs[0, 1] = "A loud explosion and then silence.";
                    IncreaseSkills(3, 13);
                    break;
                case 1:
                    HistoryQs[0, 1] = "Running for my life.";
                    IncreaseSkills(0, 5);
                    break;
                case 2:
                    HistoryQs[0, 1] = "Getting caught stealing.";
                    IncreaseSkills(1, 19);
                    break;
                case 3:
                    HistoryQs[0, 1] = "Eating like there's no tomorrow.";
                    IncreaseSkills(2, 18);
                    break;
                case 4:
                    HistoryQs[0, 1] = "Crying because I got hopelessly lost.";
                    IncreaseSkills(12, 15);
                    break;
                case 5:
                    HistoryQs[0, 1] = "Being covered in someone else's blood.";
                    IncreaseSkills(9, 7);
                    break;
                case 6:
                    HistoryQs[0, 1] = "My parents telling me it will all be OK.";
                    IncreaseSkills(10, 6);
                    break;
                case 7:
                    HistoryQs[0, 1] = "The joyful laughter of my family.";
                    IncreaseSkills(11, 17);
                    break;
                case 8:
                    HistoryQs[0, 1] = "A vicious battle. I don't know who won.";
                    IncreaseSkills(4, 16);
                    break;
                case 9:
                    HistoryQs[0, 1] = "Playing hide and seek with my friends.";
                    IncreaseSkills(14, 8);
                    break;
            }
            return;
        }
        void HistQ1()
        {
            HistoryQs[1, 0] = "Where did you grow up?";
            switch (dice.Next(100) / 10)
            {
                case 0:
                    HistoryQs[1, 1] = "On the streets.";
                    IncreaseSkills(8, 4);
                    break;
                case 1:
                    HistoryQs[1, 1] = "On the open road, always traveling.";
                    IncreaseSkills(3, 11);
                    break;
                case 2:
                    HistoryQs[1, 1] = "On a farm, in the muck.";
                    IncreaseSkills(9, 0);
                    break;
                case 3:
                    HistoryQs[1, 1] = "Near a church, helping the priests.";
                    IncreaseSkills(15, 6);
                    break;
                case 4:
                    HistoryQs[1, 1] = "In a mansion, waited upon hand and foot.";
                    IncreaseSkills(13, 1);
                    break;
                case 5:
                    HistoryQs[1, 1] = "Near a library that I always visited.";
                    IncreaseSkills(16, 12);
                    break;
                case 6:
                    HistoryQs[1, 1] = "Wherever I could.";
                    IncreaseSkills(7, 5);
                    break;
                case 7:
                    HistoryQs[1, 1] = "In a busy shop, constantly underfoot.";
                    IncreaseSkills(19, 18);
                    break;
                case 8:
                    HistoryQs[1, 1] = "In a comfortable urban home.";
                    IncreaseSkills(17, 14);
                    break;
                case 9:
                    HistoryQs[1, 1] = "On the stage, performing every night.";
                    IncreaseSkills(10, 2);
                    break;
            }
            return;
        }
    }
}
