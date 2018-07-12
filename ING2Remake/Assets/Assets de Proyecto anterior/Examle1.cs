
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;
using UnityEngine.Experimental.UIElements;


public class Examle1 : MonoBehaviour
{ 
    GameObject[] CiertoS, FalsoS;
    public GameObject correctSign, incorrectSign;
    public TextMesh PBDT;
    public int puntosGanados = 1;
    public int puntosPerdidos = 1;
    public int Intentos = 3;

    int IDP;
    string Pregunta;
    string Respuesta1;
    string Respuesta2;
    string Respuesta3;
    void Start()
    {

        CiertoS = GameObject.FindGameObjectsWithTag("CiertoS");
        FalsoS = GameObject.FindGameObjectsWithTag("FalsoS");
        string conn = "URI=file:" + Application.dataPath + "/PDB.s3db"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        //string sqlQuery = "SELECT IDP, Pregunta, Respeusta1, Respeusta2, Respeusta3 " + "FROM Preguntas";
        string sqlQuery = "SELECT Pregunta, Respuesta1 , Respuesta2 , Respuesta3 " + "FROM Preguntas";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            //IDP = reader.GetInt32(0);
            Pregunta = reader.GetString(0);
            Respuesta1 = reader.GetString(1);
            Respuesta2 = reader.GetString(2);
            Respuesta3 = reader.GetString(3);
            PBDT.text = Pregunta;
            Debug.Log("Pregunta =" + Pregunta + "  Respuesta1 =" + Respuesta1 + "  Respuesta2 =" + Respuesta2 +"  Respuesta3 =" + Respuesta3);
           

        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width -765, Screen.height / 2, 150, 40), Respuesta1))
        {
            try
            {
                foreach (GameObject element in CiertoS)
                {
                    element.gameObject.SetActive(true);
                }
                correctSign.gameObject.SetActive(true);
                NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
                Debug.Log("Respuesta Correcta, ha ganado 5 puntos Pase a la Siguiente Pregunta");
                NotificationCenter.DefaultCenter().PostNotification(this, "GameOver", Intentos);

            }
            catch (System.NullReferenceException ex)
            {
                Debug.Log("ERROR DE VARIABLE NOINSTANCIADAOREFERENCIADA" + ex);
            }
        }
        if (GUI.Button(new Rect(Screen.width - 765 , Screen.height -250 , 150, 40), Respuesta2))
        {
            try
            {
                foreach (GameObject element in FalsoS)
                {
                    element.gameObject.SetActive(true);
                }
                incorrectSign.gameObject.SetActive(true);
                NotificationCenter.DefaultCenter().PostNotification(this, "ReducirPuntos", puntosPerdidos);
                Debug.Log("Respuesta Incorrecta, ha perdido 5 puntos Pase a la Siguiente Pregunta");
                NotificationCenter.DefaultCenter().PostNotification(this, "GameOver", Intentos);

            }
            catch (System.NullReferenceException ex)
            {
                Debug.Log("ERROR DE VARIABLE NOINSTANCIADAOREFERENCIADA" + ex);
            }
        }
        if (GUI.Button(new Rect(Screen.width - 765, Screen.height - 200, 150, 40), Respuesta3))
        {
            try
            {
                foreach (GameObject element in FalsoS)
                {
                    element.gameObject.SetActive(true);
                }
                incorrectSign.gameObject.SetActive(true);
                NotificationCenter.DefaultCenter().PostNotification(this, "ReducirPuntos", puntosPerdidos);
                Debug.Log("Respuesta Incorrecta, ha perdido 5 puntos Pase a la Siguiente Pregunta");
                NotificationCenter.DefaultCenter().PostNotification(this, "GameOver", Intentos);

            }
            catch (System.NullReferenceException ex)
            {
                Debug.Log("ERROR DE VARIABLE NOINSTANCIADAOREFERENCIADA" + ex);
            }
        }
    }
}