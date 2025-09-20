using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScene2 : MonoBehaviour
{
    public Timer tiempoEscena;

    public void DetenerYMostrarTiempoTotal()
    {
        if (tiempoEscena != null && GameManager.Instance != null)
        {

            tiempoEscena.TimerStop();

            float tiempoEscena2 = tiempoEscena.ObtenerTiempoFinal();
            GameManager.Instance.SumaTimeGlobal(tiempoEscena2);

            float total = GameManager.Instance.Globaltime1;

            int minutos = (int)total / 60;
            int segundos = (int)total % 60;
            int centesimas = (int)((total - (minutos * 60 + segundos)) * 100);

            string tiempoFormateado = string.Format("{0:00}:{1:00}:{2:00}", minutos, segundos, centesimas);

            Debug.Log("Tiempo total acumulado: " + tiempoFormateado);
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
