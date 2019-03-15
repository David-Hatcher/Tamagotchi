using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static private bool quit = false;
        static TamagotchiObject tama = new TamagotchiObject();

        static void Main(string[] args)
        {

            GreetPlayer();
            tama.gender = GetGender();
            tama.name = GetName();
            while (tama.isAlive() && !quit)
            {
                string playerInput = PlayerChoice();
                if(playerInput == "quit")
                {
                    Console.Write("All unsaved progess will be lost. Are you sure?: ");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        quit = true;
                        break;
                    } else if (answer.ToLower() == "no")
                    {
                        continue;
                    } else
                    {
                        Console.Write("I do not understand that commmand.");
                        continue;
                    }
                } else if (playerInput == "help")
                {
                    Help();
                    continue;
                } else
                {
                    Console.WriteLine(tama.PlayerChoice(playerInput));
                }
                tama.Tick();
                Alive();
            }
        }

        static private void GreetPlayer()
        {
            Console.WriteLine("Say 'Hello' to your brand new friend who just hatched!");
        }
        static private string GetGender()
        {
            Console.Write("What gender is your new friend?: ");
            string gender = Console.ReadLine();
            return gender;
        }
        static private string GetName()
        {
            Console.Write("Lets name our new friend: ");
            string name = Console.ReadLine();
            return name;
        }
        static private void Alive(){
            if (!tama.isAlive())
            {
                Console.WriteLine("It looks like {0} has died from {1}.", tama.name, tama.deathReason);
                Console.ReadLine();
                quit = true;
            }
        }
        static private string PlayerChoice()
        {
            Console.Write("What would you like to do with {0}: [type 'help' for commands or 'quit']", tama.name);
            string response = Console.ReadLine();
            return response.ToLower();
        }
        static private void Help()
        {
            Console.Write("The following commands work: play, feed, poop, sleep, hunger, tiredness, fullness, happiness, help, quit");


        }
    }
}
