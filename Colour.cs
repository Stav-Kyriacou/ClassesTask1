using System;

namespace ClassesTask1
{
    class Colour
    {
        public int r;
        public int g;
        public int b;
        public string name;

        public Colour(int r, int g, int b, string name)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.name = name;
        }

        public void WriteInfo()
        {
            Console.WriteLine("I am the colour {0}, my RGB value is ({1},{2},{3})", name, r, g, b);
        }
    }
}