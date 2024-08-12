using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.Language.Java
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class ProgramTypeExtension
    {
        /// <summary>
        /// 转换为java类型
        /// </summary>
        public static string ToJavaType(this string programType, bool nullable = false)
        {
            switch (programType)
            {
                case ProgramType.INT:
                    return nullable ? JavaTypeConstant._INTEGER : JavaTypeConstant.INTEGER;

                case ProgramType.BIGINT:
                    return nullable ? JavaTypeConstant._LONG : JavaTypeConstant.LONG;

                case ProgramType.DOUBLE:
                    return nullable ? JavaTypeConstant._DOUBLE : JavaTypeConstant.DOUBLE;

                case ProgramType.BOOLEAN:
                    return nullable ? JavaTypeConstant._BOOLEAN : JavaTypeConstant.BOOLEAN;

                case ProgramType.STRING:
                    return JavaTypeConstant.STRING;

                case ProgramType.DATETIME:
                    return JavaTypeConstant.DATE;

                default:
                    return "Panosen.Language.Java.ProgramTypeExtension.ToJavaType.DEFAULT";
            }
        }
    }
}
