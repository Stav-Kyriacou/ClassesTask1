using System;

namespace ClassesTask1
{
    class Cookie
    {
        int weight;
        string name;

        public Cookie(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public void WriteInfo()
        {
            Console.WriteLine("I am a cookie. My weight: {0}, My shape: {1}", weight, name);
        }
    }
}