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
        public static string ToCSharpType(this ProgramType programType, bool nullable = false)
        {
            switch (programType)
            {
                case ProgramType.INT:
                    return nullable ? CSharpTypeConstant._INT : CSharpTypeConstant.INT;

                case ProgramType.BIGINT:
                    return nullable ? CSharpTypeConstant._LONG : CSharpTypeConstant.LONG;

                case ProgramType.DOUBLE:
                    return nullable ? CSharpTypeConstant._DOUBLE : CSharpTypeConstant.DOUBLE;

                case ProgramType.BOOLEAN:
                    return nullable ? CSharpTypeConstant._BOOL : CSharpTypeConstant.BOOL;

                case ProgramType.DATETIME:
                    return nullable ? CSharpTypeConstant._DATETIME : CSharpTypeConstant.DATETIME;

                case ProgramType.DECIMAL:
                    return nullable ? CSharpTypeConstant._DECIMAL : CSharpTypeConstant.DECIMAL;

                case ProgramType.STRING:
                    return CSharpTypeConstant.STRING;

                case ProgramType.BYTES:
                    return $"{CSharpTypeConstant.BYTE}[]";

                default:
                    return "Panosen.Language.CSharp.ProgramTypeExtension.ToCSharpType.DEFAULT";
            }
        }
    }
}
