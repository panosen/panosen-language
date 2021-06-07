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
        /// <param name="programType"></param>
        /// <param name="nullable"></param>
        /// <returns></returns>
        public static string ToJavaType(this string programType, bool nullable = false)
        {
            switch (programType)
            {
                case ProgramTypeConstant.INT:
                    return nullable ? JavaTypeConstant._INTEGER : JavaTypeConstant.INTEGER;

                case ProgramTypeConstant.BIGINT:
                    return nullable ? JavaTypeConstant._LONG : JavaTypeConstant.LONG;

                case ProgramTypeConstant.DOUBLE:
                    return nullable ? JavaTypeConstant._DOUBLE : JavaTypeConstant.DOUBLE;

                case ProgramTypeConstant.BOOLEAN:
                    return nullable ? JavaTypeConstant._BOOLEAN : JavaTypeConstant.BOOLEAN;

                case ProgramTypeConstant.STRING:
                    return JavaTypeConstant.STRING;

                case ProgramTypeConstant.DATETIME:
                    return JavaTypeConstant.DATE;

                default:
                    return "error_2018082103";
            }
        }
    }
}
