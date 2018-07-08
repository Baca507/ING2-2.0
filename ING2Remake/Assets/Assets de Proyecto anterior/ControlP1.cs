using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlP1 : MonoBehaviour {
    GameObject[] Pregunta1, Cierto, Falso, CiertoS, FalsoS;
    public GameObject correctSign, incorrectSign,P1;
    //int puntaje;
    // Use this for initialization
    private void Start()
    {
        Pregunta1 = GameObject.FindGameObjectsWithTag("Pregunta1");
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
    void OnTriggerEnter2D(Collider2D other)
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
            foreach (GameObject element in Pregunta1)
            {
                element.gameObject.SetActive(true);
                Debug.Log("Se confirma activacion de triger info");
            }

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            foreach (GameObject element in Pregunta1)
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
