using System;

namespace ClassesTask1
{
    class Subject
    {
        public string name;
        public int yearOfDelivery;
        public int grade;

        public Subject(string name, int yearOfDelivery)
        {
            this.name = name;
            this.yearOfDelivery = yearOfDelivery;
        }
        public void WriteInfo()
        {
            Console.WriteLine("Name: {0}, Year of Delivery: {1}", name, yearOfDelivery);
        }
        public void UpdateGrade(int grade)
        {
            this.grade = grade;
        }
    }
}