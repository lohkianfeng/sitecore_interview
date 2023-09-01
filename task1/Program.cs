namespace HelloWorld
{
    class Point {
        public double X { get; set; }
        public double Y { get; set; }

        public Point (double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Move (double dx, double dy)
        {
            X += dx;
            Y += dy;
        }
        
        public void Rotate(double degree)
        {
            double radians = degree * Math.PI / 180.0;
            double xNew = X * Math.Cos(radians) - Y * Math.Sin(radians);
            double yNew = X * Math.Sin(radians) + Y * Math.Cos(radians);
            X = xNew;
            Y = yNew;
        }
    }

    class Line {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }

        public Line (Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public void Move (double dx, double dy)
        {
            Point1.Move(dx, dy);
            Point2.Move(dx, dy);
        }
        
        public void Rotate(double degree)
        {
            Point1.Rotate(degree);
            Point2.Rotate(degree);
        }
    }

    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public void Move (double dx, double dy)
        {
            Center.Move(dx, dy);
        }

        public void Rotate(double degree)
        {
            Center.Rotate(degree);
        }
    }

    class Aggregation
    {
        private List<Point> points = new List<Point>();
        private List<Line> lines = new List<Line>();
        private List<Circle> circles = new List<Circle>();

        public void AddFigure(Point point)
        {
            points.Add(point);
        }

        public void AddFigure(Line line)
        {
            lines.Add(line);
        }

        public void AddFigure(Circle circle)
        {
            circles.Add(circle);
        }

        public void Move(double dx, double dy)
        {
            foreach (var point in points)
            {
                point.Move(dx, dy);
            }
            foreach (var line in lines)
            {
                line.Move(dx, dy);
            }
            foreach (var circle in circles)
            {
                circle.Move(dx, dy);
            }
        }

        public void Rotate(double angleDegrees)
        {
            foreach (var point in points)
            {
                point.Rotate(angleDegrees);
            }
            foreach (var line in lines)
            {
                line.Rotate(angleDegrees);
            }
            foreach (var circle in circles)
            {
                circle.Rotate(angleDegrees);
            }
    }
}

    class Program {         
        static void Main()
        {
        }
    }
}