using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxDemo
{
    class Program
    {
        //Functions are methods written outside of a custom class
        //Methods are fuctions written inside of a custom class

        //acts as our programs .exe file, aka executable
        //This is the file we double click on to start any program
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to your Tool Box!");
            Console.WriteLine("You can either hit \"Y\" then ENTER to continue, or hit \"N\" then ENTER to Clear the console and continue.");

            string userResponse = Console.ReadLine();
            if(userResponse == "Y")
            {
                KeyToContinue();
            }
            else if(userResponse == "N")
            {
                KeyToContinueWithClearConsole();
            }
            else
            {
                Console.WriteLine("Not sure friend, but I'm gonna close the program when you hit ENTER");
            }
           
            KeyToContinueWithClearConsole();
            Console.ReadLine();


            //Functions below this line
            void KeyToContinue()
            {
                Console.WriteLine("Hit ENTER to continue on with the code...");
                Console.ReadLine();

            }
            void ClearConsole()
            {
                Console.Clear();
              
            }
            
            void KeyToContinueWithClearConsole()
            {
                KeyToContinue();
                ClearConsole();
            }


        }
    }
}
