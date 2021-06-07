using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.Language.CSharp
{
    /// <summary>
    /// 类型扩展
    /// </summary>
    public static class ProgramTypeExtension
    {
        /// <summary>
        /// 转换为csharp类型
        /// </summary>
        /// <param name="programType"></param>
        /// <param name="nullable"></param>
        /// <returns></returns>
        public static string ToCSharpType(this string programType, bool nullable = false)
        {
            if (string.IsNullOrEmpty(programType))
            {
                return "PROGRAM_TYPE_IS_NULL";
            }

            switch (programType)
            {
                case ProgramTypeConstant.INT:
                    return nullable ? CSharpTypeConstant._INT : CSharpTypeConstant.INT;

                case ProgramTypeConstant.BIGINT:
                    return nullable ? CSharpTypeConstant._LONG : CSharpTypeConstant.LONG;

                case ProgramTypeConstant.DOUBLE:
                    return nullable ? CSharpTypeConstant._DOUBLE : CSharpTypeConstant.DOUBLE;

                case ProgramTypeConstant.BOOLEAN:
                    return nullable ? CSharpTypeConstant._BOOL : CSharpTypeConstant.BOOL;

                case ProgramTypeConstant.DATETIME:
                    return nullable ? CSharpTypeConstant._DATETIME : CSharpTypeConstant.DATETIME;

                case ProgramTypeConstant.STRING:
                    return CSharpTypeConstant.STRING;

                default:
                    return "Panosen.Language.CSharp.ProgramTypeExtension.ToCSharpType.DEFAULT";
            }
        }
    }
}
