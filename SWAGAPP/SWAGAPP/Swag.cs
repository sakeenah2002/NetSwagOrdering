using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace SWAGAPP.Swag
{
    public class Swag1
    {
        [PrimaryKey, AutoIncrement]

        public string Name { get; set; }
        public string Surname { get; set; }

        public string Date { get; set; }

        public string Sizes { get; set; }

        public string Gender { get; set; }

        public string Color { get; set; }

        public string DeliveryAddress { get; set; }

        public string Price { get; set; }

        public string Password { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public static SQLiteAsyncConnection Database;

    }
}
