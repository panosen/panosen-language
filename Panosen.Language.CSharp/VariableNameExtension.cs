using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.Language.CSharp
{
    /// <summary>
    /// Variable Extension
    /// </summary>
    public static class VariableNameExtension
    {
        /// <summary>
        /// return variable.Value if variable is nullable.
        /// </summary>
        public static string ToCSharpPrimitiveValue(this string value, string programType)
        {
            switch (programType)
            {
                case ProgramTypeConstant.INT:
                case ProgramTypeConstant.BIGINT:
                case ProgramTypeConstant.DOUBLE:
                case ProgramTypeConstant.BOOLEAN:
                case ProgramTypeConstant.DATETIME:
                    return $"{value}.Value";

                case ProgramTypeConstant.STRING:
                default:
                    return value;
            }
        }
    }
}
