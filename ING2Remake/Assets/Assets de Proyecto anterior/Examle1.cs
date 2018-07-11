using System.Text.RegularExpressions;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;

public class Examle1
{
    void Start()
    {

        string conn = "URI=file:" + Application.dataPath + "/PDB.s3db"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "SELECT IDP,Pregunta, Respeusta1, Respeusta2, Respeusta3 " + "FROM Preguntas";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            int IDP = reader.GetInt32(0);
            string Pregunta = reader.GetString(1);
            string Respuesta1 = reader.GetString(2);
            string Respuesta2 = reader.GetString(3);
            string Respuesta3 = reader.GetString(4);

            Debug.Log("IDPregunta= " + IDP + "  Pregunta =" + Pregunta + "  Respuesta1 =" + Respuesta2 + "  Respuesta2 =" + Respuesta2 +"  Respuesta3 =" + Respuesta3);
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
    }
}