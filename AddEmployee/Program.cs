using System;

namespace AddEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            String fName;
            String lName;
            String depName;
            int age;
            Console.WriteLine("------  Add Employee ------\n\n");
            Console.WriteLine("Enter first name");
            fName = Console.ReadLine();
            Console.WriteLine("\nEnter last name");
            lName = Console.ReadLine();
            Console.WriteLine("\nEnter Department name");
            depName = Console.ReadLine();
            bool a = IsAllLetters(fName);
            bool b = IsAllLetters(lName);
            if (a && b)
            {
                Console.WriteLine("----- Employee Details -----\n");
                Console.WriteLine("First name     : " + fName);
                Console.WriteLine("Last name      : " + lName);
                Console.WriteLine("Department name: " + depName);
                Console.WriteLine("\n\n\n");
            }
            else
            {
                Console.WriteLine("\n\nInvalid First name or last name");
            }

            
        }

        public static bool IsAllLetters(String a)
        {
            foreach(char c in a)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
               
            }
            return true;
        }
    }
}
