using System;

namespace Panosen.Language.Typescript
{
    /// <summary>
    /// ProgramType 扩展
    /// </summary>
    public static class ProgramTypeExtension
    {
        /// <summary>
        /// 类型转换
        /// </summary>
        /// <param name="programType"></param>
        /// <returns></returns>
        public static string ToTypescriptType(this string programType)
        {
            switch (programType)
            {
                case ProgramTypeConstant.INT:
                case ProgramTypeConstant.BIGINT:
                case ProgramTypeConstant.DOUBLE:
                    return TypescriptTypeConstant.NUMBER;
                case ProgramTypeConstant.STRING:
                    return TypescriptTypeConstant.STRING;
                case ProgramTypeConstant.DATETIME:
                    return TypescriptTypeConstant.DATE;
                default:
                    return "error_2018082801";
            }
        }
    }
}
