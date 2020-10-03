using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsNamespace
{
    [Serializable]
    class FromExpresssion_Equation : Equation
    {
        public Expression Expr;
        public override float GetValueInPoint(float X)
        {
            return Expr.GetValueInPoint(X);
        }
        public override string ToString()
        {
            return "Expression Equation : " + Expr.ExpressionString;
        }
        public FromExpresssion_Equation(string Expression)
        {
            Expr = new Expression(Expression);
            base.FromX = -60f;
            base.ToX = 60f;
        }
    }
}
