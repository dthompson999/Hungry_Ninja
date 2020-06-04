using System;
using System.Collections.Generic;


namespace hungry_ninja.Models
{
    class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Kung Pao Chicken",     350, true, false),
                new Food("Beef & Broccoli",      170, false, false),
                new Food("Char Siu Pork Belly",  400, false, true),
                new Food("Black Pepper Chicken", 200, true, false),
                new Food("Soy Glazed Chicken",   150, false, false),
                new Food("Miso Tofu Soup",        70, false, false),
                new Food("Bi Bim Bap Bowl",      750, true, false),
            
            };
        }
        public Food Serve()
        {
            Random RandomFood = new Random();
            return Menu[RandomFood.Next(Menu.Count)];
        }
    }
}