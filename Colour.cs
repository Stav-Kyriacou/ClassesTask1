using System;

namespace ClassesTask1
{
    class Colour
    {
        public float r;
        public float g;
        public float b;
        public string name;

        public Colour(float r, float g, float b, string name)
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