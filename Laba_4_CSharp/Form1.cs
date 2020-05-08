using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Laba_4_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnect();
            
        }
        public SQLiteConnection Connection;
        void SqlConnect()
        {
            Connection = new SQLiteConnection("Data Source = AstroDatabase.db; Version = 3");
            if (!File.Exists("./AstroDatabase.db"))
            {
                SQLiteConnection.CreateFile("AstroDatabase.db");
            }

            string Query = "INSERT INTO Галактики ('Номер галактики','Название галактики','Количество объектов') VALUES (@num, @name, @valu)";
            SQLiteCommand Command = new SQLiteCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.AddWithValue("@num", "1");
            Command.Parameters.AddWithValue("@name", "Рассия");
            Command.Parameters.AddWithValue("@valu", "1233123");
            Command.ExecuteNonQuery();
            Connection.Close();
           
        }
      
    }
}
