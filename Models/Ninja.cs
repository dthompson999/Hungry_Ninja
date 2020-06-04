using System;
using System.Collections.Generic;

namespace hungry_ninja.Models
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        public Ninja()
        {
            this.calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public bool IsFull
        {
            get
            {
                if (calorieIntake >= 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public void Eat(Food item)
        {
            if (IsFull == false)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"{item.Name}\nCalories: {item.Calories}\nSpicy: {item.IsSpicy}\nSweet: {item.IsSweet}");
                Console.WriteLine($"Ninja's Total Calories: {calorieIntake}");
                
                
            }
            else if (IsFull == true)
            {
                Console.WriteLine("This ninja is filled to the gills!!! STOP FEEDING HIM!!!");
                Console.WriteLine($"***** Ninja's Food History: *****");
                foreach (Food history in FoodHistory)
                {
                    Console.WriteLine(history.Name);
                }
            }
        }
    }
}