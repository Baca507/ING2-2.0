using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Puntuacion : MonoBehaviour {

	private int puntuacion = 0;
    private int Intentos = 0;
	public TextMesh marcador;
    private string go = "GameOver";

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
        NotificationCenter.DefaultCenter().AddObserver(this, "ReducirPuntos");
        NotificationCenter.DefaultCenter().AddObserver(this, "GameOver");
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
    void GameOver(Notification notificacion) {

        Intentos = Intentos - 1;
        if (Intentos >= 3)
        {
            SceneManager.LoadScene(go);
        }

        
    }

    void ActualizarMarcador(){
		marcador.text = puntuacion.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
