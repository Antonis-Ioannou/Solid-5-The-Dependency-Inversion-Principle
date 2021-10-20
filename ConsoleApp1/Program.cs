using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //---before---
            //Person owner1 = new Person
            //{
            //    FirstName = "Jacques",
            //    LastName = "Clouseau",
            //    EmailAddress = "jacques@chiefclouseau.com",
            //    PhoneNumber = "555-1212"
            //};
            //---after---
            IPerson owner1 = Factory.CreatePerson();
            owner1.FirstName = "Jacques";
            owner1.LastName = "Clouseau";
            owner1.EmailAddress = "jacques@chiefclouseau.com";
            owner1.PhoneNumber = "555-1212";

            //---before---
            //Chore chore1 = new Chore
            //{
            //    ChoreName = "Take out the trash",
            //    Owner = owner1
            //};
            //---after---
            IChore chore1 = Factory.CreateChore();
            chore1.ChoreName = "Take out the trash";
            chore1.Owner = owner1;

            chore1.PerformedWork(3);
            chore1.PerformedWork(1.5);
            chore1.CompleteChore();

            Console.ReadLine();
        }
    }
}
