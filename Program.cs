using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalInfoLib;

namespace PersonDataTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persons person = new Persons("Shivam", "Sharma", "shivamkrishnasharma14@gmail.com", Convert.ToDateTime("06-14-2001"));
            Console.WriteLine(person);
            Console.WriteLine(person.ToString());

            Console.WriteLine("******************************************************");

            Console.WriteLine("Persons naame is:"+person.FirstName);
            Console.WriteLine("Person last name is:"+person.LastName);
            Console.WriteLine("Persons emailid is:" + person.EmailID);
            Console.WriteLine("Persons dateofbirth is:" + person.DateOfBirth);
            Console.WriteLine("******************************************************");


            Console.WriteLine("IS person Adult:" + person.iSAdult());

            Console.WriteLine("******************************************************");
            Console.WriteLine("IS person have today birthday:" + person.isTodayBirthDay());

            Console.WriteLine("******************************************************");
            int month = person.DateOfBirth.Month;
            Console.WriteLine("Sun Sign of the person:" + person.isSunSign(month));

            Console.ReadLine();
        }

        


    }
}
