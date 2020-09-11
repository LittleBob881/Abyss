using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AbyssLibrary
{
    class DatabaseControl
    {
        public inventory createInventoryItems()
        {
            inventory toreturn = new inventory();

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "<sql server address>";
            builder.UserID = "SLJJ";
            builder.Password = "abyss";
            builder.InitialCatalog = "<databases>";




            return toreturn;

        }
    }
}
