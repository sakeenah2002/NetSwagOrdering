using System;
using SQLite;
using System.Collections.Generic;
using System.Text;
using SWAGAPP.Swag;
using System.Threading.Tasks;
using System.IO;

namespace SWAGAPP.DataB
{
    public class DataBase
    {
        private readonly SQLiteAsyncConnection _database;

        public static DataBase Database = new DataBase(GetDatabPath());

        public DataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Swag1>();
        }

        private static string GetDatabPath()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);


            return Path.Combine(path, "orderditems.db"); ;

        }

        public async Task<List<Swag1>> GetSwagItemsAsync()
        {
            return await _database.Table<Swag1>().ToListAsync();
        }
        public async Task<int> SaveSwagItemAsync(Swag1 item)
        {
            return await _database.InsertAsync(item);

        }
    }
}
