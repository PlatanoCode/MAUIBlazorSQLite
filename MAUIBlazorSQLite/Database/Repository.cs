using MAUIBlazorSQLite.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBlazorSQLite.Database
{
    public class Repository
    {
        private readonly SQLiteConnection _database;
        public Repository()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "entities.db");
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<TodoListDTO>();
        }

        public List<TodoListDTO> List()
        {
            return _database.Table<TodoListDTO>().ToList();
        }

        public int Create(TodoListDTO entity)
        {
            return _database.Insert(entity);
        }

        public int Update(TodoListDTO entity)
        {
            return _database.Update(entity);
        }

        public int Delete(TodoListDTO entity)
        {
            return _database.Delete(entity);
        }
    }
}
