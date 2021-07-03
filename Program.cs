using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSet = LibraryDataSet.CreateDataSet();

            LibraryDataSet.CreateTables(dataSet);

            LibraryDataSet.ShowData(dataSet);
        }
    }
}
