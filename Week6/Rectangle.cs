using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Rectangle
    {
        private double length;
        private double breadth;


        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Breadth
        {
            get => breadth;
            set => breadth = value;
        }


        public double GetArea => length * breadth;

        public string ShowDetails => $"Length: {length}, Breadth: {breadth}, Area: {GetArea}";


        public double CalculatePerimeter => 2 * (length + breadth);

    }
}