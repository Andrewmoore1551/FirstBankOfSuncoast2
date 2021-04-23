using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace FirstBankOfSuncoast2
{
    class Transaction
    {
        public string Type { get; set; }
        public string Account { get; set; }
        public int Amount { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to First Bank Of Suncoast");
            Console.WriteLine();

            var fileReader = new StreamReader("transactions.csv");
            var csvReader = new CsvReader(fileReader, CultureInfo.InvariantCulture);
            var transactions = csvReader.GetRecords<Transaction>().ToList();
            fileReader.Close();


        }
    }
}
