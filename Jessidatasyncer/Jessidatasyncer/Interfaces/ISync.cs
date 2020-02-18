using System.Data;

namespace Jessidatasyncer.Interfaces
{
    public interface ISync
    {
        void BulkInsert(DataTable outgoingMySql);
        void BulkUpdate(DataTable outgoingMySql);
        void Delete();
        DataTable GetAll(string sqlStatement);
    }
}