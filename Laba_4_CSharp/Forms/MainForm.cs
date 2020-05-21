using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System.ComponentModel;
using System;
using System.Drawing;

namespace Laba_4_CSharp
{
    public partial class MainForm : Form
    {
        public SQLiteConnection Connection;
        public MainForm()
        {
            InitializeComponent();
            SqlConnect();
            ShowTableGalactics();
            this.Width = 832;
            this.Height = 446;
        }
        
        void SqlConnect()
        {
            Connection = new SQLiteConnection("Data Source = AstroDatabase.db; Version = 3");
            if (!File.Exists("./AstroDatabase.db"))
            {
                SQLiteConnection.CreateFile("AstroDatabase.db");
            }
           
           
        }
        void ShowTableGalactics()
        {
            GalacticTable.Rows.Clear();
            Connection.Open();
            string sqlQuery = "SELECT * FROM Галактики";
            SQLiteDataAdapter SQLAdapter = new SQLiteDataAdapter(sqlQuery, Connection);
            DataTable Table = new DataTable();
            SQLAdapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                for (int i = 0; i < Table.Rows.Count; i++)
                    GalacticTable.Rows.Add(Table.Rows[i].ItemArray);
            }
            GalacticTable.Sort(GalacticTable.Columns[0], ListSortDirection.Ascending);
            Connection.Close();
        }
        void ShowTableStars()
        {
            StarsTable.Rows.Clear();
            Connection.Open();
            string sqlQuery = "SELECT * FROM Звезды";
            SQLiteDataAdapter SQLAdapter = new SQLiteDataAdapter(sqlQuery, Connection);
            DataTable Table = new DataTable();
            SQLAdapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                for (int i = 0; i < Table.Rows.Count; i++)
                    StarsTable.Rows.Add(Table.Rows[i].ItemArray);
            }
            StarsTable.Sort(StarsTable.Columns[0], ListSortDirection.Ascending);
            Connection.Close();
        }
        void ShowTablePlanets()
        {
            PlanetsTable.Rows.Clear();
            Connection.Open();
            string sqlQuery = "SELECT * FROM Планеты";
            SQLiteDataAdapter SQLAdapter = new SQLiteDataAdapter(sqlQuery, Connection);
            DataTable Table = new DataTable();
            SQLAdapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                for (int i = 0; i < Table.Rows.Count; i++)
                    PlanetsTable.Rows.Add(Table.Rows[i].ItemArray);
            }
            PlanetsTable.Sort(PlanetsTable.Columns[0], ListSortDirection.Ascending);
            Connection.Close();
        }

        private void SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (Tabs.SelectedTab == GalacticsTab)
            {
                ShowTableGalactics();
                GalacticHideControl();
                PlanetsHideControl();
                StarsHideControl();
            }
            else if (Tabs.SelectedTab == StarsTab)
            {
                ShowTableStars();
                GalacticHideControl();
                PlanetsHideControl();
                StarsHideControl();
            }
            else
            {
                ShowTablePlanets();
                GalacticHideControl();
                PlanetsHideControl();
                StarsHideControl();
            }
        }

        private void CollapseButton_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteButtonStars_Click(object sender, System.EventArgs e)
        {
            Connection.Open();
            string CommandText = "DELETE FROM [Звезды] WHERE [Номер звезды] = @starnumber AND [Название звезды] = @starname AND [Размер звезды] = @starsize AND [Удаленность от земли (св лет)] = @starfar AND [Масса звезды] = @starmass";

            SQLiteCommand DeleteComand = new SQLiteCommand(CommandText, Connection);

            DeleteComand.Parameters.AddWithValue("@starnumber", StarsTable[0, StarsTable.SelectedCells[0].RowIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@starname", StarsTable[1, StarsTable.SelectedCells[0].RowIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@starsize", StarsTable[2, StarsTable.SelectedCells[0].RowIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@starfar", StarsTable[3, StarsTable.SelectedCells[0].RowIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@starmass", StarsTable[4, StarsTable.SelectedCells[0].RowIndex].Value.ToString());
            DeleteComand.ExecuteNonQuery();
            Connection.Close();
            int DeleteFromTable = StarsTable.SelectedCells[0].RowIndex;
            StarsTable.Rows.RemoveAt(DeleteFromTable);
            ShowTableStars();
        }

        private void PlanetsDeleteButton_Click(object sender, System.EventArgs e)
        {
            Connection.Open();
            string CommandText = "DELETE FROM [Планеты] WHERE [Номер планеты] = @planetnumber AND [Название планеты] = @planetname AND [Масса планеты] = @planetmass AND [Размер планеты] = @planetsize";

            SQLiteCommand DeleteComand = new SQLiteCommand(CommandText, Connection);

            DeleteComand.Parameters.AddWithValue("@planetnumber", PlanetsTable[0, PlanetsTable.SelectedCells[0].RowIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@planetname", PlanetsTable[1, PlanetsTable.SelectedCells[0].RowIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@planetmass", PlanetsTable[2, PlanetsTable.SelectedCells[0].RowIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@planetsize", PlanetsTable[3, PlanetsTable.SelectedCells[0].RowIndex].Value.ToString());
            DeleteComand.ExecuteNonQuery();
            Connection.Close();
            int DeleteFromTable = PlanetsTable.SelectedCells[0].RowIndex;
            PlanetsTable.Rows.RemoveAt(DeleteFromTable);
            ShowTableStars();
        }

        private void DeleteButtonGalactics_Click(object sender, System.EventArgs e)
        {
            Connection.Open();
            string CommandText = "DELETE FROM [Галактики] WHERE [Номер галактики] = @galacticnumber AND [Название галактики] = @galacticname AND [Количество объектов ] = @galacticnumofobj";

            SQLiteCommand DeleteComand = new SQLiteCommand(CommandText, Connection);

            DeleteComand.Parameters.AddWithValue("@galacticnumber", GalacticTable[0, GalacticTable.SelectedCells[0].RowIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@galacticname", GalacticTable[1, GalacticTable.SelectedCells[0].RowIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@galacticnumofobj", GalacticTable[2, GalacticTable.SelectedCells[0].RowIndex].Value.ToString());
            DeleteComand.ExecuteNonQuery();
            Connection.Close();
            int DeleteFromTable = GalacticTable.SelectedCells[0].RowIndex;
            GalacticTable.Rows.RemoveAt(DeleteFromTable);
            ShowTableStars();
        }

        private void RefreshButtonGalactic_Click(object sender, System.EventArgs e)
        {
            ShowTableGalactics();
        }

        private void RefreshButtonPlanets_Click(object sender, System.EventArgs e)
        {
            ShowTablePlanets();
        }

        private void RefreshButtonStars_Click(object sender, System.EventArgs e)
        {
            ShowTableStars();
        }

        //Весь нижеперечисленный код до следующего комментария относится ко вкладке "Галактики"
        private void AddButtonGalactic_Click(object sender, System.EventArgs e)
        {
            ShowTableGalactics();
            this.Width = 832;
            this.Height = 540;
            GalacticNameTextbox.Text = "";
            NumOfObjTextbox.Text = "";
            NumberOfGalacticTextbox.Text = (Convert.ToInt32(GalacticTable.Rows[GalacticTable.Rows.Count - 1].Cells[0].Value)+1).ToString();
            GalacticNameTextbox.ShortcutsEnabled = false;
            GalacticNameTextbox.ContextMenu = new ContextMenu();
            NumOfObjTextbox.ShortcutsEnabled = false;
            NumOfObjTextbox.ContextMenu = new ContextMenu();
            NumberOfGalacticTextbox.ShortcutsEnabled = false;
            NumberOfGalacticTextbox.ContextMenu = new ContextMenu();
            DeleteButtonGalactics.Visible = false;
            RefreshButtonGalactic.Visible = false;
            AddButtonGalactic.Visible = false;
            EditButtonGalactic.Visible = false;
            GalacticNameTextbox.Visible = true;
            NumberOfGalacticTextbox.Visible = true;
            NumOfObjTextbox.Visible = true;
            SaveButtonGalactic.Visible = true;
            NumberOfGalacticLabel.Visible = true;
            NameOfGalacticLabel.Visible = true;
            NumOfObjGalacticLabel.Visible = true;

        }

        private void NameGalacticKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[А-Яа-я\b ]+$");
        }

        private void NumOfObjectsGalacticKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[0-9\b]+$");
        }

        private void SaveButtonGalactic_Click(object sender, EventArgs e)
        {
            GalacticNameTextbox.BackColor = Color.White;
            NumOfObjTextbox.BackColor = Color.White;
            if (GalacticNameTextbox.Text == "" || NumOfObjTextbox.Text == "")
            {
                if (GalacticNameTextbox.Text == "")
                    GalacticNameTextbox.BackColor = Color.Red;
                if (NumOfObjTextbox.Text == "")
                    NumOfObjTextbox.BackColor = Color.Red;
            }
            else
            {
                GalacticNameTextbox.BackColor = Color.White;
                NumOfObjTextbox.BackColor = Color.White;
                int NumberOfGalactic = Convert.ToInt32(NumberOfGalacticTextbox.Text);
                string GalacticName = GalacticNameTextbox.Text;
                int NumOfObjects = Convert.ToInt32(NumOfObjTextbox.Text);
                AddToGalactic(NumberOfGalactic, GalacticName, NumOfObjects);
                GalacticHideControl();
               

            }
        }
        public int AddToGalactic(int NumberOfGalactic, string NameOfGalactic, int NumOfObjects)
        {
            Connection = new SQLiteConnection("Data Source = AstroDatabase.db; Version = 3");
            Connection.Open();
            string AddCommand = "INSERT INTO [Галактики] ([Номер галактики], [Название галактики], [Количество объектов ]) VALUES(@galacticnumber, @galacticname, @galacticnumofobj)";
            SQLiteCommand Command = new SQLiteCommand(AddCommand, Connection);
            Command.Parameters.AddWithValue("@galacticnumber", NumberOfGalactic );
            Command.Parameters.AddWithValue("@galacticname", NameOfGalactic);
            Command.Parameters.AddWithValue("@galacticnumofobj", NumOfObjects);
            Command.ExecuteNonQuery();
            Connection.Close();
            ShowTableGalactics();
            return GalacticTable.Rows.Count;
        }
        void GalacticHideControl()
        {
            this.Width = 832;
            this.Height = 446;
            DeleteButtonGalactics.Visible = true;
            RefreshButtonGalactic.Visible = true;
            AddButtonGalactic.Visible = true;
            EditButtonGalactic.Visible = true;
            GalacticNameTextbox.Visible = false;
            NumberOfGalacticTextbox.Visible = false;
            NumOfObjTextbox.Visible = false;
            SaveButtonGalactic.Visible = false;
            NumberOfGalacticLabel.Visible = false;
            NameOfGalacticLabel.Visible = false;
            NumOfObjGalacticLabel.Visible = false;
            EditSaveButtonGalactic.Visible = false;
        }
        int GalacticCurrentIndex;
        private void EditButtonGalactic_Click(object sender, EventArgs e)
        {
            GalacticCurrentIndex = GalacticTable.CurrentRow.Index;
            ShowTableGalactics();
            this.Width = 832;
            this.Height = 540;
            GalacticNameTextbox.ShortcutsEnabled = false;
            GalacticNameTextbox.ContextMenu = new ContextMenu();
            NumOfObjTextbox.ShortcutsEnabled = false;
            NumOfObjTextbox.ContextMenu = new ContextMenu();
            NumberOfGalacticTextbox.ShortcutsEnabled = false;
            NumberOfGalacticTextbox.ContextMenu = new ContextMenu();
            DeleteButtonGalactics.Visible = false;
            RefreshButtonGalactic.Visible = false;
            AddButtonGalactic.Visible = false;
            EditButtonGalactic.Visible = false;
            GalacticNameTextbox.Visible = true;
            NumberOfGalacticTextbox.Visible = true;
            NumOfObjTextbox.Visible = true;
            EditSaveButtonGalactic.Visible = true;
            NumberOfGalacticLabel.Visible = true;
            NameOfGalacticLabel.Visible = true;
            NumOfObjGalacticLabel.Visible = true;
            NumberOfGalacticTextbox.Text = GalacticTable[0, GalacticCurrentIndex].Value.ToString();
            GalacticNameTextbox.Text = GalacticTable[1, GalacticCurrentIndex].Value.ToString();
            NumOfObjTextbox.Text = GalacticTable[2, GalacticCurrentIndex].Value.ToString();
        }

        private void EditSaveButtonGalactic_Click(object sender, EventArgs e)
        {
            Connection.Open();
            string CommandText = "DELETE FROM [Галактики] WHERE [Номер галактики] = @galacticnumber AND [Название галактики] = @galacticname AND [Количество объектов ] = @galacticnumofobj";
            SQLiteCommand DeleteCommand = new SQLiteCommand(CommandText, Connection);
            DeleteCommand.Parameters.AddWithValue("@galacticnumber", GalacticTable[0, GalacticCurrentIndex].Value.ToString());
            DeleteCommand.Parameters.AddWithValue("@galacticname", GalacticTable[1, GalacticCurrentIndex].Value.ToString());
            DeleteCommand.Parameters.AddWithValue("@galacticnumofobj", GalacticTable[2, GalacticCurrentIndex].Value.ToString());
            DeleteCommand.ExecuteNonQuery();
            CommandText = "INSERT INTO [Галактики] ([Номер галактики], [Название галактики], [Количество объектов ]) VALUES(@galacticnumber, @galacticname, @galacticnumofobj)";
            SQLiteCommand AddCommand = new SQLiteCommand(CommandText, Connection);
            AddCommand.Parameters.AddWithValue("@galacticnumber", Convert.ToInt32(NumberOfGalacticTextbox.Text));
            AddCommand.Parameters.AddWithValue("@galacticname", GalacticNameTextbox.Text);
            AddCommand.Parameters.AddWithValue("@galacticnumofobj", Convert.ToInt32(NumOfObjTextbox.Text));
            AddCommand.ExecuteNonQuery();
            Connection.Close();
            ShowTableGalactics();
            GalacticHideControl();
        }

        //Весь нижеперечисленный код до следующего комментария относится ко вкладке "Планеты"
        private void AddButtonPlanets_Click(object sender, EventArgs e)
        {
            ShowTablePlanets();
            this.Width = 832;
            this.Height = 540;
            NameOfPlanetTextbox.Text = "";
            MassOfPlanetTextbox.Text = "";
            SizeOfPlanetTextbox.Text = "";
            NumberOfPlanetTextbox.Text = (Convert.ToInt32(PlanetsTable.Rows[PlanetsTable.Rows.Count - 1].Cells[0].Value) + 1).ToString();
            NameOfPlanetTextbox.ShortcutsEnabled = false;
            NameOfPlanetTextbox.ContextMenu = new ContextMenu();
            MassOfPlanetTextbox.ShortcutsEnabled = false;
            MassOfPlanetTextbox.ContextMenu = new ContextMenu();
            SizeOfPlanetTextbox.ShortcutsEnabled = false;
            SizeOfPlanetTextbox.ContextMenu = new ContextMenu();
            NumberOfPlanetTextbox.ShortcutsEnabled = false;
            NumberOfPlanetTextbox.ContextMenu = new ContextMenu();

            DeleteButtonPlanets.Visible = false;
            AddButtonPlanets.Visible = false;
            EditButtonPlanet.Visible = false;
            RefreshButtonPlanets.Visible = false;
            NumberOfPlanetTextbox.Visible = true;
            NumberOfPlanetLabel.Visible = true;
            NameOfPlanetLabel.Visible = true;
            NameOfPlanetTextbox.Visible = true;
            MassOfPlanetLabel.Visible = true;
            MassOfPlanetTextbox.Visible = true;
            SizeOfPlanetLabel.Visible = true;
            SizeOfPlanetTextbox.Visible = true;
            SaveButtonPlanet.Visible = true;
        }

        private void SaveButtonPlanet_Click(object sender, EventArgs e)
        {
            NameOfPlanetTextbox.BackColor = Color.White;
            MassOfPlanetTextbox.BackColor = Color.White;
            SizeOfPlanetTextbox.BackColor = Color.White;
            if (NameOfPlanetTextbox.Text == "" || MassOfPlanetTextbox.Text == "" || SizeOfPlanetTextbox.Text == "")
            {
                if (NameOfPlanetTextbox.Text == "")
                    NameOfPlanetTextbox.BackColor = Color.Red;
                if (MassOfPlanetTextbox.Text == "")
                    MassOfPlanetTextbox.BackColor = Color.Red;
                if (SizeOfPlanetTextbox.Text == "")
                    SizeOfPlanetTextbox.BackColor = Color.Red;
            }
            else
            {
                NameOfPlanetTextbox.BackColor = Color.White;
                MassOfPlanetTextbox.BackColor = Color.White;
                SizeOfPlanetTextbox.BackColor = Color.White;
                Connection = new SQLiteConnection("Data Source = AstroDatabase.db; Version = 3");
                Connection.Open();
                string AddCommand = "INSERT INTO [Планеты] ([Номер планеты], [Название планеты], [Масса планеты], [Размер планеты]) VALUES(@planetnumber, @planetname, @planetmass, @planetsize)";
                SQLiteCommand Command = new SQLiteCommand(AddCommand, Connection);
                Command.Parameters.AddWithValue("@planetnumber", Convert.ToInt32(NumberOfPlanetTextbox.Text));
                Command.Parameters.AddWithValue("@planetname", NameOfPlanetTextbox.Text);
                Command.Parameters.AddWithValue("@planetmass", Convert.ToInt32(MassOfPlanetTextbox.Text));
                Command.Parameters.AddWithValue("@planetsize", Convert.ToInt32(SizeOfPlanetTextbox.Text));
                Command.ExecuteNonQuery();
                Connection.Close();
                ShowTablePlanets();
                PlanetsHideControl();
            }
        }
        void PlanetsHideControl()
        {
            this.Width = 832;
            this.Height = 446;
            DeleteButtonPlanets.Visible = true;
            AddButtonPlanets.Visible = true;
            EditButtonPlanet.Visible = true;
            RefreshButtonPlanets.Visible = true;
            NumberOfPlanetTextbox.Visible = false;
            NumberOfPlanetLabel.Visible = false;
            NameOfPlanetLabel.Visible = false;
            NameOfPlanetTextbox.Visible = false;
            MassOfPlanetLabel.Visible = false;
            MassOfPlanetTextbox.Visible = false;
            SizeOfPlanetLabel.Visible = false;
            SizeOfPlanetTextbox.Visible = false;
            EditSaveButtonPlanet.Visible = false;
            SaveButtonPlanet.Visible = false;
        }

        int PlanetsCurrentIndex;
        private void EditSaveButtonPlanet_Click(object sender, EventArgs e)
        {
            Connection.Open();
            string CommandText = "DELETE FROM [Планеты] WHERE [Номер планеты] = @planetnumber AND [Название планеты] = @planetname AND [Масса планеты] = @planetmass AND [Размер планеты] = @planetsize";
            SQLiteCommand DeleteComand = new SQLiteCommand(CommandText, Connection);
            DeleteComand.Parameters.AddWithValue("@planetnumber", PlanetsTable[0, PlanetsCurrentIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@planetname", PlanetsTable[1, PlanetsCurrentIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@planetmass", PlanetsTable[2, PlanetsCurrentIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@planetsize", PlanetsTable[3, PlanetsCurrentIndex].Value.ToString());
            DeleteComand.ExecuteNonQuery();

            string AddCommand = "INSERT INTO [Планеты] ([Номер планеты], [Название планеты], [Масса планеты], [Размер планеты]) VALUES(@planetnumber, @planetname, @planetmass, @planetsize)";
            SQLiteCommand Command = new SQLiteCommand(AddCommand, Connection);
            Command.Parameters.AddWithValue("@planetnumber", Convert.ToInt32(NumberOfPlanetTextbox.Text));
            Command.Parameters.AddWithValue("@planetname", NameOfPlanetTextbox.Text);
            Command.Parameters.AddWithValue("@planetmass", Convert.ToInt32(MassOfPlanetTextbox.Text));
            Command.Parameters.AddWithValue("@planetsize", Convert.ToInt32(SizeOfPlanetTextbox.Text));
            Command.ExecuteNonQuery();
            Connection.Close();
            ShowTablePlanets();
            PlanetsHideControl();
            
        }

        private void NameOfPlanetKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[А-Яа-я\b ]+$");
        }

        private void MassOfPlanetKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[0-9\b]+$");
        }

        private void SizeOfPlanetKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[0-9\b]+$");
        }

        private void EditButtonPlanet_Click(object sender, EventArgs e)
        {
            PlanetsCurrentIndex = PlanetsTable.CurrentRow.Index;
            ShowTablePlanets();
            this.Width = 832;
            this.Height = 540;

            NumberOfPlanetTextbox.Text = PlanetsTable[0, PlanetsCurrentIndex].Value.ToString();
            NameOfPlanetTextbox.Text = PlanetsTable[1, PlanetsCurrentIndex].Value.ToString();
            MassOfPlanetTextbox.Text = PlanetsTable[2, PlanetsCurrentIndex].Value.ToString();
            SizeOfPlanetTextbox.Text = PlanetsTable[3, PlanetsCurrentIndex].Value.ToString();
            NameOfPlanetTextbox.ShortcutsEnabled = false;
            NameOfPlanetTextbox.ContextMenu = new ContextMenu();
            MassOfPlanetTextbox.ShortcutsEnabled = false;
            MassOfPlanetTextbox.ContextMenu = new ContextMenu();
            SizeOfPlanetTextbox.ShortcutsEnabled = false;
            SizeOfPlanetTextbox.ContextMenu = new ContextMenu();
            NumberOfPlanetTextbox.ShortcutsEnabled = false;
            NumberOfPlanetTextbox.ContextMenu = new ContextMenu();

            DeleteButtonPlanets.Visible = false;
            AddButtonPlanets.Visible = false;
            EditButtonPlanet.Visible = false;
            RefreshButtonPlanets.Visible = false;
            NumberOfPlanetTextbox.Visible = true;
            NumberOfPlanetLabel.Visible = true;
            NameOfPlanetLabel.Visible = true;
            NameOfPlanetTextbox.Visible = true;
            MassOfPlanetLabel.Visible = true;
            MassOfPlanetTextbox.Visible = true;
            SizeOfPlanetLabel.Visible = true;
            SizeOfPlanetTextbox.Visible = true;
            EditSaveButtonPlanet.Visible = true;
        }
        //Весь нижеперечисленный код до следующего комментария относится ко вкладке "Звезды"
        private void AddButtonStars_Click(object sender, EventArgs e)
        {
            ShowTableStars();
            this.Width = 832;
            this.Height = 540;
            NameOfStarTextbox.Text = "";
            SizeOfStarTextbox.Text = "";
            FarOfStarTextbox.Text = "";
            MassOfStarTextbox.Text = "";
            NumberOfStarTextbox.Text = (Convert.ToInt32(StarsTable.Rows[StarsTable.Rows.Count - 1].Cells[0].Value) + 1).ToString();
            NameOfStarTextbox.ShortcutsEnabled = false;
            NameOfStarTextbox.ContextMenu = new ContextMenu();
            SizeOfStarTextbox.ShortcutsEnabled = false;
            SizeOfStarTextbox.ContextMenu = new ContextMenu();
            FarOfStarTextbox.ShortcutsEnabled = false;
            FarOfStarTextbox.ContextMenu = new ContextMenu();
            MassOfStarTextbox.ShortcutsEnabled = false;
            MassOfStarTextbox.ContextMenu = new ContextMenu();
            NumberOfStarTextbox.ShortcutsEnabled = false;
            NumberOfStarTextbox.ContextMenu = new ContextMenu();

            DeleteButtonStars.Visible = false;
            AddButtonStars.Visible = false;
            EditButtonStars.Visible = false;
            RefreshButtonStars.Visible = false;

            NumberOfStarLabel.Visible = true;
            NumberOfStarTextbox.Visible = true;
            NameOfStarTextbox.Visible = true;
            NameOfStarLabel.Visible = true;
            SizeOfStarTextbox.Visible = true;
            SizeOfStarLabel.Visible = true;
            FarOfStarLabel.Visible = true;
            FarOfStarTextbox.Visible = true;
            MassOfStarTextbox.Visible = true;
            MassOfStarLabel.Visible = true;
            SaveStarButton.Visible = true;
        }
        private void SaveStarButton_Click(object sender, EventArgs e)
        {
            NameOfStarTextbox.BackColor = Color.White;
            SizeOfStarTextbox.BackColor = Color.White;
            FarOfStarTextbox.BackColor = Color.White;
            MassOfStarTextbox.BackColor = Color.White;

            if (NameOfStarTextbox.Text == "" || SizeOfStarTextbox.Text == "" || FarOfStarTextbox.Text == "" || MassOfStarTextbox.Text == "")
            {
                if (NameOfStarTextbox.Text == "")
                    NameOfStarTextbox.BackColor = Color.Red;
                if (SizeOfStarTextbox.Text == "")
                    SizeOfStarTextbox.BackColor = Color.Red;
                if (FarOfStarTextbox.Text == "")
                    FarOfStarTextbox.BackColor = Color.Red;
                if (MassOfStarTextbox.Text == "")
                    MassOfStarTextbox.BackColor = Color.Red;
            }
            else
            {
                NameOfStarTextbox.BackColor = Color.White;
                SizeOfStarTextbox.BackColor = Color.White;
                FarOfStarTextbox.BackColor = Color.White;
                MassOfStarTextbox.BackColor = Color.White;
                Connection = new SQLiteConnection("Data Source = AstroDatabase.db; Version = 3");
                Connection.Open();
                string AddCommand = "INSERT INTO [Звезды] ([Номер звезды], [Название звезды], [Размер звезды], [Удаленность от земли (св лет)], [Масса звезды]) VALUES(@starnumber, @starname, @starsize, @starfar, @starmass)";
                SQLiteCommand Command = new SQLiteCommand(AddCommand, Connection);
                Command.Parameters.AddWithValue("@starnumber", Convert.ToInt32(NumberOfStarTextbox.Text));
                Command.Parameters.AddWithValue("@starname", NameOfStarTextbox.Text);
                Command.Parameters.AddWithValue("@starsize", Convert.ToInt32(SizeOfStarTextbox.Text));
                Command.Parameters.AddWithValue("@starfar", Convert.ToInt32(FarOfStarTextbox.Text));
                Command.Parameters.AddWithValue("@starmass", Convert.ToInt32(MassOfStarTextbox.Text));
                Command.ExecuteNonQuery();
                Connection.Close();
                ShowTableStars();
                StarsHideControl();
            }
        }
        public 
        void StarsHideControl()
        {
            this.Width = 832;
            this.Height = 446;
            DeleteButtonStars.Visible = true;
            AddButtonStars.Visible = true;
            EditButtonStars.Visible = true;
            RefreshButtonStars.Visible = true;

            NumberOfStarLabel.Visible = false;
            NumberOfStarTextbox.Visible = false;
            NameOfStarTextbox.Visible = false;
            NameOfStarLabel.Visible = false;
            SizeOfStarTextbox.Visible = false;
            SizeOfStarLabel.Visible = false;
            FarOfStarLabel.Visible = false;
            FarOfStarTextbox.Visible = false;
            MassOfStarLabel.Visible = false;
            MassOfStarTextbox.Visible = false;
            SaveStarButton.Visible = false;
            SaveEditStarButton.Visible = false;
        }

        private void NameOfStarKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[А-Яа-я\b ]+$");
        }

        private void SizeOfStarKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[0-9\b]+$");
        }

        private void FarOfStarKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[0-9\b]+$");
        }

        private void MassOfStarKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[0-9\b]+$");
        }
        int StarsCurrentIndex;
        private void EditButtonStars_Click(object sender, EventArgs e)
        {
            StarsCurrentIndex = StarsTable.CurrentRow.Index;
            ShowTableStars();
            this.Width = 832;
            this.Height = 540;
            NameOfStarTextbox.Text = StarsTable[1, StarsCurrentIndex].Value.ToString();
            SizeOfStarTextbox.Text = StarsTable[2, StarsCurrentIndex].Value.ToString(); ;
            FarOfStarTextbox.Text = StarsTable[3, StarsCurrentIndex].Value.ToString();
            MassOfStarTextbox.Text = StarsTable[4, StarsCurrentIndex].Value.ToString();
            NumberOfStarTextbox.Text = StarsTable[0, StarsCurrentIndex].Value.ToString();
            NameOfStarTextbox.ShortcutsEnabled = false;
            NameOfStarTextbox.ContextMenu = new ContextMenu();
            SizeOfStarTextbox.ShortcutsEnabled = false;
            SizeOfStarTextbox.ContextMenu = new ContextMenu();
            FarOfStarTextbox.ShortcutsEnabled = false;
            FarOfStarTextbox.ContextMenu = new ContextMenu();
            MassOfStarTextbox.ShortcutsEnabled = false;
            MassOfStarTextbox.ContextMenu = new ContextMenu();
            NumberOfStarTextbox.ShortcutsEnabled = false;
            NumberOfStarTextbox.ContextMenu = new ContextMenu();

            DeleteButtonStars.Visible = false;
            AddButtonStars.Visible = false;
            EditButtonStars.Visible = false;
            RefreshButtonStars.Visible = false;

            NumberOfStarLabel.Visible = true;
            NumberOfStarTextbox.Visible = true;
            NameOfStarTextbox.Visible = true;
            NameOfStarLabel.Visible = true;
            SizeOfStarTextbox.Visible = true;
            SizeOfStarLabel.Visible = true;
            FarOfStarLabel.Visible = true;
            FarOfStarTextbox.Visible = true;
            MassOfStarTextbox.Visible = true;
            MassOfStarLabel.Visible = true;
            SaveEditStarButton.Visible = true;
        }
        private void SaveEditStarButton_Click(object sender, EventArgs e)
        {
            Connection.Open();
            string CommandText = "DELETE FROM [Звезды] WHERE [Номер звезды] = @starnumber AND [Название звезды] = @starname AND [Размер звезды] = @starsize AND [Удаленность от земли (св лет)] = @starfar AND [Масса звезды] = @starmass";

            SQLiteCommand DeleteComand = new SQLiteCommand(CommandText, Connection);

            DeleteComand.Parameters.AddWithValue("@starnumber", StarsTable[0, StarsCurrentIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@starname", StarsTable[1, StarsCurrentIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@starsize", StarsTable[2, StarsCurrentIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@starfar", StarsTable[3, StarsCurrentIndex].Value.ToString());
            DeleteComand.Parameters.AddWithValue("@starmass", StarsTable[4, StarsCurrentIndex].Value.ToString());
            DeleteComand.ExecuteNonQuery();

            string AddCommand = "INSERT INTO [Звезды] ([Номер звезды], [Название звезды], [Размер звезды], [Удаленность от земли (св лет)], [Масса звезды]) VALUES(@starnumber, @starname, @starsize, @starfar, @starmass)";
            SQLiteCommand Command = new SQLiteCommand(AddCommand, Connection);
            Command.Parameters.AddWithValue("@starnumber", Convert.ToInt32(NumberOfStarTextbox.Text));
            Command.Parameters.AddWithValue("@starname", NameOfStarTextbox.Text);
            Command.Parameters.AddWithValue("@starsize", Convert.ToInt32(SizeOfStarTextbox.Text));
            Command.Parameters.AddWithValue("@starfar", Convert.ToInt32(FarOfStarTextbox.Text));
            Command.Parameters.AddWithValue("@starmass", Convert.ToInt32(MassOfStarTextbox.Text));
            Command.ExecuteNonQuery();
            Connection.Close();
            ShowTableStars();
            StarsHideControl();
        }
        //сохранение в файл 
        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string FileName = SaveFileDialog.FileName;
            string WholeText = "";
            WholeText += "Планеты:" + Environment.NewLine + Environment.NewLine;
            ShowTablePlanets();
            for (int i = 0; i < PlanetsTable.Rows.Count; i++)
            {
                for (int j = 0; j < PlanetsTable.Columns.Count; j++)
                {
                        WholeText += PlanetsTable[j, i].Value.ToString() + " "; 
                }
                WholeText += Environment.NewLine;
            }
            WholeText += Environment.NewLine;
            WholeText += "Звезды:" + Environment.NewLine + Environment.NewLine;
            ShowTableStars();
            for (int i = 0; i < StarsTable.Rows.Count; i++)
            {
                for (int j = 0; j < StarsTable.Columns.Count; j++)
                {
                    WholeText += StarsTable[j, i].Value.ToString() + " ";
                }
                WholeText += Environment.NewLine;
            }
            WholeText += Environment.NewLine;
            WholeText += "Галактики:" + Environment.NewLine + Environment.NewLine;
            ShowTableGalactics();
            for (int i = 0; i < GalacticTable.Rows.Count; i++)
            {
                for (int j = 0; j < GalacticTable.Columns.Count; j++)
                {
                    WholeText += GalacticTable[j, i].Value.ToString() + " ";
                }
                WholeText += Environment.NewLine;
            }

            File.WriteAllText(FileName, WholeText);
        }
        Forms.AboutForm AboutForm = new Forms.AboutForm();
        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm.ShowDialog();
        }
    }
   
}

