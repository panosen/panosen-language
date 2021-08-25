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
        public static string ToTypescriptType(this ProgramType programType)
        {
            switch (programType)
            {
                case ProgramType.INT:
                case ProgramType.BIGINT:
                case ProgramType.DOUBLE:
                    return TypescriptTypeConstant.NUMBER;
                case ProgramType.STRING:
                    return TypescriptTypeConstant.STRING;
                case ProgramType.DATETIME:
                    return TypescriptTypeConstant.DATE;
                default:
                    return "Panosen.Language.Typescript.ProgramTypeExtension.ToTypescriptType.DEFAULT";
            }
        }
    }
}
