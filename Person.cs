using System;
using System.Collections.Generic;

namespace ClassesTask1
{
    class Person
    {
        public string firstName;
        public string surName;
        public string DOB;
        public int height;
        public int ID;
        public List<Subject> subjects = new List<Subject>();

        public Person(string firstName, string surName, string DOB, int height)
        {
            this.firstName = firstName;
            this.surName = surName;
            this.DOB = DOB;
            this.height = height;

            Random rand = new Random();
            ID = rand.Next(1000, 10000);
        }
        public void GetFullName()
        {
            Console.WriteLine("My name is {0} {1}. My ID is: {2}", firstName, surName, ID);
        }
        public void GetHeightDifference(Person other)
        {
            if (height > other.height)
            {
                Console.WriteLine("{0} {1} is taller than {2} {3} by {4}cm", firstName, surName, other.firstName, other.surName, height - other.height);
            }
            else
            {
                Console.WriteLine("{0} {1} is taller than {2} {3} by {4}cm", other.firstName, other.surName, firstName, surName, other.height - height);
            }
        }
        public void EnrolInSubject(Subject subject)
        {
            subjects.Add(subject);
        }
        public void ListAllSubjects()
        {
            Console.WriteLine("The subjects {0} has enrolled in are: ", firstName);
            foreach (Subject subj in subjects)
            {
                subj.WriteInfo();
            }
        }
        public void UpdateGrade(int subjectIndex, int grade)
        {
            subjects[subjectIndex].UpdateGrade(grade);
        }
        public void DisplayGrades()
        {
            Console.WriteLine("Displaying {0}'s grades...", firstName);
            foreach (Subject subj in subjects)
            {
                Console.WriteLine("{0}: {1}", subj.name, subj.grade);
            }
        }
    }
}