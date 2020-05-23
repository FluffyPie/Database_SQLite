using System.Data.SQLite;
using System.IO;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba_4_CSharp;
using System;

namespace Laba_4_CSharp_Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void CheckAdd()
        {
            SQLiteConnection Connection;
            Connection = new SQLiteConnection("Data Source = AstroDatabase.db; Version = 3");
            if (!File.Exists("./AstroDatabase.db"))
            {
                SQLiteConnection.CreateFile("AstroDatabase.db");
            }

            string CreateTable = "CREATE TABLE IF NOT EXISTS [Галактики] ( [Номер галактики] INTEGER, [Название галактики] VARCHAR(45), [Количество объектов ] INTEGER)";
            SQLiteCommand Command = new SQLiteCommand(CreateTable, Connection);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();

            DataTable Table = new DataTable();
            SQLiteDataAdapter Adapter = new SQLiteDataAdapter("SELECT * FROM Галактики", Connection);
            Adapter.Fill(Table);
            int ExpecterRowCount = Table.Rows.Count + 1 ;
            MainForm MainForm = new MainForm();
            int GalacticNumber = Table.Rows.Count + 1;
            string GalacticName = "TestName";
            int NumberOfObjects = 15;
            Assert.AreEqual(ExpecterRowCount, MainForm.AddToGalactic(GalacticNumber, GalacticName, NumberOfObjects));
        }   
    }
}
