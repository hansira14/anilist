using System.Data;
using System.Data.OleDb;

namespace AniList
{
    public static class dbc
    {
        public static OleDbConnection con;
        internal static OleDbDataAdapter bridge;
        internal static OleDbCommand cmd;
        internal static DataSet ds;
        public static void Connect()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=anilist.accdb");

        }
    }
}
