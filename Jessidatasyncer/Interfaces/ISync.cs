using System.Data;

namespace Jessidatasyncer.Interfaces
{
    public interface ISync
    {
        void Insert();
        void Update();
        void Create();
        void Delete();
        DataTable Get(string command);
        DataTable GetAll();
    }
}