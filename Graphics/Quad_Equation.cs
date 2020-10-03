using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsNamespace
{
    [Serializable]
    class Quad_Equation : Equation
    {
        //y=ax*x+bx+c
        public float A
        {
            get;
            set;
        }
        public float B
        {
            get;
            set;
        }
        
        public override string ToString()
        {
            return "Y = " + (A >= 0 ? " " : "") + A + "*" + "X^2" + (B >= 0 ? " + " : " ") + B + "*" + "X" + (base.OffsetY >= 0 ? " + " : " ") + base.OffsetY;
        }
        public override float GetValueInPoint(float X)
        {
            return A * X * X + B * X + base.OffsetY;
        }
        public Quad_Equation(float a, float b, float OffsetY, float FromX, float ToX)
        {
            this.A = a;
            this.B = b;
            base.OffsetY = OffsetY;
            base.FromX = FromX;
            base.ToX = ToX;
        }
    }
}
