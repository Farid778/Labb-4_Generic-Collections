using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_4_Generic_Collections.Models
{
    internal class MenuItem
    {
        // I denna klass använder vi auto-implemented proper
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public MenuItem(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }
    }
}
