using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
using DHB.Models;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace DHB.Data
{
   public class HeroesDB
    {
        readonly SQLiteAsyncConnection db;

        public HeroesDB(String ConnectionString)
        {
            db = new SQLiteAsyncConnection(ConnectionString);

            db.CreateTableAsync<Heroes>().Wait();

        }
        public Task<List<Heroes>> GetHeroesAsync() 
        {
            return db.Table<Heroes>().ToListAsync();
        }


        public Task<Heroes> GetHeroesAsync(int id)
        {
            return db.Table<Heroes>()
                .Where(i => i.ID== id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveHeroesAsync(Heroes heroes)
        {
            if (heroes.ID !=0)
            {
                return db.UpdateAsync(heroes);
            }
            else
            {
                return db.InsertAsync(heroes);
            }
        }

        public Task<int> DeleteHeroesAsync(Heroes heroes)
        {
            return db.DeleteAsync(heroes);
        }


    }
}
