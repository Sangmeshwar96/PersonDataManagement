using System;

namespace PersonDataManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management!\n");
            List<Person> Personlist = new List<Person>();
            DataManagement.AddPersonDetails(Personlist);
            DataManagement.RetrieveTopTwoRecords(Personlist);
            DataManagement.RetrieveAllDataBetweenAge13To18(Personlist);
            DataManagement.RetrieveAverageAge(Personlist);
        }
    }
}