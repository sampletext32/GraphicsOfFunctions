using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsNamespace
{
    [Serializable]
    class Expression
    {
        public string ExpressionString
        {
            get;
            set;
        }
        public float GetValueInPoint(float X)
        {
            return GetExprValue(ExpressionString, X);
        }
        private static float GetExprValue(string expression, float X)
        {
            float outX = 0;
            
            if (expression.IndexOf('+') > 0)
            {
                string leftexpr = expression.Substring(0, expression.IndexOf('+'));
                string rightexpr = expression.Substring(expression.IndexOf('+') + 1, expression.Length - expression.IndexOf('+') - 1);

                float leftexprvalue = GetExprValue(leftexpr, X);
                float rightexprvalue = GetExprValue(rightexpr, X);
                return leftexprvalue + rightexprvalue;
            }
            else if (expression.IndexOf('-') > 0)
            {
                string leftexpr = expression.Substring(0, expression.IndexOf('-'));
                string rightexpr = expression.Substring(expression.IndexOf('-') + 1, expression.Length - expression.IndexOf('-') - 1);

                float leftexprvalue = GetExprValue(leftexpr, X);
                float rightexprvalue = GetExprValue(rightexpr, X);
                return leftexprvalue + rightexprvalue;
            }
            else if (expression.IndexOf('*') > 0)
            {
                string leftexpr = expression.Substring(0, expression.IndexOf('*'));

                string rightexpr = expression.Substring(expression.IndexOf('*') + 1, expression.Length - expression.IndexOf('*') - 1);

                float leftexprvalue = GetExprValue(leftexpr, X);
                float rightexprvalue = GetExprValue(rightexpr, X);
                return leftexprvalue * rightexprvalue;
            }
            else if (expression.IndexOf('/') > 0)
            {
                string leftexpr = expression.Substring(0, expression.IndexOf('/'));

                string rightexpr = expression.Substring(expression.IndexOf('/') + 1, expression.Length - expression.IndexOf('/') - 1);

                float leftexprvalue = GetExprValue(leftexpr, X);
                float rightexprvalue = GetExprValue(rightexpr, X);
                return leftexprvalue / rightexprvalue;
            }
            else if (expression.IndexOf('^') > 0)
            {
                string leftexpr = expression.Substring(0, expression.IndexOf('^'));

                string rightexpr = expression.Substring(expression.IndexOf('^') + 1, expression.Length - expression.IndexOf('^') - 1);

                float leftexprvalue = GetExprValue(leftexpr, X);
                float rightexprvalue = GetExprValue(rightexpr, X);
                return (float)Math.Pow(leftexprvalue, rightexprvalue);
            }
            else if (float.TryParse(expression, out outX))
            {
                return outX;
            }
            else if (expression == "x")
            {
                return X;
            }
            else
            {
                throw new Exception("UNABLE TO PARSE");
            }
        }
        public Expression(string ExpressionString)
        {
            this.ExpressionString = ExpressionString;
        }
    }
}