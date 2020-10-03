using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsNamespace
{
    class MovingPoint
    {
        Equation way;
        float currentX;
        float FinishX;
        float speed;
        public bool ReachedFinish = false;
        public PointF GetCurrentDisplayPoint()
        {
            return new PointF(currentX, way.GetValueInPoint(currentX));
        }
        public void Move()
        {
            currentX += speed;
            if (currentX >= FinishX)
            {
                ReachedFinish = true;
            }
        }
        public MovingPoint(Equation Way, float startX, float finishX, float Speed)
        {
            this.way = Way;
            this.currentX = startX;
            this.FinishX = finishX;
            this.speed = Speed;
        }
    }
}
