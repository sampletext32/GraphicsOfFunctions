using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsNamespace
{
    [Serializable]
    public class Equation
    {
        public float OffsetY = 0f;
        public float FromX;
        public float ToX;
        private Color _pen = Color.Black;
        public Pen DrawPen
        {
            get
            {
                return new Pen(_pen, 3);
            }
            set
            {
                _pen = value.Color;
            }
        }
        public virtual float GetValueInPoint(float X)
        {
            return 0;
        }
    }
}
