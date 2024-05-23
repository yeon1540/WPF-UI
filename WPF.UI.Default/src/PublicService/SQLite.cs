using System.Data.SQLite;
using System;

namespace PublicService
{
    public class SQLite
    {
        /// <summary>
        /// 접속할 해당 DB 경로를 기입한다.
        /// </summary>
        /// <param name="sDB_Path"></param>
        public bool DBConn(string sDB_Path) 
        {
            bool result = false;

            if (string.IsNullOrEmpty(sDB_Path))
            {
                throw new InvalidOperationException("Environment variable DEMO_DB_PATH is not set.");
            }

            var connectionString = $"Data Source={sDB_Path};Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
