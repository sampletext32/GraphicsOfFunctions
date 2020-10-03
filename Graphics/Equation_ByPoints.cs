using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicsNamespace
{
    [Serializable]
    class Equation_ByPoints : Equation
    {
        public List<PointF> Points = new List<PointF>();
        
        public void AddNewPoint(PointF newpoint)
        {
            Points.Add(newpoint);
            Points = Points.OrderBy(t => t.X).ToList();
        }
        public override string ToString()
        {
            return "Users f(x)";
        }
        public override float GetValueInPoint(float X)
        {
            for (int i = 1; i < Points.Count; i++)
            {
                //(y1 - y2)x+(x2-x1)y + (x1y2-x2y1) = 0
                //y = -(y1-y2)x - (x1y2-x2y1) / (x2-x1)
                if (X > Points[i - 1].X && X < Points[i].X)
                {
                    return -(Points[i - 1].Y - Points[i].Y) * X - (Points[i - 1].X * Points[i].Y - Points[i].X * Points[i - 1].Y) / (Points[i].X - Points[i - 1].X);
                }
            }
            return float.NaN;
        }
        public Equation_ByPoints(float FromX, float ToX)
        {
            base.FromX = FromX;
            base.ToX = ToX;
            Points = new List<PointF>();
        }
    }
}
