using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Configuration;
using System.Collections;

namespace Adapter
{
    class Program
    {
        public static void Main(DataSet dataSet)
        {
            Console.WriteLine($"DataSet Name :{dataSet.DataSetName}");
            foreach (DictionaryEntry item in dataSet.ExtendedProperties)
            {
                Console.WriteLine($"Key:{item.Key}, Value: {item.Value}");
            }
            foreach (DataTable table in dataSet.Tables)
            {
                Console.WriteLine($"TableName: {table.TableName}");
                foreach (DataColumn column in table.Columns)
                {
                    Console.WriteLine($"{column.ColumnName}");
                }
                Console.WriteLine("--");
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        Console.Write($"{row[column]}\n");
                    }Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
