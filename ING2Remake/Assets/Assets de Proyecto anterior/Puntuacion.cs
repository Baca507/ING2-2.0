using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {

	private int puntuacion = 0;
	public TextMesh marcador;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
        NotificationCenter.DefaultCenter().AddObserver(this, "ReducirPuntos");
        ActualizarMarcador();
	}

	void IncrementarPuntos(Notification notificacion){
		int puntosAIncrementar = (int)notificacion.data;
		puntuacion+=puntosAIncrementar;
		ActualizarMarcador();
	}
    void ReducirPuntos(Notification notificacion)
    {
        int puntosAIncrementar = (int)notificacion.data;
        puntuacion -= puntosAIncrementar;
        ActualizarMarcador();
    }

    void ActualizarMarcador(){
		marcador.text = puntuacion.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
