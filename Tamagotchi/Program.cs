using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class TamagotchiOject
    {
        string tamagotchiName;
        public string nameGetSet { get { return tamagotchiName; } set { tamagotchiName = value; } }
        string tamagotchiGender;
        public string genderGetSet { get {return tamagotchiGender; } set {tamagotchiGender = value; } }

        public int happinessLevel = 50;
        public int hungerLevel = 50;
        public int tirednessLevel = 50;
        public int fullnessLevel = 50;

        static string[] hungerStatus = { "extremely hungry, they might even starve.", "very hungry.", "like they could probably eat." };
        static string[] happinessStatus = { "like finally ending it all.", "pretty sad.", "content.", "happy!", "supercalifragilistically happy!" };
        static string[] tirednessStatus = { "like they're about to die from exhaustion.", "like they could use some sleep soon.", "a little tired." };
        static string[] fullnessStatus = { "like they need to use the bathroom, NOW!", "like they need to use the bathroom soon.", "like they can wait awhile to use the bathroom." };
        List<string[]> statsList = new List<string[]>() { happinessStatus, fullnessStatus, tirednessStatus, hungerStatus };


        public void happyAdjust(int value)
        {
            happinessLevel += value;
        }
        public void hungerAdjust(int value)
        {
            hungerLevel += value;    
        }
        public void tiredAdjust(int value)
        {
            tirednessLevel += value;            
        }
        public void fullAdjust(int value)
        {
            fullnessLevel += value;            
        }
        public string tamagotchiNeeds()
        {
            int[] statsArray = new int[] { happinessLevel,fullnessLevel,tirednessLevel,hungerLevel };

            string priorityNeed = happinessStatus[happinessLevel/20];
            for (int i = 0; i < statsArray.Length; i++)
            {
                int indexValue = statsArray[i] / 20;

                if (statsArray[i] / 20 < 3)
                {                    
                    string[] testArray = statsList[i];
                    priorityNeed = testArray[indexValue];
                }
            }
            return priorityNeed;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
