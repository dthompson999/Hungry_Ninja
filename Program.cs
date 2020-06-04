using System;
using hungry_ninja.Models;

namespace hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja skinnyNinja = new Ninja();
            Buffet buffet = new Buffet();
            while (!skinnyNinja.IsFull)
            {
                skinnyNinja.Eat(buffet.Serve());
            }
            skinnyNinja.Eat(buffet.Serve());
        }
    }
}
