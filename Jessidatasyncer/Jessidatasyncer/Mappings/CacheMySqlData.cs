using System;
using System.Data;
using System.Linq;
using Jessidatasyncer.Domain;
using Jessidatasyncer.Persistence;

namespace Jessidatasyncer.Mappings
{
    public class CacheMySqlData
    {
        public static void Persist(DataTable mysqlDataTable)
        {
            AppDbContext context = new AppDbContext();
            //
            for (int i = 0; i < mysqlDataTable.Rows.Count; i++)
            {
                //If the roag id does exist in our local db then don't to anything.
                
                if (!context.MsSqlIds.Select(s => s.Id).Any())
                {
                    MsSqlPrimaryCache cache = new MsSqlPrimaryCache();
                    cache.Id = Convert.ToInt32(mysqlDataTable.Rows[i]["UserId"]);
                    context.MsSqlIds.Add(cache);
                    context.SaveChanges();
                }
            }
        }
    }
}