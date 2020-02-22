using System;
using System.Collections.Generic;
using SQLite;

namespace Library
{
    public class Eight_AR_Repository
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }

        public Eight_AR_Repository(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Eight_A_Student>();
        }

        public void AddNewStudent()
        {
            int result = 0;
            //try
            //{
                result = conn.Insert(new Eight_A_Student());
            /*}
            catch (Exception ex)
            {
            }*/
        }

        public List<Eight_A_Student> GetItems()
        {
            try
            {
                return conn.Query<Eight_A_Student>("bla bla bla");
            }
            catch
            {
                return new List<Eight_A_Student>();
            }

        }

        public List<Eight_A_Student> GetAllStudents()
        {
            try
            {
                return conn.Table<Eight_A_Student>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Eight_A_Student>();
        }
    }
}
