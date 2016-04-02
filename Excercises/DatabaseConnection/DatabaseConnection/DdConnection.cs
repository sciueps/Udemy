using System;
using System.Data.Common;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }

        public TimeSpan TimeOut { get;  set; }

        protected DbConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new AccessViolationException("devi inserire una stringa valida!");
            }
            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}