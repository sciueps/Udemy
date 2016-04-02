using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("...") {TimeOut = TimeSpan.FromSeconds(5)};
            var sqlTask = new DbCommand(sqlConnection, "T-SQL");
            sqlTask.Execute();

            Console.WriteLine();

            var oracleConnection = new OracleConnection("...") {TimeOut = TimeSpan.FromSeconds(5)};
            var oracleTask = new DbCommand(oracleConnection,"Oracle");
            oracleTask.Execute();

            Console.ReadKey();

        }
    }
}
