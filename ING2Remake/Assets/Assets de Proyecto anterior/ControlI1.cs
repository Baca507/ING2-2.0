using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlI1 : MonoBehaviour {
    GameObject[] Info1;
    public GameObject I1;
    //int puntaje;
    // Use this for initialization
    private void Start()
    {
        Info1 = GameObject.FindGameObjectsWithTag("Info1");
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            foreach (GameObject element in Info1)
            {
                element.gameObject.SetActive(true);
                Debug.Log("Se confirma activacion de triger infoOOOOOOOOOO");
            }

        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            foreach (GameObject element in Info1)
            {
                element.gameObject.SetActive(false);
                Debug.Log("Se confirma activacion y ha salido de la colision infoOOOOOOOOOOOO");
            }
        }
    }
}
