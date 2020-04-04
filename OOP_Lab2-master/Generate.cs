using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Generate
    {
        int N = 100;
        Random random = new Random();

        // private Class1 Class = new Class1();


        public  Point2D GetPoint2d()
        {
            double x = random.NextDouble() * N;
            double y = random.NextDouble() * N;
            Point2D p = new Point2D(x, y);
            return p;
        }

        public Triangle GetTriangle()
        {
            Point2D point1 = GetPoint2d();
            Point2D point2 = GetPoint2d();
            Point2D point3 = GetPoint2d();
            Triangle t = new Triangle(point1, point2, point3);
            return t;

        }

        public Rectangle GetRectangle()
        {
            Point2D p = GetPoint2d();
            double h = random.NextDouble() * N;
            double w = random.NextDouble() * N;

            double x1 = p.getX() + w;
            double y1 = p.getY();

            double x2 = p.getX() + w;
            double y2 = p.getY() + h;

            double x3 = p.getX();
            double y3 = p.getY() + h;


            Point2D point1 = new Point2D(x1, y1);
            Point2D point2 = new Point2D(x2, y2);
            Point2D point3 = new Point2D(x3, y3);
            Rectangle r = new Rectangle(p, point1, point2, point3);
            return r;
        }

        public Rectangle GetSquere()
        {
            Point2D p = GetPoint2d();
            double h = random.NextDouble() * N;

            double x1 = p.getX();
            double y1 = p.getY();
            Point2D point1 = new Point2D(x1 + h, y1);
            Point2D point2 = new Point2D(x1 + h, y1 + h);
            Point2D point3 = new Point2D(x1, y1 + h);
            Rectangle r = new Rectangle(p, point1, point2, point3);
            return r;
            /*/ public static Point2D initPoint2D()
             {
                 Point2D point;
                 return point = Point2D.initPoint2D();
             }

             public static Triangle initTriangle()
             {
                 Triangle triangle;
                 return triangle = Triangle.initTriangle();
             }

             public static Rectangle initRectangle()
             {
                 Rectangle rectangle;
                 return rectangle = Rectangle.initRectangle();
             }

             public static Rectangle initRectangleSize(double height, double width)
             {
                 Rectangle rectangle;
                 return rectangle = Rectangle.initRectangleSize(height, width);
             }/*/
        }
    }
}
