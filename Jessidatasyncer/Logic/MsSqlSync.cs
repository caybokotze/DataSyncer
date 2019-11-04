using System.Data;
using Jessidatasyncer.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace Jessidatasyncer.Logic
{
    public class MsSqlSync : ISync
    {
        
        public MsSqlSync(string connectionString, string table, DataTable outgoing)
        {
            _connectionString = connectionString;
            _table = table;
            _outgoing = outgoing;
        }

        private string _connectionString;
        private string _table;
        private DataTable _outgoing;

        public void BulkInsert(DataTable outgoingMySql, string table)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public DataTable GetAll(string sqlStatement)
        {
            throw new NotImplementedException();
        }

        public DataTable GetDataSetMssql(string sqlStatement, string sDatabase)
        {
            DataTable result = new DataTable();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(sqlStatement, con))
                {
                    da.Fill(result);
                }
                con.Close();
            }
            return result;
        }
    }

    public class KVMapObject
    {
        public int Key { get; set; }
        public string Value { get; set; }
    }
}