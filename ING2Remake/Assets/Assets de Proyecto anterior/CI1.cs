using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CI1 : MonoBehaviour {
    GameObject[] Info1;
    //int puntaje;
    // Use this for initialization
    private void Start()
    {
        Info1 = GameObject.FindGameObjectsWithTag("Info1");
        
    }
    public void Cambiarescena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void Salir()
    {
        Application.Quit();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Info1")
        {
            foreach (GameObject element in Info1)
            {
                element.gameObject.SetActive(true);
                Debug.Log("Se confirma activacion de triger infoooooo");
            }

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Info1")
        {
            foreach (GameObject element in Info1)
            {
                element.gameObject.SetActive(false);
                Debug.Log("Se confirma activacion y ha salido de la colision info");
            }
        }
    }
}
