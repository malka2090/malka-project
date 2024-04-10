using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace malka_Project
{
    
        public class Student
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public string UserId { private get; set; }
            public string BirthDate { private get; set; }
            public string FamilyStatus { get; set; }
            public Student(string name, string lastName, string userId, string birthDate, string familyStatus)
            {
                Name = name;
                LastName = lastName;
                UserId = userId;
                BirthDate = birthDate;
                FamilyStatus = familyStatus;
            }

        public string GetUserInput()
        {

            Console.WriteLine("Enter your first name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter your userID: ");
            UserId = Console.ReadLine();
            Console.WriteLine("Enter your BirthDate: ");
            BirthDate = Console.ReadLine();
            Console.WriteLine("Enter your FamilyStatus: ");
            FamilyStatus = Console.ReadLine();
            return ("The Student details: " + 
                    $"{Environment.NewLine}" +
                    $"First Name: " {Name} {Environment.NewLine} +
                    $"Last Name: " {LastName} {Environment.NewLine} +
                    $"UserId : " {UserId} {Environment.NewLine} +
                    $"BirthDate: " {BirthDate} {Environment.NewLine} +
                    $"Family status: " {familyStatus});


             }



        }
    
}
