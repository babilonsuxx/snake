﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLines
    {
        List<Point> pList;
        public VerticalLines(int yMin, int yMax, int x, char sym) 
        {
            pList = new List<Point>();
            for (int y = yMin;y<=yMax; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
           }
        }
        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
   
    }
}
