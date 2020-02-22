using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Library
{
    [Table("Eight_A_Student")]
    public class Eight_A_Student
    {
        static Random rnd = new Random();

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250), Unique]
        public string Name { get; set; }

        public DateTime Marks { get; set; }
        // public string[] dates = General.

        /*[Column("Даты")]
        public DateTime Marks { get; set; }

        public DateTime this[int index]
        {
            get {
                return General.russianlessons_8_A[index];
            }
        }*/




        public Eight_A_Student()
        {
            Name = General.CreateName();

            Marks = General.russianlessons_8_A[rnd.Next(General.russianlessons_8_A.Length)];

            /*for (int i = 0; i < General.russianlessons_8_A.Length; i++)
            {
                Marks.Add(General.russianlessons_8_A[i], General.forCells[rnd.Next(General.forCells.Length)]);
            }*/
        }
    }
}
