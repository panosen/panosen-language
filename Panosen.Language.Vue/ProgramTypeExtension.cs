using System;
using System.Collections.Generic;
using System.Text;

namespace Panosen.Language.Vue
{
    /// <summary>
    /// ProgramType 扩展
    /// </summary>
    public static class ProgramTypeExtension
    {
        /// <summary>
        /// ToPropType
        /// </summary>
        /// <param name="programType"></param>
        /// <returns></returns>
        public static string ToPropType(this string programType)
        {
            switch (programType)
            {
                case ProgramTypeConstant.INT:
                case ProgramTypeConstant.BIGINT:
                case ProgramTypeConstant.DOUBLE:
                    return PropTypeConstant.NUMBER;

                case ProgramTypeConstant.BOOLEAN:
                    return PropTypeConstant.BOOLEAN;

                case ProgramTypeConstant.STRING:
                    return PropTypeConstant.STRING;

                default:
                    return "error_2020010101";
            }
        }
    }
}
