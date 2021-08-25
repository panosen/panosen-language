using System;

namespace Panosen.Language
{
    /// <summary>
    /// 通用编程语言类型
    /// </summary>
    public enum ProgramType
    {
        /// <summary>
        /// 未配置
        /// </summary>
        None,

        /// <summary>
        /// INT == int/int?(c#) == int/Integer(java)
        /// </summary>
        INT,

        /// <summary>
        /// BIGINT == long/long?(c#) == long/Long(java)
        /// </summary>
        BIGINT,

        /// <summary>
        /// DOUBLE == double/double?(c#) == double/Double(java)
        /// </summary>
        DOUBLE,

        /// <summary>
        /// BOOLEAN == bool/bool?(c#) == boolean/Boolean(java)
        /// </summary>
        BOOLEAN,

        /// <summary>
        /// DATETIME = DateTime/DateTime?(c#) == LocalDateTime(java)
        /// </summary>
        DATETIME,

        /// <summary>
        /// STRING == string(c#) == String(java)
        /// </summary>
        STRING,

        /// <summary>
        /// DATETIME = byte[](c#) == byte[](java)
        /// </summary>
        BYTES,

        /// <summary>
        /// DATETIME = decimal(c#) == BigDecimal(java)
        /// </summary>
        DECIMAL
    }
}
