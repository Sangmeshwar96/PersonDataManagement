using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    class DataManagement
    {
        //Add Default values to list
        public static void AddPersonDetails(List<Person> Personlist)
        {
            Personlist.Add(new Person() { SSN = 1, Name = "Pramod", Address = "Delhi", Age = 25 });
            Personlist.Add(new Person() { SSN = 2, Name = "Vijay", Address = "Nagpur", Age = 65 });
            Personlist.Add(new Person() { SSN = 3, Name = "Sachin", Address = "Jaipur", Age = 23 });
            Personlist.Add(new Person() { SSN = 4, Name = "Ajay", Address = "Mumbai", Age = 18 });
            Personlist.Add(new Person() { SSN = 5, Name = "Samir", Address = "Pune", Age = 16 });
            Personlist.Add(new Person() { SSN = 6, Name = "Sumit", Address = "Latur", Age = 68 });
        }
        //display Person details in the List
        public static void IteratePersoninList(List<Person> Personlist)
        {
            foreach (Person person in Personlist)
            {
                Console.WriteLine("SSN={0}\tName={1}\tAddress={2}\tAge={3})", person.SSN, person.Name, person.Address, person.Age);
            }
        }
    }
}
