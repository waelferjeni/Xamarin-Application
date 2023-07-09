using System.IO;
using DesignTask2.Droid.Dependancies;
using DesignTask2.Interfaces;
using SQLite;
using Xamarin.Forms;


[assembly: Dependency(typeof(GetSQLiteConnnection))]
namespace DesignTask2.Droid.Dependancies
{
    public class GetSQLiteConnnection : ISQLiteInterface
    {
        public GetSQLiteConnnection()
        {

        }
        public SQLiteConnection GetSQLiteConnection()
        {
            var filename = "UserDatabase.db3";
            var documentspath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentspath, filename);

            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
}