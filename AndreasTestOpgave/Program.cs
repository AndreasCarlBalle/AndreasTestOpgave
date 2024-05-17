using System;
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
        static void Main(string[] args)
        {
            Person person = new Person();

            List<Person> persons = new List<Person>
            {
                new Person(){Name = "Mathias", Age = 18, Address = "Nederen", Job = "Nederen", Birthday = new DateTime(2003,03,03) },
                new Person(){Name = "Andreas", Age = 20, Address = "Frederiksberg", Job = "TEC", Birthday = new DateTime(2004,03,03) },
                new Person(){Name = "Harald Blåtand", Age = 1089, Address = "Jelling", Job = "Konge af Danmark", Birthday = new DateTime(932,04,02) }
            };



            persons.Add(CreateNewPerson());


            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Address);
            Console.WriteLine(person.Job);
            Console.WriteLine(person.Nummer);
            Console.WriteLine(person.Birthday);
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
        //  private static void Hello()
        //{
        // Console.WriteLine("Hej!");
        //}
    }





}



