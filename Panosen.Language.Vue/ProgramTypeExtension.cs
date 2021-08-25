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
        public static string ToPropType(this ProgramType programType)
        {
            switch (programType)
            {
                case ProgramType.INT:
                case ProgramType.BIGINT:
                case ProgramType.DOUBLE:
                    return PropTypeConstant.NUMBER;

                case ProgramType.BOOLEAN:
                    return PropTypeConstant.BOOLEAN;

                case ProgramType.STRING:
                    return PropTypeConstant.STRING;

                default:
                    return "Panosen.Language.Vue.ProgramTypeExtension.ToPropType.DEFAULT";
            }
        }
    }
}
