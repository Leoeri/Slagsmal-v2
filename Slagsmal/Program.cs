using System;

namespace Slagsmal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answeared = false;
            Random generator = new Random();
            //int fighterB;
            //int fighterA;
            System.Console.WriteLine("Welcome to the fighting game!");
            System.Console.WriteLine("What is the name of your fighter?");
            string name = Console.ReadLine();
            System.Console.WriteLine("Do you want to play:");
            System.Console.WriteLine("1. Single fight");
            System.Console.WriteLine("2. Tournament");
            string answear = Console.ReadLine();
            int WhatOpponent = generator.Next();
            string opponent = opponents();
            while (answeared == false)
            {
                if (answear == "1")
                {
                    Console.Clear();
                    Single(name, opponent);
                    answeared = true;
                }
                else if (answear == "2")
                {
                    Console.Clear();
                    Tournament(name, opponent);
                    answeared = true;
                }
                else if (answear != "1" && answear != "2")
                {
                    System.Console.WriteLine("Answer with \"1\" or \"2\"");
                    answeared = false;
                }
                else if (answear == "Klappa katten")
                {
                    System.Console.WriteLine("Du klappade katten!");
                    answeared = false;
                }
                answear = Console.ReadLine();
            }
        }
        static void Single(string n, string o)
        {
            Random generator = new Random();
            int HPfighter = 100;
            int HPopponent = 100;
            int damage1 = generator.Next(1, 21);
            int damage2 = generator.Next(1, 21);
            Console.Clear();
            while (HPfighter > 0 && HPopponent > 0)
            {
                damage1 = generator.Next(1, 21);
                damage2 = generator.Next(1, 21);
                HPfighter -= damage2;
                HPopponent -= damage1;
                if (HPfighter > 0 && HPopponent > 0)
                {
                    Console.WriteLine(o + " took " + damage1 + " damage and has " + HPopponent + " HP left!");
                    Console.WriteLine(n + " took " + damage2 + " damage and has " + HPfighter + " HP left!");
                    Console.ReadLine();
                }
                else if (HPfighter <= 0 && HPopponent <= 0)
                {
                    System.Console.WriteLine(n + " took " + damage2 + " damage and " + o + " took " + damage1 + " damage");
                    System.Console.WriteLine("Both fighters fall unconscious. it's a draw!");
                    Console.ReadLine();
                }
                else if (HPfighter <= 0)
                {
                    System.Console.WriteLine(n + " took " + damage2 + " damage and was knocked unconsious.");
                    System.Console.WriteLine(o + " won!");
                    Console.ReadLine();
                }
                else if (HPopponent <= 0)
                {
                    System.Console.WriteLine(o + " took " + damage1 + " damage and was knocked unconsious.");
                    System.Console.WriteLine(n + " won!");
                    Console.ReadLine();
                }


            }



        }
        static void Tournament(string n, string o)
        {
            bool tournament = false;
            int round = 1;
            int healthpacks = 3;
            bool answearedTournament = false;
            bool answearedHP = false;
            Random generator = new Random();
            int HPfighter = 100;
            int HPopponent = 100;
            int damage1 = generator.Next(10, 31);
            int damage2 = generator.Next(1, 21);
            while (tournament == false)
            {
                Console.Clear();
                System.Console.WriteLine("Round " + round + ".");
                answearedHP = false;
                answearedTournament = false;
                while (HPfighter > 0 && HPopponent > 0)
                {
                    damage1 = generator.Next(10, 31);
                    damage2 = generator.Next(1, 21);
                    HPfighter -= damage2;
                    HPopponent -= damage1;
                    if (HPfighter > 0 && HPopponent > 0)
                    {
                        Console.WriteLine(o + " took " + damage1 + " damage and has " + HPopponent + " HP left!");
                        Console.WriteLine(n + " took " + damage2 + " damage and has " + HPfighter + " HP left!");
                        Console.ReadLine();
                    }
                    else if (HPfighter <= 0 && HPopponent <= 0)
                    {
                        System.Console.WriteLine(n + " took " + damage2 + " damage and " + o + " took " + damage1 + " damage");
                        System.Console.WriteLine("Both fighters fall unconscious. it's a draw!");
                        Console.ReadLine();
                        Console.Clear();
                        tournament = true;
                    }
                    else if (HPfighter <= 0)
                    {
                        System.Console.WriteLine(n + " took " + damage2 + " damage and was knocked unconsious.");
                        System.Console.WriteLine(o + " won!");
                        Console.ReadLine();
                        Console.Clear();
                        tournament = true;
                    }
                    else if (HPopponent <= 0)
                    {
                        System.Console.WriteLine(o + " took " + damage1 + " damage and was knocked unconsious.");
                        System.Console.WriteLine(n + " won!");
                        Console.ReadLine();
                        Console.Clear();
                    }



                }
                if (HPfighter > 0)
                {
                    System.Console.WriteLine("Your fighter can still fight");
                    System.Console.WriteLine("Do you want to continue \"Y\" or\"N\"");
                    string answerTournament = Console.ReadLine();
                    while (answearedTournament == false)
                    {
                        if (answerTournament == "Y")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Let's get back to it then");
                            o = opponents();
                            HPopponent = 100;
                            if (healthpacks > 0)
                            {
                                System.Console.WriteLine("You have " + HPfighter + " HP after that fight");
                                System.Console.WriteLine("You still have " + healthpacks + " health packs left. Do you want to use one ofthem? \"Y\" or \"N\"");
                                string answearHP = Console.ReadLine();
                                while (answearedHP == false)
                                {
                                    if (answearHP == "Y")
                                    {
                                        HPfighter = 100;
                                        healthpacks--;
                                        Console.Clear();
                                        System.Console.WriteLine("You used a healthpack and " + n + " got fully healed");
                                        round++;
                                        Console.ReadLine();

                                        answearedHP = true;
                                    }
                                    if (answearHP == "N")
                                    {
                                        Console.Clear();
                                        System.Console.WriteLine("You didn't use a healthpack and " + n + " has " + HPfighter + "HP left.");
                                        round++;
                                        Console.ReadLine();
                                        answearedHP = true;

                                    }
                                    if (answearHP != "Y" && answearHP != "N")
                                    {
                                        System.Console.WriteLine("Answear with \"Y\" or \"N\"");
                                        answearHP = Console.ReadLine();
                                        answearedHP = false;
                                    }
                                }
                            }
                            else if (healthpacks == 0)
                            {
                                Console.Clear();
                                System.Console.WriteLine("You don't have any healthpacks left");
                                System.Console.WriteLine("I'll just put you in another fight anyways");
                                Console.ReadLine();
                            }

                            answearedTournament = true;

                        }
                        else if (answerTournament == "N")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Coward!");
                            answearedTournament = true;
                            tournament = true;
                        }
                        else if (answerTournament != "Y" && answerTournament != "N")
                        {
                            System.Console.WriteLine("Answear with \"Y\" or \"N\"");
                            answerTournament = Console.ReadLine();
                            answearedTournament = false;
                        }
                    }

                }
            }


        }
        static string opponents()
        {
            Random generator = new Random();
            int WhatOpponent = generator.Next(1, 4);
            if (WhatOpponent == 1)
            {
                return "Connor McGregor";
            }
            if (WhatOpponent == 2)
            {
                return "Chuck Norris";

            }
            if (WhatOpponent == 3)
            {
                return "Bruce Lee";
            }
            return "pog";
        }
    }
}

