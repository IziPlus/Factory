using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace Factory
{
    internal class ShapeFactory 
    {
        public static IShape GetShape(Shapes shapeType)
        {
            IShape result;
            switch (shapeType)
            {
                case Shapes.RECTANGLE:
                    result = new Rectangle();
                    break;
                case Shapes.SQUARE:
                    result = new Square();
                    break;
                case Shapes.CIRCLE:
                    result = new Circle();
                    break;
                default:
                    result = new Circle();
                    break;
            }
            return result;
        }
      
    }
}