using FacadeDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
        class ShapeFactory
        {
            private Circle circle;
            private Square square;
            private Rectangle rectangle;

            public ShapeFactory()
            {
                circle = new Circle();
                square = new Square();
                rectangle = new Rectangle();
            }

            public Circle GetCircle()
            {
                return circle;
            }
            public Square GetSquare()
            {
                return square;
            }
            public Rectangle GetRectangle()
            {
                return rectangle;
            }
        }
    }

