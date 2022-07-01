using Dapper;
using Magazyn___Rozmieszczenie_Towarów.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn___Rozmieszczenie_Towarów.DbContexts
{
    public class SqliteDataAccess
    {
        public static List<towary> LoadTowary()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<towary>("select * from towary", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void DodajTowar(towary towar)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into towary(id_towaru, nazwa_towaru, waga values @IdTowaru, @NazwaTowaru, @waga)", towar);
            }
        }

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
