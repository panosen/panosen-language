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
        public static string ToMysqlColumnType(this ProgramType programType, int varcharLength = 100, int decimalMaxSize = 10, int decimalDigitalSize = 0)
        {
            switch (programType)
            {
                case ProgramType.INT:
                    return MysqlDataTypeConstant.INT;
                case ProgramType.BIGINT:
                    return MysqlDataTypeConstant.BIGINT;
                case ProgramType.DOUBLE:
                    return MysqlDataTypeConstant.DOUBLE;
                case ProgramType.BOOLEAN:
                    return $"{MysqlDataTypeConstant.TINYINT}(1)";
                case ProgramType.DATETIME:
                    return MysqlDataTypeConstant.DATETIME;
                case ProgramType.STRING:
                    return $"{MysqlDataTypeConstant.VARCHAR}({varcharLength})";
                case ProgramType.BYTES:
                    return MysqlDataTypeConstant.BLOB;
                case ProgramType.DECIMAL:
                    return $"{ProgramType.DECIMAL}({decimalMaxSize},{decimalDigitalSize})";
                default:
                    return "Panosen.Language.Mysql.ProgramTypeExtension.ToMysqlColumnType.DEFAULT";
            }
        }
    }
}
