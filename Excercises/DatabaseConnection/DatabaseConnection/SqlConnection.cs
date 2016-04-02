using System;

namespace DatabaseConnection
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Opening Sql connection...");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Sql connection...");
        }
    }
}