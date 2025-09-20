using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScenes : MonoBehaviour
{
    public Timer tiempoEscena;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LectorEscena(string nameScene)
    {
        if (GameManager.Instance != null && tiempoEscena != null)
        {
            tiempoEscena.TimerStop();
            GameManager.Instance.SumaTimeGlobal(tiempoEscena.ObtenerTiempoFinal());
        }

        SceneManager.LoadScene(nameScene);
    }
}
