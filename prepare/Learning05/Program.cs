using System;

class Program
{
    static void Main(string[] args)
    {  List<Shape> shapes = new List<Shape>(); 
         //SQUARE
        Square sq = new Square(4,"blue");
        shapes.Add(sq);
        //RECTANGLE
        Rectangle rt = new Rectangle(4,5,"yellow");
        shapes.Add(rt);
        //Circle
        Circle cr = new Circle(4,"red");
        shapes.Add(cr);

        foreach(Shape s in shapes)
        {   Console.WriteLine(s.getColor());
            Console.WriteLine(s.GetArea());
        }
    }
}