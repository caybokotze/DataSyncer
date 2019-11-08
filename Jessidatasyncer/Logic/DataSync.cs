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

        public void Sync()
        {
            AppDbContext context = new AppDbContext();
            var lastRecord = context.Records.OrderByDescending(s => s.DateTime).FirstOrDefault();
            //
            //
            MsSqlSync syncObject = new MsSqlSync(_connectionStrings["Local"].ConnectionString, "RiderDetails");
            DataTable riderDetailList = syncObject.GetAll("SELECT RiderDetails.*, Users.password from RiderDetails " +
                             "INNER JOIN Users ON Users.RiderID = RiderDetails.RiderID " +
                             "WHERE " +
                             "LastUpdated > '" + lastRecord.DateTime + "'");
            //
            DataTable mySqlMappings = RoagMsSqlToMySql.GetMySqlMappings(riderDetailList);
            MySqlSync mySql = new MySqlSync(_connectionStrings["Outgoing"].ConnectionString, "Users");
            
            mySql.BulkInsert(mySqlMappings);
        }


    }
}