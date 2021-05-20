using System;

namespace ClassesTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------TASK 1-------------------------------------------

            //instantiate colours
            Colour red = new Colour(255, 0, 0, "Red");
            Colour blue = new Colour(0, 0, 255, "Blue");

            //instantiate cookies with colours
            Cookie cookie1 = new Cookie(100, "circle", red);
            Cookie cookie2 = new Cookie(150, "square", red);
            Cookie cookie3 = new Cookie(125, "star", blue);
            Cookie cookie4 = new Cookie(110, "oval", blue);

            //write the info of colours and cookies
            red.WriteInfo();
            blue.WriteInfo();
            cookie1.WriteInfo();
            cookie2.WriteInfo();
            cookie3.WriteInfo();
            cookie4.WriteInfo();

            Console.WriteLine();

            //---------------------------------TASK 2-------------------------------------------

            //Instantiate people
            Person stavros = new Person("Stavros", "Kyriacou", "26/01/1999", 180);
            Person someone = new Person("Someone", "Somebody", "01/01/2021", 170);
            Person bibius = new Person("Bibius", "Maximus", "01/01/2021", 185);

            //Write their names
            stavros.GetFullName();
            someone.GetFullName();
            bibius.GetFullName();
            Console.WriteLine();

            //Write their height differences
            stavros.GetHeightDifference(someone);
            stavros.GetHeightDifference(bibius);
            someone.GetHeightDifference(bibius);
            Console.WriteLine();


            //Instantiate subjects
            Subject programming = new Subject("Programming", 2021);
            Subject database = new Subject("Database", 2021);
            Subject webProgramming = new Subject("Web Programming", 2021);

            //Add some subjects to a person
            stavros.EnrolInSubject(programming);
            stavros.EnrolInSubject(database);
            stavros.EnrolInSubject(webProgramming);

            //Give grades for each subject
            stavros.subjects[0].UpdateGrade(100);
            stavros.subjects[1].UpdateGrade(100);
            stavros.subjects[2].UpdateGrade(100);

            //List the subjects a person has enrolled in
            stavros.ListAllSubjects();
            Console.WriteLine();

            //List the grades for each subject they've enrolled in
            stavros.DisplayGrades();
        }
    }
}
