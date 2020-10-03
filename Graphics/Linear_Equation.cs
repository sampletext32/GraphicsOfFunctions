using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsNamespace
{
    [Serializable]
    class Linear_Equation : Equation
    {
        //y = kx+b
        public float K
        {
            get;
            set;
        }
        public override float GetValueInPoint(float X)
        {
            return K * X + base.OffsetY;
        }
        public override string ToString()
        {
            return "Y = " + (K >= 0 ? " " : "") + K + "*" +"X" + (base.OffsetY >= 0 ? " + " : " - ") + base.OffsetY;
        }
        public Linear_Equation(float k, float OffsetY, float FromX, float ToX)
        {
            this.K = k;
            base.OffsetY = OffsetY;
            base.FromX = FromX;
            base.ToX = ToX;
        }
    }
}
