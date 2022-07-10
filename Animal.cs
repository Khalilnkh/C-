using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Animals
    {
        public string? name;
        public string? color;
        public byte age;

        public Animals(string n, string c, byte a)
        {
            name = n;
            color = c;
            age = a;
        }

        public string GetFullDeatials()
        {
            return $"{name} {color} {age}";
        }
    }
}
