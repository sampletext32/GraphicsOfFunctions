using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicsNamespace
{
    [Serializable]
    class Numeric_Equation : Equation
    {
        //y = a
        public override float GetValueInPoint(float X)
        {
            return base.OffsetY;
        }
        public override string ToString()
        {
            return "Y = " + (base.OffsetY >= 0 ? " " : "") + base.OffsetY;
        }
        public Numeric_Equation(float OffestY, float FromX, float ToX)
        {
            base.OffsetY = OffsetY;
            base.FromX = FromX;
            base.ToX = ToX;
        }
    }
}
