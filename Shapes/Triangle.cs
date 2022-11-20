using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    internal class Triangle
    {
        public string name;
        public readonly Color color;
        protected readonly int[] points = new int[3];
        private Point center;

        public int calcCircumference()
        {
            return points[0] + points[1] + points[2];
        }

    }
}