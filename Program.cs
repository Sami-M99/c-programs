﻿using System;

namespace password
{
    class Program
    {
        static void Main(string[] args)                         //  *** This program to verify username and password ***
        {
            string nameuser_a = "sami";                   // Here we write the username and the password for the same account .
            string password_a = "ss22";

                                                         // We can make a new account , from make a new username and password .
            string nameuser_b = "ali";            
            string password_b = "aa22";


            string nameuser_c = "ahmed";
            string password_c = "ah22";

                                                        //To adding a new account , we must to put in the array , in the same arrangement (order).


            string[] real_name = { nameuser_a, nameuser_b, nameuser_c };              // This array for username
            string[] real_password = { password_a, password_b, password_c };          // And this for password. 

            int trying = 0;                      // this for count the number of attempts (try) .

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("**********try number ("+ i +")**********");

                Console.Write("Enter your user name : ");                               // This to ask about  username and input it from the user .
                string username = Console.ReadLine();                                

                Console.Write("Enter your password : ");                               // This to ask about password and inpur it from the user .
                string password = Console.ReadLine();


                if ((username == real_name [0] && password ==real_password [0]) || (username ==real_name [1] && password == real_password [1]) || (username ==real_name [2] && password ==real_password [2]))
                {
                    Console.WriteLine("Welcome to your page :)\n");                    // Here if it's true , print this sentence and stop the program .
                    break;
                }


                else
                {
                    if (trying == 2)                             // We make this condition to print this sentence in the last attempt, instead of the other sentence , and stop the program . 
                    {
                        Console.WriteLine("Your attempts are over , you made it three time wrong ):");
                        break;
                    }

                    Console.WriteLine("The user name or password is wrong. you can try again .\n");
                }
                    

                trying++;
            }
            
            Console.ReadKey();
        }
    }
}
