using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public static class General
    {
        static Random rnd = new Random();

        public static DateTime[] russianlessons_8_A =
        {
            new DateTime(2019, 11, 11),
            new DateTime(2019, 11, 14),
            new DateTime(2019, 11, 18),
            new DateTime(2019, 11, 21),
            new DateTime(2019, 11, 25),
            new DateTime(2019, 11, 28),
            new DateTime(2019, 12, 2),
            new DateTime(2019, 12, 5),
            new DateTime(2019, 12, 9),
            new DateTime(2019, 12, 12),
            new DateTime(2019, 12, 16),
            new DateTime(2019, 12, 19),
            new DateTime(2019, 12, 23),
            new DateTime(2019, 12, 26),
        };

        public static string[,] _8_B_R_marks =
        {
            {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "010" },
            {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "110" },
            {"20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "210" }
        };


        public static List<Picker_Item> picker_marks = new List<Picker_Item>()
        { 
            new Picker_Item("н"),
            new Picker_Item("5"),
            new Picker_Item("4"),
            new Picker_Item("3"),
            new Picker_Item("2"),
            new Picker_Item("1") 
        };

        public static string[] marks = { "-" };


        public static string[] names =
        {
            "Иван", "Михаил", "Николай", "Глеб", "Никита", "Владимир", "Максим", "Артем", "Андрей"
        };

        public static string[] surnames =
        {
            "Иванов", "Петров", "Роженков", "Вакушин", "Скутнев", "Федоров", "Попов", "Антропов"
        };

        public static string CreateName()
        {
            return $"{surnames[rnd.Next(surnames.Length)]} {names[rnd.Next(names.Length)]}";
        }

        public static string[] forCells = { "н", "2", "3", "4", "5" };
    }
}
