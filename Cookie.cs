using System;

namespace ClassesTask1
{
    class Cookie
    {
        int weightGrams;
        string shape;
        Colour colour;

        public Cookie(int weightGrams, string shape, Colour colour)
        {
            this.weightGrams = weightGrams;
            this.shape = shape;
            this.colour = new Colour(colour.r, colour.g, colour.b, colour.name);
        }

        public void WriteInfo()
        {
            Console.WriteLine("I am a {0} cookie and weigh {1} grams. I am {2} with the RGB value of ({3},{4},{5})", shape, weightGrams, colour.name, colour.r, colour.g, colour.b);
        }
    }
}