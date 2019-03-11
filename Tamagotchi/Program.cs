using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetPlayer();
            GetGender();
            GetName();
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
    }
}
