namespace Escape_from_Labyrinth
{
    public class Point
    {
//        public Point(int x, int y)
//        {
//            this.X = x;
//            this.Y = y;
//        }
//
//        public Point(
//            int x, 
//            int y, 
//            string direction, 
//            Point previousPoint)
//            : this(x, y)
//        {
//            this.Direction = direction;
//            this.PreviousPoint = previousPoint;
//        }

        public int X { get; set; }

        public int Y { get; set; }

        public string Direction { get; set; }

        public Point PreviousPoint { get; set; }
         
    }
}