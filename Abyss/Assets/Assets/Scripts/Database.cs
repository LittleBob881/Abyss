using System.Data;
using UnityEngine;
using Mono.Data.Sqlite;
using System;

public class Database : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("In database");
        string conn = "URI=file:" + Application.dataPath + "///Database.sqbpro"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "SELECT pagenum,unlocked" + "FROM NoteBook";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            int pageNum = reader.GetInt32(0);
            int unlocked = reader.GetInt32(1);

            Debug.Log("pageNum= " + pageNum + "  unlocked =" + unlocked);
        }

        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
    }
}
