using UnityEngine;
using System.Collections;

public class Bloque : MonoBehaviour {

	private bool haColisionadoConElJugador = false;
	public int puntosGanados = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
		if(!haColisionadoConElJugador && collision.gameObject.tag == "Player"){
				haColisionadoConElJugador = true;
				NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
                NotificationCenter.DefaultCenter().PostNotification(this, "ReducirPuntos", puntosGanados);
        }
		}
	}

