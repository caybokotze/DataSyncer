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
        
        
        public MsSqlSync(string connection)
        {
            ConnectionString = connection;
        }

        string ConnectionString { get;}
        
        public void Insert()
        {
            throw new System.NotImplementedException();
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

        public DataTable GetAll()
        {
            throw new NotImplementedException();
        }

        public DataTable Fetch(string command)
        {
            DataTable result = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.OpenAsync();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command, connection))
                {
                    adapter.Fill(result);
                }
                connection.CloseAsync();
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