using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Shape
    {
        private int sides;

        public int Sides
        {
            get { return this.sides; }
            set { this.sides = value; }
        }

        public Shape()
        {

        }

        public Shape (int sides)
        {
            this.sides = sides;
        }

       
    }
}
