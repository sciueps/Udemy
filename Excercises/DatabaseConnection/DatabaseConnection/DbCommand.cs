using System;

namespace DatabaseConnection
{
    public class DbCommand
    {
        private readonly string _dbInstruction;
        private readonly DbConnection _connection;

        public DbCommand(DbConnection connection, string dbInstruction)
        {
            if (connection == null ) 
            {
                throw new AccessViolationException("No connection found!");
            }
            else if(String.IsNullOrEmpty(dbInstruction))
            {
                throw new AccessViolationException("string passed is null/empty!");
            }
            _connection = connection;
            _dbInstruction = dbInstruction;
        }

        public void Execute()
        {
            _connection.Open();
            Console.WriteLine("Command available for this connection: {0}", _dbInstruction);
            _connection.Close();
        }
    }
}
