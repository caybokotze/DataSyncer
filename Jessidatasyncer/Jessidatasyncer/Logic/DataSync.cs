using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Timers;
using Jessidatasyncer.Mappings;
using Jessidatasyncer.Persistence;


namespace Jessidatasyncer.Logic
{
    public class DataSync
    {
        private ConnectionStringSettingsCollection _connectionStrings = ConfigurationManager.ConnectionStrings;
        
        CultureInfo provider = CultureInfo.InvariantCulture;
        Timer _timer = new Timer();
        private NameValueCollection settings = ConfigurationManager.AppSettings;

        public DataSync()
        {
            
        }
        //1.) Get all mssql data. >> copy to localdb.
        //2.) Get all mysql data. >> copy to localdb.
        //3.) If roag numbers in mssqldb is not in mysqldb, insert that data. Otherwise update that data.

        public void Sync()
        {
            AppDbContext context = new AppDbContext();
            //var lastRecord = context.Records.OrderByDescending(s => s.DateTime).FirstOrDefault();
            //
            MsSqlSync syncObject = new MsSqlSync(_connectionStrings["Local"].ConnectionString, "RiderDetails");
            DataTable riderDetailList = syncObject.GetAll("SELECT RiderDetails.*, Users.password from RiderDetails " +
                             "INNER JOIN Users ON Users.RiderID = RiderDetails.RiderID");
            //
            CacheMsSqlData.Persist(riderDetailList);
            //
            MySqlSync mySqlSync = new MySqlSync(_connectionStrings["Remote"].ConnectionString, "Users");
            DataTable mySqlUsers = mySqlSync.GetAll("SELECT UserId from Users");
            //
            CacheMySqlData.Persist(mySqlUsers);
            //
            DataTable mySqlExport = new DataTable();
            mySqlExport.Columns.Add("id", typeof(string));
            //
            foreach (var item in context.MsSqlIds)
            {
                var mySqlObj = context.MySqlIds.SingleOrDefault(s => s.Id == item.Id.ToString());
                //
                if (mySqlObj == null)
                {
                    DataRow[] results = mySqlExport.Select("RoagId like " + item.Id);
                }
            }
            
            DataTable mySqlMappings = RoagMsSqlToMySql.GetMySqlMappings(riderDetailList);
            MySqlSync mySql = new MySqlSync(_connectionStrings["Outgoing"].ConnectionString, "Users");
            mySql.BulkInsert(mySqlMappings);
            //
            
        }


    }
}