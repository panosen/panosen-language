using System;

namespace Panosen.Language
{
    /// <summary>
    /// 通用编程语言类型
    /// </summary>
    public static class ProgramTypeConstant
    {
        /// <summary>
        /// INT == int/int?(c#) == int/Integer(java)
        /// </summary>
        public const string INT = "INT";

        /// <summary>
        /// BIGINT == long/long?(c#) == long/Long(java)
        /// </summary>
        public const string BIGINT = "BIGINT";

        /// <summary>
        /// DOUBLE == double/double?(c#) == double/Double(java)
        /// </summary>
        public const string DOUBLE = "DOUBLE";

        /// <summary>
        /// BOOLEAN == bool/bool?(c#) == boolean/Boolean(java)
        /// </summary>
        public const string BOOLEAN = "BOOLEAN";

        /// <summary>
        /// DATETIME = DateTime/DateTime?(c#) == LocalDateTime(java)
        /// </summary>
        public const string DATETIME = "DATETIME";

        /// <summary>
        /// STRING == string(c#) == String(java)
        /// </summary>
        public const string STRING = "STRING";

        /// <summary>
        /// DATETIME = byte[](c#) == byte[](java)
        /// </summary>
        public const string BYTES = "BYTES";

        /// <summary>
        /// DATETIME = decimal(c#) == BigDecimal(java)
        /// </summary>
        public const string DECIMAL = "DECIMAL";
    }
}
