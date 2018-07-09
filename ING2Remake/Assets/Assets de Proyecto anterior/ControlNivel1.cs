using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlNivel1 : MonoBehaviour {
    GameObject[] CiertoS, Cierto,Falso,FalsoS;
    public GameObject correctSign, incorrectSign;
    //private bool haColisionadoConElJugador = false;
    public int puntosGanados = 1;
    public int puntosPerdidos = 1;
    public int Intentos = 1;
    //int puntaje;
    // Use this for initialization
    private void Start()
    {
        Cierto = GameObject.FindGameObjectsWithTag("Cierto");
        CiertoS = GameObject.FindGameObjectsWithTag("CiertoS");
        Falso = GameObject.FindGameObjectsWithTag("Falso");
        FalsoS = GameObject.FindGameObjectsWithTag("FalsoS");
    }
    public void Cambiarescena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void Salir()
    {
        Application.Quit();
    }

    public void RightAnswer()
    {
        try {
            foreach (GameObject element in Cierto)
            {
                element.gameObject.SetActive(false);
            }
            foreach (GameObject element in Falso)
            {
                element.gameObject.SetActive(false);
            }
            foreach (GameObject element in CiertoS)
            {
                element.gameObject.SetActive(true);
            }
                correctSign.gameObject.SetActive(true);
                NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
                Debug.Log("Respuesta Correcta, ha ganado 5 puntos Pase a la Siguiente Pregunta");

            } catch (System.NullReferenceException ex) {
            Debug.Log("ERROR DE VARIABLE NOINSTANCIADAOREFERENCIADA"+ex);
            }

    }
    public void WrongAnswer()
    {
        try
        {
            foreach (GameObject element in Cierto)
            {
                element.gameObject.SetActive(false);
            }
            foreach (GameObject element in Falso)
            {
                element.gameObject.SetActive(false);
            }
            foreach (GameObject element in CiertoS)
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
    //void OnCollisionEnter2D(Collision2D collision)
    //{
    /* if (!haColisionadoConElJugador && collision.gameObject.tag == "Player")
     {
         haColisionadoConElJugador = true;
         NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
     }
 }*/
}
