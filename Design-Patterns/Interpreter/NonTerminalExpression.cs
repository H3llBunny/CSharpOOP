using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class NonTerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            // Interpretation logic for non-terminal expression
            context.Output = context.Output * 2;
        }
    }
}
