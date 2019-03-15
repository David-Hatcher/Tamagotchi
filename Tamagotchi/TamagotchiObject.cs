using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class TamagotchiObject
    {
        public string name { get; set; }
        public string gender { get; set; }
        string deathReason;
        public Dictionary<string, int> statValues = new Dictionary<string, int>()
        {
                {"happiness", 50 },
                {"hunger", 50 },
                {"tiredness", 50 },
                {"fullness", 50 },
        };

        static string[] happinessStatus = { "like finally ending it all.",
                                            "pretty sad.",
                                            "content.",
                                            "happy!",
                                            "supercalifragilistically happy!" };
        static string[] hungerStatus    = { "extremely hungry, they might even starve.",
                                            "very hungry.",
                                            "like they could probably eat.",
                                            "pretty full.",
                                            "completely stuffed." };
        static string[] tirednessStatus = { "like they're about to die from exhaustion.",
                                            "like they could use some sleep soon.",
                                            "a little tired.",
                                            "well rested.",
                                            "full of energy!"};
        static string[] fullnessStatus  = { "like they need to use the bathroom, NOW!",
                                            "like they need to use the bathroom soon.",
                                            "like they can wait awhile to use the bathroom.",
                                            "like they don't need to use the bathroom.",
                                            "like they're completely empty"};
        
        public void adjustStats(int[] changes)
        {
            

            for (int i = 0; i < changes.Length; i++)
            {
                string[] stats = statValues.Keys.ToArray();
                statValues[stats[i]] += changes[i];
            }

        }

        public string inputError()
        {            
            return "I don't understand. Type help for possible commands.";
        }

        public string statStatus(string status)
        {
            int value = statValue(status)/20;

            string responseStart = name + " feels ";


            string responseEnd =
                   status == "tiredness" ? tirednessStatus[value] :
                   status == "happiness" ? happinessStatus[value] :
                   status == "fullness"  ? fullnessStatus[value]  :
                                               hungerStatus[value];
            string responseFull = responseStart + responseEnd;
            return responseFull;        
        }

        public int statValue(string stat)
        {
            int value = 0;

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
            string deathReason =
                statValues["hunger"]    <= 0 ? "starvation" :
                statValues["tiredness"] <= 0 ? "exhaustion" :
                statValues["fullness"]  <= 0 ? "a ruptured bowel" :
                statValues["happiness"] <= 0 ? "suicide" :
                "";

            bool response =
                statValues["hunger"]        <= 0 ? false :
                statValues["tiredness"]     <= 0 ? false :
                statValues["fullness"]      <= 0 ? false :
                statValues["happiness"]     <= 0 ? false :
                true;
            return response;

        }
        public string activity(string whatDo)
        {
            string action = "";
            if (whatDo == "play")
            {
                action = "played " + name + ".";
                int[] changes = { 20, 0, 0, 0 };
                adjustStats(changes);
            }
            else if (whatDo == "feed")
            {
                action = "fed " + name + ".";
                int[] changes = { 0, 20, 0, 0 };
                adjustStats(changes);
            }
            else if (whatDo == "poop")
            {
                action = "took " + name + " to the bathroom.";
                int[] changes = { 0, 0, 0, 20 };
                adjustStats(changes);
            }
            else if (whatDo == "sleep")
            {
                action = "put " + name + " to bed.";
                int[] changes = { 0, 0, 20, 0 };
                adjustStats(changes);
            }
            string fullResponse = "You " + action;
            return fullResponse;
        }

        public void Tick()
        {
            Random rnd = new Random();            
            int statSelection = rnd.Next(0, 3);
            int tickValue = rnd.Next(-50,-1);
            int[] changes = statSelection == 0 ? new[] { tickValue, 0, 0, 0 } :
                            statSelection == 1 ? new[] { 0, tickValue, 0, 0 } :
                            statSelection == 2 ? new[] { 0, 0, tickValue, 0 } :
                            new[] { 0, 0, 0, tickValue };
            adjustStats(changes);
        }

        public string PlayerChoice(string choice)
        {
            string[] optionsActivity = { "play", "poop", "feed", "sleep" };
            string[] optionsStati = { "happiness", "hunger", "tiredness", "fullness" };

            if (optionsActivity.Contains(choice))
            {
                return activity(choice);                
            }
            else if (optionsStati.Contains(choice))
            {
                return statStatus(choice);              
            }
            else
            {
                return inputError();
            }

        }

    }
}
