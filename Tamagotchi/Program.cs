﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static private bool quit = false;

        static void Main(string[] args)
        {
            GreetPlayer();
            GetGender();
            GetName();
            while (tama.alive() && !quit)
            {
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
            if (!tama.alive())
            {
                Console.WriteLine("It looks like {0} has died from hunger.", tama.name);
            }
        }


        quit functionality
            with non workign save
    }
}
