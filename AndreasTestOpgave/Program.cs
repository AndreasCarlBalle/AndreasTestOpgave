using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using static MyApp.Program;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp
{
    public class Program
    {
        static List<Person> _persons = null;

        static void Main(string[] args)
        {
            // vi simuler/leger, at vi har hente 3 personer ind fra vores database.
            _persons = new List<Person>
            {
                new Person(){Name = "", Age = 18, Address = "Nederen", Job = "Nederen", Birthday = new DateTime(2003,03,03) },
                new Person(){Name = "Andreas", Age = 20, Address = "Frederiksberg", Job = "TEC", Birthday = new DateTime(2004,03,03) },
                new Person(){Name = "Harald Blåtand", Age = 1089, Address = "Jelling", Job = "Konge af Danmark", Birthday = new DateTime(932,04,02) }
            };

            while (true)
            {
                Menu();
                MenuSelection();
            }
        }

        private static void MenuSelection()
        {
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine("Create Person: Enter Values");
                    _persons.Add(CreateNewPerson());
                    break;
                case 2:
                    Console.WriteLine("View Person: Enter Values");

                   break;
                    case 3:
                    Console.WriteLine("Update Person: Enter Values");
                    break;
                case 4:
                    Console.WriteLine("Delete Person: Enter Values");  
                    break;
            }
        }

        private static void Menu()
        {
            Console.WriteLine("Enter 0 to Exit");
            Console.WriteLine("Enter 1 to Create a person");
            Console.WriteLine("Enter 2 to View all persons");
            Console.WriteLine("Enter 3 to Update a person");
            Console.WriteLine("Enter 4 to Delete a person");
 

        }

        public static Person CreateNewPerson()
        {
            Console.Write("Write your name: ");
            string name = Console.ReadLine();
            Console.Write("Write your age: ");
            int age = Int32.Parse(Console.ReadLine());
            Console.Write("Write your address: ");
            string address = Console.ReadLine();
            Console.Write("Write your job: ");
            string job = Console.ReadLine();
            Console.Write("Write your number: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.Write("Write your birthday: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            Person person = new Person();
            person.Name = name;
            person.Age = age;
            person.Address = address;
            person.Job = job;
            person.Nummer = number;
            person.Birthday = birthday;

            Console.Write("Velkommen " + name + " til ACB's program");
            Console.WriteLine("\n Din alder: " + +age +
                "\n Din addresse: " + address +
                "\n Dit job: " + job +
                "\n Dit nummer: " + number +
                "\n Din fødselsdag: " + birthday);

            return person;
        }

    }

}









