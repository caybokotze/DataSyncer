using System.Data;
using Jessidatasyncer.Interfaces;

namespace Jessidatasyncer.Logic
{
    public class MySqlSync : ISync
    {
        public MySqlSync(string connectionString)
        {
            _connectionString = connectionString;
        }

        private string _connectionString;
        public void Insert()
        {
            throw new System.NotImplementedException();
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