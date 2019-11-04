using System.Data;

namespace Jessidatasyncer.Interfaces
{
    public interface ISync
    {
        void BulkInsert(DataTable outgoingMySql, string table);
        void Update();
        void Create();
        void Delete();
        DataTable Get(string command);
        DataTable GetAll(string sqlStatement);
    }
}