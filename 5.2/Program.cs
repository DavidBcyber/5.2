using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class Program
    {
        // using the data to manage students grades
        static List<string> contact = new List<string>(); // list of grades
        private static IEnumerable<KeyValuePair<string, double>> number;

        static void Main(string[] args)
        {
            int contact = 0; // user input

            //user gets ask what differnt type of method whould they like to use
            Console.WriteLine("Welcome to grade managament application");

            while (true) // loop
            {

                Console.WriteLine("1. Add Contact\n " +
                   "2. Remove Contact\n " +
                   "3. Search Contact\n " +
                   "4. Display Contact\n " +
                   "5. Exit\n");
               
                Console.WriteLine("Enter your choice:");
                contact = Convert.ToInt32(Console.ReadLine());
                // import of the menu

                switch (contact)
                {
                          case 1:
                        // add grade
                        AddContact();
                        break;
                    case 2:
                        // remove grade
                        RemoveContact();
                        break;
                    case 3:
                        // display grade
                        SearchContact();
                        break;
                    case 4:
                        // average
                        DisplayAllContact();
                        break;
                    case 5:
                        //Exit
                        return; // leave site
                    default:
                        //invaild option
                        Console.WriteLine("Invaild Option");
                        break;
                }



            }
        }
        // way to add contact
        static void AddContact()
        {
            Console.WriteLine("Enter contact name to add");
            string name = Console.ReadLine();

            Console.WriteLine("Enter phone number:");
            string number = Console.ReadLine();

            contact.Add(name); // add contact to the system
            Console.WriteLine(number + "contact added successfully");
        }
        static void RemoveContact()
        {
            Console.WriteLine("Enter the contact number to be removed");
            string grade = Console.ReadLine();
            if (contact.Contains(grade))
            {
                contact.Remove(grade);
                Console.WriteLine(grade + "is removed form the system");
            }
            else
            {
                Console.WriteLine(grade + "The contact is not in the system");
            }
        }
        static void SearchContact()
        {
            Console.WriteLine("Enter a conatct phone numebr to search");

            double contact = Convert.ToDouble(Console.ReadLine());
            int count = 0;
            foreach (KeyValuePair<string, double> number in number)
            {
                if (number.Value == contact)
                {
                    Console.WriteLine(number.Key + "---" + number.Value);
                    count++;
                }

            }

            if (count == 0)
            {
                Console.WriteLine("There is no contact info in the system " + contact );
            }

        }
        static void DisplayAllContact()
        {
            Console.WriteLine("Here is all phone numbers in the contact");
            foreach (string number in contact)
            {
                Console.WriteLine("*" + number);
            }
        }
        }
}
