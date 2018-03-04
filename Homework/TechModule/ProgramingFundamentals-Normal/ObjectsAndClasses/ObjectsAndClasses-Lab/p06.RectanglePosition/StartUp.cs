namespace p06.RectanglePosition
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Rectangle r1 = ReadRectangle(), r2 = ReadRectangle();
            Console.WriteLine(r1.IsInside(r2) ? "Inside" :
              "Not inside");

        }

        public class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int Right { get { return Left + Width; } }
            public int Bottom { get { return Top + Height; } }
        
            public bool IsInside(Rectangle other)
            {
                var isInLeft = Left >= other.Left;
                var isInRight = Right <= other.Right;
                var isInsideHorizontal = isInLeft && isInRight;
                var isInTop = Top >= other.Top;
                var isInBottom = Bottom <= other.Bottom;
                var isInsideVertical = isInTop && isInBottom;
                return isInsideHorizontal && isInsideVertical;
            }
        }

        public static Rectangle ReadRectangle()
        {
            var size = Console.ReadLine().Split().Select(int.Parse);
            Rectangle rectangle = new Rectangle()
            {
                Left = size.First(),
                Top = size.Skip(1).First(),
                Width = size.Skip(2).First(),
                Height = size.Skip(3).First()
            };
            return rectangle;
        }
    }
}
