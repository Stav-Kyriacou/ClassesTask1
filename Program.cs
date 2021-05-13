using System;

namespace ClassesTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Colour red = new Colour(255, 0, 0, "Red");
            Colour blue = new Colour(0, 0, 255, "Blue");

            Cookie cookie1 = new Cookie(100, "circle", red);
            Cookie cookie2 = new Cookie(150, "square", red);
            Cookie cookie3 = new Cookie(125, "star", blue);
            Cookie cookie4 = new Cookie(110, "oval", blue);

            red.WriteInfo();
            blue.WriteInfo();
            cookie1.WriteInfo();
            cookie2.WriteInfo();
            cookie3.WriteInfo();
            cookie4.WriteInfo();

        }
    }
}
