using System;
using System.Collections.Concurrent;

namespace DatabaseConnection
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Opening Oracle connection...");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle connection...");
        }
    }
}