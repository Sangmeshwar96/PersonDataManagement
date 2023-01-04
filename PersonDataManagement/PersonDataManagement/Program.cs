using System;

namespace PersonDataManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management!");
            List<Person> Personlist = new List<Person>();
            DataManagement.AddPersonDetails(Personlist);
            DataManagement.IteratePersoninList(Personlist);
        }
    }
}