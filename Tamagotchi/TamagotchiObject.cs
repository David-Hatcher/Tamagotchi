using System.Collections.Generic;
using System;

namespace Tamagotchi
{
    public class TamagotchiObject
    {
        public string name { get; set; }
        public string gender { get; set; }
                
        public int happinessLevel = 50;
        public int hungerLevel = 50;
        public int tirednessLevel = 50;
        public int fullnessLevel = 50;

        static string[] hungerStatus = { "extremely hungry, they might even starve.", "very hungry.", "like they could probably eat." };
        static string[] happinessStatus = { "like finally ending it all.", "pretty sad.", "content.", "happy!", "supercalifragilistically happy!" };
        static string[] tirednessStatus = { "like they're about to die from exhaustion.", "like they could use some sleep soon.", "a little tired." };
        static string[] fullnessStatus = { "like they need to use the bathroom, NOW!", "like they need to use the bathroom soon.", "like they can wait awhile to use the bathroom." };
        

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

        public string statStatus(string status)
        {
            int value = statValue(status)/20;

            string response =
                status == "tiredness" ? tirednessStatus[value] :
                status == "happiness" ? happinessStatus[value] :
                status == "fullness"  ? fullnessStatus[value]  :
                status == "hunger"    ? hungerStatus[value]    :
                "please enter a valid stat(hunger, tiredness, happiness, fullness)";

             return response;
        }

        public int statValue(string stat)
        {
            int value = 0;
            Dictionary<string, int> statValues = new Dictionary<string, int>()
            {
                {"happiness", happinessLevel },
                {"hunger", hungerLevel },
                {"tiredness", tirednessLevel },
                {"fullness", fullnessLevel },
            };
            foreach (string stati in statValues.Keys)
            {
                if (stati == stat)
                {
                    value = statValues[stat];
                }
            }
            return value;

        }
        public bool isAlive()
        {
            bool response =
                hungerLevel      == 0 ? false :
                tirednessLevel   == 0 ? false :
                fullnessLevel    == 0 ? false :
                happinessLevel   == 0 ? false :
                true;
            return response;

        }
        public void activity(string whatDo)
        {
            if (whatDo == "play")
            {
                happyAdjust(20);
            }
            else if (whatDo == "feed")
            {
                hungerAdjust(20);
            }
            else if (whatDo == "poop")
            {
                fullAdjust(20);
            }
            else if (whatDo == "sleep")
            {
                tiredAdjust(20);
            }
            else
            {
                Console.WriteLine("Please select a valid activity(play, feed, poop, sleep).");
            }
        }
    }
}
