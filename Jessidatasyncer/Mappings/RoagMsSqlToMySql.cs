using System;
using System.Data;
using System.Globalization;

namespace Jessidatasyncer.Mappings
{
    public class RoagMsSqlToMySql
    {
        public static DataTable GetMySqlMappings(DataTable msSqlRecords)
        {
            DataTable mySqlRecords = new DataTable();
            
            //Create the column rows inside the datatable for the mySqlDatatable.
            Roag_MapUserTableColumns.CreateMySqlColumns(ref mySqlRecords);
            //msSqlRecords = CreateMsSqlColumns();

            for (int i = 0; i < msSqlRecords.Rows.Count; i++)
            {
                //Take the row inside the MsSql Datatable which already exists in a dictionary.
                //Create a row inside the MySql Datatable and then map the values across.
                DataRow msSqlDataRow = msSqlRecords.Rows[i];
                DataRow mySqlDataRow = mySqlRecords.Rows.Add();
                //Map the records across for every value in the dictionary.
                RoagRiderDetailsToUsers.MapRecords(ref mySqlDataRow, ref msSqlDataRow);
                mySqlRecords.Rows.Add(mySqlDataRow);
            }

            return mySqlRecords;
        }
    }
}