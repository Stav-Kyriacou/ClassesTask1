using System;

namespace ClassesTask1
{
    class Colour
    {
        float r;
        float g;
        float b;

        string name;

        public Colour(float r, float g, float b, string name)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.name = name;
        }

        public void WriteInfo()
        {
            Console.WriteLine("I am a cookie. My weight: {0}, My shape: {1}", weight, name);
        }
    }
}