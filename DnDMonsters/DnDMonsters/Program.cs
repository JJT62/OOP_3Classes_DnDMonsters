using System;

namespace DnDMonsters
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endProgram = false;
            bool endHP;
            bool endAttack;
            bool endAttack2;
            while (!endProgram)
            {
                Console.WriteLine("What monster do you want to use?");
                Console.WriteLine("1. Goblin");
                Console.WriteLine("2. Ogre");
                Console.WriteLine("3. Dragon");
                Console.WriteLine("4. Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Goblin goblin = new Goblin();

                        endHP = false;
                        while (!endHP)
                        {
                            Console.WriteLine("Roll for HP or use default?");
                            Console.WriteLine("1. Roll");
                            Console.WriteLine("2. Default");
                            string inputHP = Console.ReadLine();

                            switch (inputHP)
                            {
                                case "1":
                                    goblin.RollForHP();
                                    endHP = true;
                                    break;
                                case "2":
                                    endHP = true;
                                    break;
                                default:
                                    Console.WriteLine("Incorrect option, choose again");
                                    break;
                            }
                        }

                        goblin.ShowStats();

                        endAttack = false;
                        while (!endAttack)
                        {
                            Console.WriteLine("Do attack?");
                            Console.WriteLine("1. Attack");
                            Console.WriteLine("2. End Program");
                            string inputAttack = Console.ReadLine();
                            switch (inputAttack)
                            {
                                case "1":
                                    endAttack2 = false;
                                    while (!endAttack2)
                                    {
                                        Console.WriteLine("Roll for damage or use default?");
                                        Console.WriteLine("1. Roll");
                                        Console.WriteLine("2. Default");
                                        string inputAttack2 = Console.ReadLine();

                                        switch (inputAttack2)
                                        {
                                            case "1":
                                                goblin.RollForDamage();
                                                goblin.doAttack();
                                                endAttack2 = true;
                                                break;
                                            case "2":
                                                goblin.resetDefaultDamage();
                                                goblin.doAttack();
                                                endAttack2 = true;
                                                break;
                                            default:
                                                Console.WriteLine("Incorrect option, choose again");
                                                break;
                                        }
                                    }
                                    break;
                                case "2":
                                    endAttack = true;
                                    break;
                                default:
                                    Console.WriteLine("Incorrect option, choose again");
                                    break;
                            }
                        }
                        endProgram = true;
                            break;  
                    case "2":
                        Ogre ogre = new Ogre();
                        endHP = false;
                        while (!endHP)
                        {
                            Console.WriteLine("Roll for HP or use default?");
                            Console.WriteLine("1. Roll");
                            Console.WriteLine("2. Default");
                            string inputHP = Console.ReadLine();

                            switch (inputHP)
                            {
                                case "1":
                                    ogre.RollForHP();
                                    endHP = true;
                                    break;
                                case "2":
                                    endHP = true;
                                    break;
                                default:
                                    Console.WriteLine("Incorrect option, choose again");
                                    break;
                            }
                        }

                        ogre.ShowStats();

                        endAttack = false;
                        while (!endAttack)
                        {
                            Console.WriteLine("Do attack?");
                            Console.WriteLine("1. Attack");
                            Console.WriteLine("2. End Program");
                            string inputAttack = Console.ReadLine();
                            switch (inputAttack)
                            {
                                case "1":
                                    endAttack2 = false;
                                    while (!endAttack2)
                                    {
                                        Console.WriteLine("Roll for damage or use default?");
                                        Console.WriteLine("1. Roll");
                                        Console.WriteLine("2. Default");
                                        string inputAttack2 = Console.ReadLine();

                                        switch (inputAttack2)
                                        {
                                            case "1":
                                                ogre.RollForDamage();
                                                ogre.doAttack();
                                                endAttack2 = true;
                                                break;
                                            case "2":
                                                ogre.resetDefaultDamage();
                                                ogre.doAttack();
                                                endAttack2 = true;
                                                break;
                                            default:
                                                Console.WriteLine("Incorrect option, choose again");
                                                break;
                                        }
                                    }
                                    break;
                                case "2":
                                    endAttack = true;
                                    break;
                                default:
                                    Console.WriteLine("Incorrect option, choose again");
                                    break;
                            }
                        }
                        endProgram = true;
                        break;
                    case "3":
                        Dragon dragon = new Dragon();
                        endHP = false;
                        while (!endHP)
                        {
                            Console.WriteLine("Roll for HP or use default?");
                            Console.WriteLine("1. Roll");
                            Console.WriteLine("2. Default");
                            string inputHP = Console.ReadLine();

                            switch (inputHP)
                            {
                                case "1":
                                    dragon.RollForHP();
                                    endHP = true;
                                    break;
                                case "2":
                                    endHP = true;
                                    break;
                                default:
                                    Console.WriteLine("Incorrect option, choose again");
                                    break;
                            }
                        }

                        dragon.ShowStats();

                        endAttack = false;
                        while (!endAttack)
                        {
                            Console.WriteLine("Do attack?");
                            Console.WriteLine("1. Attack");
                            Console.WriteLine("2. End Program");
                            string inputAttack = Console.ReadLine();
                            switch (inputAttack)
                            {
                                case "1":
                                    endAttack2 = false;
                                    while (!endAttack2)
                                    {
                                        Console.WriteLine("Roll for damage or use default?");
                                        Console.WriteLine("1. Roll");
                                        Console.WriteLine("2. Default");
                                        string inputAttack2 = Console.ReadLine();

                                        switch (inputAttack2)
                                        {
                                            case "1":
                                                dragon.RollForDamage();
                                                dragon.doAttack();
                                                endAttack2 = true;
                                                break;
                                            case "2":
                                                dragon.resetDefaultDamage();
                                                dragon.doAttack();
                                                endAttack2 = true;
                                                break;
                                            default:
                                                Console.WriteLine("Incorrect option, choose again");
                                                break;
                                        }
                                    }
                                    break;
                                case "2":
                                    endAttack = true;
                                    break;
                                default:
                                    Console.WriteLine("Incorrect option, choose again");
                                    break;
                            }
                        }
                        endProgram = true;
                        break;
                    case "4":
                        endProgram = true;
                        Console.WriteLine("Thank you for using this program, goodbye!");
                        break;
                    default:
                        Console.WriteLine("Incorrect option, choose again");
                        break;
                }
            }
        }
    }
}
