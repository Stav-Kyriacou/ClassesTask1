using System;

namespace ClassesTask1
{
    class Person
    {
        public string firstName;
        public string surName;
        public string DOB;
        public int height;

        public Person(string firstName, string surName, string DOB, int height)
        {
            this.firstName = firstName;
            this.surName = surName;
            this.DOB = DOB;
            this.height = height;
        }
        public void GetFullName()
        {
            Console.WriteLine("My name is {0} {1}", firstName, surName);
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
    }
}