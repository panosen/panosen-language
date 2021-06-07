using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.Language.Mysql
{
    /// <summary>
    /// ProgramTypeExtension
    /// </summary>
    public static class ProgramTypeExtension
    {
        /// <summary>
        /// 转换为mysql类型
        /// </summary>
        public static string ToMysqlColumnType(this string programType, int varcharLength = 100, int decimalMaxSize = 10, int decimalDigitalSize = 0)
        {
            switch (programType)
            {
                case ProgramTypeConstant.INT:
                    return MysqlDataTypeConstant.INT;
                case ProgramTypeConstant.BIGINT:
                    return MysqlDataTypeConstant.BIGINT;
                case ProgramTypeConstant.DOUBLE:
                    return MysqlDataTypeConstant.DOUBLE;
                case ProgramTypeConstant.BOOLEAN:
                    return $"{MysqlDataTypeConstant.TINYINT}(1)";
                case ProgramTypeConstant.DATETIME:
                    return MysqlDataTypeConstant.DATETIME;
                case ProgramTypeConstant.STRING:
                    return $"{MysqlDataTypeConstant.VARCHAR}({varcharLength})";
                case ProgramTypeConstant.BYTES:
                    return MysqlDataTypeConstant.BLOB;
                case ProgramTypeConstant.DECIMAL:
                    return $"{ProgramTypeConstant.DECIMAL}({decimalMaxSize},{decimalDigitalSize})";
                default:
                    return "ProgramTypeExtension.ToMysqlColumnType.NotImplementedException";
            }
        }
    }
}
