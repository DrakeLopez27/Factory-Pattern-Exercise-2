﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "PS5", Price = 500},
            new Product(){Name = "XBox", Price = 350},
            new Product(){Name = "DrumSet", Price = 1000},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo Data Access.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a Mongo Data Access");
        }
    }
}

