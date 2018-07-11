
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;

public class Examle1 : MonoBehaviour
{
    public TextMesh PBDT;
    int IDP;
    string Pregunta;
    string Respuesta1;
    string Respuesta2;
    string Respuesta3;
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "Pregunta");
        PBD();
        string conn = "URI=file:" + Application.dataPath + "/PDB.s3db"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        //string sqlQuery = "SELECT IDP, Pregunta, Respeusta1, Respeusta2, Respeusta3 " + "FROM Preguntas";
        string sqlQuery = "SELECT IDP " + "FROM Preguntas";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            IDP = reader.GetInt32(0);
            Pregunta = reader.GetString(1);
            Respuesta1 = reader.GetString(2);
            Respuesta2 = reader.GetString(3);
            Respuesta3 = reader.GetString(4);
            PBDT.text = IDP.ToString();
            //Debug.Log("IDPregunta= " + IDP + "  Pregunta =" + Pregunta + "  Respuesta1 =" + Respuesta1 + "  Respuesta2 =" + Respuesta2 +"  Respuesta3 =" + Respuesta3);
            Debug.Log("IDPregunta= " + IDP);
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
    }
    /* void Prueba(Notification notificacion)
     {
         int IDPREGUNTA = (int)notificacion.data;
         idp = IDPREGUNTA;
         PBD();
     }*/
    void PBD()
    {
        PBDT.text = IDP.ToString();
    }
}