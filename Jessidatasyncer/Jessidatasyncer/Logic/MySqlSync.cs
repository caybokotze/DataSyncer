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
        //
        
        //
        public MySqlSync(string connectionString, string table)
        {
            _connectionString = connectionString;
            _table = table;
        }
        //
        private string _connectionString;
        private string _table;

        private DataTable _outgoing;
        //
        public void BulkInsert(DataTable outgoingMySql)
        {
            using (MySqlConnection con = new MySqlConnection(_connectionString))
            {
                con.Open();
                using (MySqlDataAdapter da = new MySqlDataAdapter($"select * from "+ _table + " limit 1", con))
                {
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                    da.InsertCommand = builder.GetInsertCommand();
                    da.Update(_outgoing);
                }
                con.Close();
            }
        }
        
        public void BulkUpdate(DataTable outgoingMySql)
        {
            using (MySqlConnection con = new MySqlConnection(_connectionString))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter($"select * from " + _table + " limit 1", con))
                {
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                    da.UpdateCommand = builder.GetUpdateCommand();
                    da.Update(_outgoing);
                }
                con.Close();
            }
        }
        
        public void Delete()
        {
            throw new System.NotImplementedException();
        }
        public DataTable GetAll(string sqlStatement)
        {
            DataTable result = new DataTable();
            using (MySqlConnection con = new MySqlConnection(_connectionString))
            {
                con.Open();
                using (MySqlDataAdapter da = new MySqlDataAdapter(sqlStatement, con))
                {
                    da.Fill(result);
                }
                con.Close();
            }
            return result;
        }
        
    }
}