using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Liskov_Substitution
{
    
    public abstract class Shape
    {
        protected int height;
        protected int width;

        public abstract int GetArea();
    }

    class Rectangle : Shape
    {
        public void SetHeight(int height)
        {
            this.height = height;
        }

        public void SetWidth(int width)
        {
            this.width = width;
        }

        public override int GetArea()
        {
            return width * height;
        }

      
    }

    class Square : Shape
    {
        public void SetSide(int side)
        {
            height = side;
            width = side;
        }

        public override int GetArea()
        {
            return height* width;
        }
    }

}
