using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Rectangle : Shape
    {
        private double area;

        public double Area
        {
            get { return this.area; }
            set { this.area = value; }
        }

        public Rectangle(double area)
        {
            this.area = area;
        }
    }
}
