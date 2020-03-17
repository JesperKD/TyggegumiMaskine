using System;

namespace TyggegumiMaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            

            bool machineison = true;
            string choice = string.Empty;

            while (machineison == true)
            {
                Console.Clear();
                Console.WriteLine("TURN THE HANDLE? Y/N");
                choice = Console.ReadLine();
                
                if(choice == "y" || choice == "Y")
                {
                    GumMachine.Instance.RegEmpty();
                    bool gavegum = false;
                    while (gavegum == false && GumMachine.Instance.DispenserEmpty == false)
                    {
                        Random rand = new Random();
                        int rando = rand.Next(1, 7);

                        if (rando == 1 && GumMachine.Instance.BlueGum != 0)
                        {
                            GumMachine.Instance.BlueGum--;
                            Console.WriteLine("You got a Blue piece of gum");
                            gavegum = true;
                        }
                        else if (rando == 2 && GumMachine.Instance.PurpleGum != 0)
                        {
                            GumMachine.Instance.PurpleGum--;
                            Console.WriteLine("You got a Purple piece of gum");
                            gavegum = true;
                        }
                        else if (rando == 3 && GumMachine.Instance.YellowGum != 0)
                        {
                            GumMachine.Instance.YellowGum--;
                            Console.WriteLine("You got a Yellow piece of gum");
                            gavegum = true;
                        }
                        else if(rando == 4 && GumMachine.Instance.OrangeGum != 0)
                        {
                            GumMachine.Instance.OrangeGum--;
                            Console.WriteLine("You got an Orange piece of gum");
                            gavegum = true;
                        }
                        else if (rando == 5 && GumMachine.Instance.RedGum != 0)
                        {
                            GumMachine.Instance.RedGum--;
                            Console.WriteLine("You got a Red piece of gum");
                            gavegum = true;
                        }
                        else if(rando == 6 && GumMachine.Instance.GreenGum != 0)
                        {
                            GumMachine.Instance.GreenGum--;
                            Console.WriteLine("You got a Green piece of gum");
                            gavegum = true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    

                    while (GumMachine.Instance.DispenserEmpty == true)
                    {
                        Console.WriteLine("There is no more gum, please press any key after refilling the machine");
                        Console.ReadKey();
                        GumMachine.Instance.Refill();
                    }


                }
                else if( choice == "n" || choice == "N")
                {
                    Console.WriteLine("Then why are you here.");
                }
                else
                {
                    Console.WriteLine("Not a valid input, try again.");
                }

                Console.ReadKey();
            }
            Console.WriteLine("GoodBye.");
        }
    }
}
