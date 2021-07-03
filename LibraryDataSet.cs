using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class LibraryDataSet
    {
        public static DataSet CreateDataSet()
        {
            var dataset = new DataSet();

            dataset.ExtendedProperties.Add("DataBase owner", "Surenuah");
            dataset.ExtendedProperties.Add("Data Creation", DateTime.Now);
            dataset.ExtendedProperties.Add("Version", "V1");

            return dataset;
        }

        public static DataSet CreateTables(DataSet dataSet)
        {
            var dataTable = new DataTable();

            var idColumn = new DataColumn("AuthorID", typeof(int))
            {
                AutoIncrement = true,
                AutoIncrementSeed = 0,
                AutoIncrementStep = 1,
                AllowDBNull = false
            };

            var nameColumn = new DataColumn("Name", typeof(string))
            {
                AllowDBNull = false,
                MaxLength = 100
            };

            dataTable.Columns.AddRange(new DataColumn[] { idColumn, nameColumn });

            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns[0] };

            var dataRow = dataTable.NewRow();
            dataRow["Name"] = "Surenuah";

            var dataRow1 = dataTable.NewRow();
            dataRow1["Name"] = "Ergali";

            var dataRow2 = dataTable.NewRow();
            dataRow2["Name"] = "Dias";

            var dataRow3 = dataTable.NewRow();
            dataRow3["Name"] = "Kanat";

            dataTable.Rows.Add(dataRow);
            dataTable.Rows.Add(dataRow1);
            dataTable.Rows.Add(dataRow2);
            dataTable.Rows.Add(dataRow3);

            dataSet.Tables.Add(dataTable);
            return dataSet;
        }

        public static void ShowData(DataSet ds)
        {
            foreach(var table in ds.Tables)
            {
                var tb = (DataTable)table;
                for(int i = 0; i < tb.Columns.Count; i++)
                {
                    Console.WriteLine(tb.Columns[i] + "\t");
                }

                Console.WriteLine();

                for(int j = 0;j < tb.Rows.Count; j++)
                {
                    Console.WriteLine();
                    for(int a = 0; a <  tb.Columns.Count; a++)
                    {
                        Console.WriteLine(tb.Rows[j].ItemArray[a] + "\t");
                    }
                }
            }
        }
    }
}
