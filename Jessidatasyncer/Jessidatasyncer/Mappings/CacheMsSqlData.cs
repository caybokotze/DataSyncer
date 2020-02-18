using System;
using System.Data;
using System.Linq;
using System.Net.Mime;
using Jessidatasyncer.Domain;
using Jessidatasyncer.Persistence;

namespace Jessidatasyncer.Mappings
{
    public class CacheMsSqlData
    {
        public static void Persist(DataTable mssqlDataTable)
        {
            AppDbContext context = new AppDbContext();
            //
            for (int i = 0; i < mssqlDataTable.Rows.Count; i++)
            {
                //If the roag id does exist in our local db then don't to anything.
                
                if (!context.MsSqlIds.Select(s => s.Id).Any())
                {
                    MsSqlPrimaryCache cache = new MsSqlPrimaryCache();
                    cache.Id = Convert.ToInt32(mssqlDataTable.Rows[i]["RoagId"]);
                    context.MsSqlIds.Add(cache);
                    context.SaveChanges();
                }
            }
        }
    }
}