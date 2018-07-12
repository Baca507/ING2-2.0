using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;
using System.Text.RegularExpressions;
public class sdb : MonoBehaviour {
    public GameObject usuario, password;
    private string conn, sqlQuery;
    IDbConnection dbconn;
    IDbCommand dbcmd;
    private string Usuario;
    private string Password;
    private String[] Lines;
    private string DecryptedPass;
    private string pass;
    private string name;
    string contra = "8888";
    // Use this for initialization
    void Start () {
        conn = "URI=file:" + Application.dataPath + "/PDB.s3db"; //Path to database.
        //Deletvalue(6);
        //insertvalue("ahmedm", "ahmedm@gmail.com", "sss"); 
        //Updatevalue("Prueba", contra, 31 / 03 / 1992, "Prueba@hotmail.com", 8888);
        readers();
	}

    /*private void insertvalue(string name, string email, string address)
    {
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); //Open connection to the database.
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("insert into Usersinfo (Name, Email, Address) values (\"{0}\",\"{1}\",\"{2}\")",name,email,address);// table name
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteScalar();
            dbconn.Close();
        }
    }
    private void Deletvalue(int id)
    {
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); //Open connection to the database.
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("Delete from Usersinfo WHERE ID=\"{0}\"", id);// table name
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteScalar();
            dbconn.Close();
        }
    }*/


   /* private void Updatevalue(string name, string pass, SQLiteDateFormats Fna, string email, int cedula)
    {
        using (dbconn = new SqliteConnection(conn))
        {

            dbconn.Open(); //Open connection to the database.
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("UPDATE Perfil set Nombre_Completo=\"{0}\", Password=\"{1}\",FNacimiento=\"{2}\", CorreoE=\"{3}\" WHERE ID=\"{4}\" ", name,pass, Fna, email, cedula);// table name
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteScalar();
            dbconn.Close();
        }
    }*/

    
    private void readers()
    {
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); //Open connection to the database.
            dbcmd = dbconn.CreateCommand();
            sqlQuery = "SELECT Cedula, Nombre_Completo, Password, FNacimiento, CorreoE " + "FROM Perfil";// table name
            dbcmd.CommandText = sqlQuery;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                int cedu = reader.GetInt32(0);
                name = reader.GetString(1);
                pass = reader.GetString(2);
                string FN = reader.GetString(3);
                string email = reader.GetString(4);
                

                Debug.Log("Cedula= " + cedu + "  Nombre Completo =" + name + "  Password =" + pass + "  Fecha de nacimiento =" + FN + "   Correo Electronico" + email);
                
                
            }
            reader.Close();
            reader = null;
            dbcmd.Dispose();
            dbcmd = null;
            dbconn.Close();
            dbconn = null;
        }
    }
    public void LoginButton()
    {
        bool UN = false;
        bool PW = false;
        if (Usuario != "")
        {
            if (Usuario.Equals(name))
            {
                UN = true;
                Debug.Log("Usuario Validado");
            }
            else
            {
                Debug.LogWarning("Username Invaild");
            }
        }
        else
        {
            Debug.LogWarning("Username Field Empty");
        }
        if (Password != "")
        {
            if (Password.Equals(pass))
            {
                
                    PW = true;
                    Debug.Log("Password Validado");
                
            }
            else
            {
                Debug.LogWarning("Password Is invalid");
            }
        }
        else
        {
            Debug.LogWarning("Password Field Empty");
        }
        if (UN == true && PW == true)
        {
            usuario.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            print("Login Sucessful");
            //Application.LoadLevel("Start Menu");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (usuario.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Password != "" && Password != "")
            {
                LoginButton();
            }
        }
        Usuario = usuario.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
    }

/*private void ConsultaVali()
    {
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); //Open connection to the database.
            dbcmd = dbconn.CreateCommand();
            sqlQuery = "SELECT * " + "FROM Perfil";// table name
            dbcmd.CommandText = sqlQuery;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                int cedu = reader.GetInt32(0);
                string name = reader.GetString(1);
                string Email = reader.GetString(2);
                string Phone = reader.GetString(3);

                Debug.Log("value= " + cedu + "  name =" + name + "  Eamil =" + Email + "   Phone" + Phone);
            }
            reader.Close();
            reader = null;
            dbcmd.Dispose();
            dbcmd = null;
            dbconn.Close();
            dbconn = null;
        }
    }*/
}
