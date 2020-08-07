using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat=true;
            double Inputs, Outputs, Balance = 0, AmountIn = 0, AmountOut = 0; 
            string YesNo, Press, Continue;

            Console.WriteLine("Welcome! \n");
            while (repeat = true)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.Write("If you want to continue press 'Y' otherwise press any button to view the balance: ");
                YesNo = Console.ReadLine();
                if (YesNo == "y" || YesNo=="Y")
                {
                    //Console.WriteLine("-----------------------------------------------------\n");
                    if (YesNo == "y"|| YesNo=="Y")
                    {
                        Console.Write("Press \"I\" for inputs or \"O\" for outputs : ");
                        Press = Console.ReadLine();

                        if (Press == "i" || Press == "I")
                        {
                        here:
                            Console.WriteLine("Please enter the value of the inputs: ");
                            Inputs = double.Parse(Console.ReadLine());
                            if (Inputs >= 0)
                            {

                                Console.WriteLine("\nIf you are sure press \"Y\" or not press \"C\" to change the value");
                                Continue = Console.ReadLine();
                                if (Continue == "y" || Continue == "Y")
                                {
                                    AmountIn += Inputs;
                                    Balance += Inputs;
                                    Console.WriteLine("\n++ The inputs were processed successfully! ++\n");
                                }

                                else if (Continue == "c" || Continue == "C")
                                { goto here; }
                               
                                else
                                {
                                    Console.WriteLine("\n** You didn't print correctly! **\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n** Please enter positive numbers **\n");
                                goto here;
                            }
                        }
                   
                        else if (Press == "o" || Press == "O") 
                        {
                        here:
                            Console.WriteLine("Please enter the value of the outputs: ");
                            Outputs = double.Parse(Console.ReadLine());
                            if (Outputs>=0)
                            {


                                if (Outputs <= Balance)
                                {

                                    Console.WriteLine("\nIf you are sure press \"Y\" or not press \"C\" to change the value");
                                    Continue = Console.ReadLine();
                                    if (Continue == "y" || Continue == "Y")
                                    {
                                        AmountOut += Outputs;
                                        Balance -= Outputs;
                                        Console.WriteLine("\n-- Outputs were processed successfully! --\n");
                                    }
                                    else if (Continue == "c" || Continue == "C")
                                    { goto here; }
                                    else
                                    {
                                        Console.WriteLine("\n** You didn't print correctly! **\n");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You can't get more outputs than you have to balance");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n * *Please enter positive numbers * *\n");
                                goto here;
                            }
                            

                        }
                        else
                        {
                            Console.WriteLine($"\n** You didn't print correctly! **\n");
                            
                        }
                    }
                }
                else if (YesNo != "y"||YesNo!="Y")
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine($"Amount of Inputs: {AmountIn}" + "$");
                    Console.WriteLine($"Amount of Outputs: {AmountOut}" + "$");
                    Console.WriteLine($"Your balance sheet is: {Balance}" + "$");
                    Console.WriteLine("---------------------------\n");
                    Console.WriteLine("Thank you!");
                    break; 
                }
           }
        }
    }
}
