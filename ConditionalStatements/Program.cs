using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            
            try
            {
                string input = Console.ReadLine();

                int age = int.Parse(input);

                string toy;
                string job;
                string plan;

                if (age < 18) 
            
                {
                    Console.WriteLine("You are a minor!");
                    Console.WriteLine("Whats your favourite toy?");

                    toy = Console.ReadLine();
                    Console.WriteLine("your fav toy is:" + toy);

                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);

                    if (toy == "ball")
                    {
                        Console.WriteLine("You like to play sports!");
                        Console.WriteLine("Press any key to exit the program ...");
                        Console.ReadKey(true);
                    }
                    else if (toy == "doll")
                    {

                        Console.WriteLine("You like to play with dolls!");
                        Console.WriteLine("Press any key to exit the program ...");
                        Console.ReadKey(true);
                    }
                    else
                    {
                        Console.WriteLine("Pls enter Ball or Doll");
                    }
                    
                }
                
                
                else if ((age> 18) && (age < 65))
                {
                    Console.WriteLine("You are an Adult!");
                    Console.WriteLine("WHats your fav job?");

                    job = Console.ReadLine();
                    Console.WriteLine("Your Fav job is:" + job);
               
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }

                else
                {
                    Console.WriteLine("You are a Senior!");
                    Console.WriteLine("Whats your plans for retirement?");

                    plan = Console.ReadLine();
                    Console.WriteLine("Your Fav plan is:" + plan);

                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                

            } // End of try
            catch
            {
                Console.WriteLine("Pls enter a valid age");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }//End of catch33


        } //End of Main
    }
}

