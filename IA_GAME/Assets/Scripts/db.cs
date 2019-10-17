using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;

public class db : MonoBehaviour
{
    int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        sqlite_connection();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void sqlite_connection()
    {
     string conn = "URI=file:" + Application.dataPath + "/Plugins/gamevr.db"; //Path to database.
     IDbConnection dbconn;
     dbconn = (IDbConnection) new SqliteConnection(conn);
     dbconn.Open(); //Open connection to the database.
     IDbCommand dbcmd = dbconn.CreateCommand();
     string sqlQuery = "SELECT * FROM data";
     dbcmd.CommandText = sqlQuery;
     IDataReader reader = dbcmd.ExecuteReader();

     while (reader.Read())
     {
         int id = reader.GetInt32(0);
         string nombre = reader.GetString(1);
         int edad = reader.GetInt32(2);
        
         Debug.Log( "Id = "+id+",  Nombre ="+nombre+",  Edad ="+  edad);
     }

     reader.Close();
     reader = null;

     dbcmd.Dispose();
     dbcmd = null;

     dbconn.Close();
     dbconn = null;
     
    }
}
