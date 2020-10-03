using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsNamespace
{
    [Serializable]
    class Giperbolic_Equation : Equation
    {
        //y=a/x+b
        public float A
        {
            get;
            set;
        }
        public override float GetValueInPoint(float X)
        {
            return A / X + base.OffsetY;
        }
        public override string ToString()
        {
            return "Y = " + (A >= 0 ? " " : "") + A + " / " + "X" + (base.OffsetY >= 0 ? " + " : " - ") + base.OffsetY;
        }
        public Giperbolic_Equation(float a, float OffsetY, float FromX, float ToX)
        {
            this.A = a;
            base.OffsetY = OffsetY;
            base.FromX = FromX;
            base.ToX = ToX;
        }
    }
}
