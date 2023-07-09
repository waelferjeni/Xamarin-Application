using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignTask2.Interfaces
{
    public interface ISQLiteInterface
    {
        SQLiteConnection GetSQLiteConnection();
    }
}
