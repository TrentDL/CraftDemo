using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrentCraftingDemo
{
    public class Person
    {
        private string name;
        private double Currency = 10.50;

        public string Name
        {
            get => name;
            set => name = value;

        }
        //list inventory - item
        public List<Item> Inventory = new List<Item>();

        public void Craft()
        {
            throw new System.NotImplementedException();
        }

        public string Information()
        {
            return $"{name} {Currency.ToString("c")}";
        }



    }
}