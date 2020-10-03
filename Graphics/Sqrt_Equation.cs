using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsNamespace
{
    [Serializable]
    class Sqrt_Equation : Equation
    {
        //y=sqrt(ax)+b
        public float A
        {
            get;
            set;
        }
        public override float GetValueInPoint(float X)
        {
            if (X >= 0)
            {
                return (float)Math.Sqrt(A*X) + base.OffsetY;
            }
            else
            {
                return float.NaN;
            }
        }
        public override string ToString()
        {
            return "Y = " + "SQRT(" + (A >= 0 ? "" : " - ") + A+ "*" + "X" + ")" + (base.OffsetY >= 0 ? " + " : " - ") + base.OffsetY;
        }
        public Sqrt_Equation(float a, float OffsetY,float FromX, float ToX)
        {
            this.A = a;
            base.OffsetY = OffsetY;
            base.FromX = FromX;
            base.ToX = ToX;
        }
    }
}
