using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class snake : figure
    {
        public snake(Point tail, int lenth,  Direction direction)
        {
            pList = new List<Point>();
            for(int i=0; i<lenth;i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }

        }
    }
}
