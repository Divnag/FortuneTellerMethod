using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            

                //UI Requirement 1


                //sending message to console asking for user input ,assigning it to a variable and converting it to same case
               
                Console.WriteLine("Enter the User Firstname or 'QUIT' to exit anytime");
                string firstName = Console.ReadLine().ToUpper();
            
                if ((firstName == "QUIT")||(firstName=="RESTART"))
                {
                   Quit(firstName);
              
                }
            
                Console.WriteLine("");
                Console.WriteLine("Enter the User Lastname or 'QUIT' to exit anytime");
               String lastName = Console.ReadLine().ToUpper();
           
            if ((lastName == "QUIT")||( lastName=="RESTART"))
            {
                Quit(lastName);

            }
            Console.WriteLine(" ");
                Console.WriteLine("Enter the User age or 'QUIT' to exit anytime");
                //converting string  to integer
                string age1 = Console.ReadLine().ToUpper();
            
            int age;
                int.TryParse(age1, out age);
            if ((age1 == "QUIT")||(age1=="RESTART"))
            {
                Quit(age1);

            }
            //checking if user input is valid age
            while (age < 0)

                {
                    Console.WriteLine("Enter valid age");
                    age = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("");
                Console.WriteLine("Enter User birth month or 'QUIT' to exit anytime");
               String birthMonth1 = Console.ReadLine().ToUpper();
              
               int birthMonth;
                int.TryParse(birthMonth1, out birthMonth);
              if( (birthMonth1 == "QUIT")||(birthMonth1=="RESTART"))
              {
                Quit(birthMonth1);

              }
            Console.WriteLine(" ");
                Console.WriteLine("Please select your favourite color from 'ROYGBIV'\n If you need help choosing color. Type 'Help'");
                
            //converting string to lowercase

              String color = Console.ReadLine().ToLower();
            if ((color == "QUIT")||(color=="RESTART"))
            {
                Quit(color);

            }
            //user asked for help

            //wrong color selected
            while ((color=="help")||(color != "red") && (color != "green") && (color != "yellow") && (color != "orange") && (color != "blue") && (color != "indigo") && (color != "violet"))
                {
                    Console.WriteLine("ROYGBIV stands for\nR:Red\nO:Orange\nY:Yellow\nG;Green\nB:Blue\nI:Indigo\nv:Violet\n");
                    Console.WriteLine("Select your color");
                    color = Console.ReadLine().ToLower();
                }
              
                Console.WriteLine("");
                Console.WriteLine("enter the number of siblings or 'QUIT' to exit anytime");
                String sib1 = Console.ReadLine();
                 int sib;
                 int.TryParse(sib1, out sib);
                 if ((sib1 == "QUIT")||(sib1=="RESTART"))
                  {
                  Quit(sib1);

                  }



                 Console.WriteLine("Greetings,  " + Greet(firstName, lastName) + ". I will tell you Fortune\n");
                 FortuneThinks();

                Console.WriteLine(firstName + lastName + " will retire in " + UserRetire(age) + "years " + "with: $" + RetireMoney(birthMonth) +
                    "in the bank " + "a vaction home " + VactionHome(sib) + " and a " + ModeOfTransport(color));
  
            
        }



        //methods
        public static string Greet(String lastName,String firstName)
        {
            String userName = lastName + firstName;
            return userName;
        }

        //to decide age even or odd number

        public static int UserRetire(int age)
        {
            int age2 = age % 2;
            int retireAgeEven = 66;
            int retireAgeOdd = 67;
            int yrsToRetire;
            //calculating years retire
            if (age2 == 0)
            {
                yrsToRetire = retireAgeEven - age;
            }
            else
            {
                yrsToRetire = retireAgeOdd - age;
            }

            return yrsToRetire;
        }

        //deciding vacation home
        public static string VactionHome(int sib)
        {
            string vacation;
            if (sib == 0)
            {
                vacation = "Myrtle beach";
            }
            else if (sib == 1)
            {
                vacation = "Big Bear Lake";
            }
            else if (sib == 2)
            {
                vacation = "Bhama Island";
            }
            else if (sib == 3)
            {
                vacation = "Panam city beach";
            }
            else if (sib > 3)
            {
                vacation = "Thousand Island";
            }

            else
            {
                vacation = "desirable place";
            }
            return vacation;
        }


        //Deciding the transportation based on the color
        public static string ModeOfTransport(string color)
        {

            String transport;
                                                
            switch (color)
            {
                case "red":
                    transport = "Scooter";
                    break;
                case "orange":
                    transport = "Private Jet";
                    break;
                case "yellow":
                    transport = "Cruise";
                    break;
                case "green":
                    transport = "Horse";
                    break;
                case "blue":
                    transport = "Bike";
                    break;
                case "indigo":
                    transport = "Bicycle";
                    break;
                case "violet":
                    transport = "Caravan";
                    break;

                default:
                    transport = "Youe Mode of Transporation cannot be decided";
                    break;
            }
            return transport;

        }

        //deciding balance amount  based on birthmonth

        public static double RetireMoney(int birthMonth)
        {
            double balance;

            if ((birthMonth <= 4) && (birthMonth > 0))
            {
                balance = 500000;


            }
            else if ((birthMonth <= 8) && (birthMonth >= 5))
            {
                balance = 100000;

            }
            else if ((birthMonth <= 12) && (birthMonth >= 9))
            {
                balance = 2000000;

            }
            else
            {
                balance = 000;

            }
            return balance;

        }


        public static void FortuneThinks()
        {
            Console.WriteLine("Oooh!That's a good fortune!");
        }

        public static void  Quit(string input)
        {
            if (input == "QUIT")
            {
                Console.WriteLine("you are exiting");
                System.Environment.Exit(0);
            }
            else if (input == "RESTART")
            {
                Console.WriteLine("you are restarting");
                 //Get file path of current process 
                var fileName = Assembly.GetExecutingAssembly().Location;
                 System.Diagnostics.Process.Start(fileName);
                 System.Environment.Exit(0);
               
            }
        }


        
    }
}