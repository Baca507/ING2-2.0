using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlP2 : MonoBehaviour {
    GameObject[] Pregunta2, Cierto, Falso, CiertoS, FalsoS;
    public GameObject correctSign, incorrectSign,P2;
    //int puntaje;
    // Use this for initialization
    private void Start()
    {
        Pregunta2 = GameObject.FindGameObjectsWithTag("Pregunta2");
        Cierto = GameObject.FindGameObjectsWithTag("Cierto");
        Falso = GameObject.FindGameObjectsWithTag("Falso");
        CiertoS = GameObject.FindGameObjectsWithTag("CiertoS");
        FalsoS = GameObject.FindGameObjectsWithTag("FalsoS");

        foreach (GameObject element in Cierto)
        {
            element.gameObject.SetActive(true);
        }
        foreach (GameObject element in Falso)
        {
            element.gameObject.SetActive(true);
        }
    }
    public void Cambiarescena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void Salir()
    {
        Application.Quit();
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            foreach (GameObject element in Cierto)
            {
                element.gameObject.SetActive(true);
            }
            foreach (GameObject element in Falso)
            {
                element.gameObject.SetActive(true);
            }
            foreach (GameObject element in Pregunta2)
            {
                element.gameObject.SetActive(true);
                Debug.Log("Se confirma activacion de triger info");
            }

        }
    }
    public void RightAnswer(string resp)
    {
        try {
            // Disabling game objects that are no longer needed
            foreach (GameObject element in Pregunta2)
            {
                element.gameObject.SetActive(false);
            }
            foreach (GameObject element in Cierto)
            {
                element.gameObject.SetActive(false);
            }
            foreach (GameObject element in Falso)
            {
                element.gameObject.SetActive(false);
            }
            if (resp == "Correcto")
            {
                // Turn on "correct" sign
                //puntaje = puntaje + 5;
                correctSign.gameObject.SetActive(true);
                Debug.Log("Respuesta Correcta, ha ganado 5 puntos Pase a la Siguiente Pregunta");
            }
            else
            {
                // puntaje = puntaje - 5;
                incorrectSign.gameObject.SetActive(true);
                Debug.Log("Respuesta Incorrecta, ha perdido 5 puntos Pase a la Siguiente Pregunta");
            }
            } catch (System.NullReferenceException ex) {
            Debug.Log("myLight was not set in the inspector"+ex);
            }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            foreach (GameObject element in Pregunta2)
            {
                element.gameObject.SetActive(false);
                Debug.Log("Se confirma activacion y ha salido de la colision info");
            }
            foreach (GameObject element in CiertoS)
            {
                element.gameObject.SetActive(false);
                Debug.Log("Se confirma activacion y ha salido de la colision info");
            }
            foreach (GameObject element in FalsoS)
            {
                element.gameObject.SetActive(false);
                Debug.Log("Se confirma activacion y ha salido de la colision info");
            }
        }
    }
}
