﻿namespace Restaurant_Project.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Dish>? Dishes { get; set; }
    }
}
