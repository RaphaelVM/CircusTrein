﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Wagon
    {
        private int _size = 10;
        private List<Animal> allAnimals;

        public Wagon()
        {
            allAnimals = new List<Animal>();
        }

        public int GetSize()
        {
            return _size;
        }

        public string AnimalsInWagon()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Animal animal in allAnimals)
            {
                sb.Append($"{animal.GetName()} ");
            }

            return sb.ToString();
        }
    }
}
