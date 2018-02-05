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

        //A derived class does NOT inherit the constructors of the Base class
        //However, the constructors of the bass class can be accessed using the "base" keyword.
        public Rectangle(double area) : base(4)
        {
            this.area = area;
        }


    }
}
