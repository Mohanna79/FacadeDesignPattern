using System;

namespace FacadeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var shapeFactory = new ShapeFactory();
                var circle = shapeFactory.GetCircle();
                circle.Draw();

                var rectangle = shapeFactory.GetRectangle();
                rectangle.Draw();

                var square = shapeFactory.GetSquare();
                square.Draw();
            }
            catch (Exception ex)
            {
                
            }
            Console.ReadLine();
        }
    }
}
