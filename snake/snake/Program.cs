using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(81, 25);
            HorizontalLines upLine = new HorizontalLines(1, 78, 0, '+');
            HorizontalLines downLine = new HorizontalLines(1, 78, 24, '+');
            VerticalLines leftLine = new VerticalLines(1, 24, 78, '+');
            VerticalLines rightLine = new VerticalLines(1, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();
            Point p = new Point(4, 5, '*');
            snake snake = new snake(p, 4, Direction.Right);
            snake.Drow();

            Console.ReadLine();
        }
    }
}
