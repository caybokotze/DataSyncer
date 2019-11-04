using System.Data;
using Jessidatasyncer.Interfaces;
using MySql.Data.MySqlClient;

namespace Jessidatasyncer.Logic
{
    public class MySqlSync : ISync
    {
        public MySqlSync(string connectionString)
        {
            _connectionString = connectionString;
        }

        private string _connectionString;
        
        public void Insert(DataTable outgoingMySql, string table)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionStrings[sDatabase].ConnectionString))
            {
                con.Open();
                using (MySqlDataAdapter da = new MySqlDataAdapter($"select * from "+ table + " limit 1", con))
                {
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                    da.InsertCommand = builder.GetInsertCommand();
                    da.Update(dtRemoteData);
                }
                con.Close();
            }
        }

        public void InsertAll(DataTable list)
        {
            
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }

        public void Create()
        {
            throw new System.NotImplementedException();
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public DataTable Get(string command)
        {
            throw new System.NotImplementedException();
        }

        public DataTable GetAll()
        {
            throw new System.NotImplementedException();
        }
        
    }
}