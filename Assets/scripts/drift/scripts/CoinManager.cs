using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int Puntostotales { get { return puntostotales; } }
    private int puntostotales;
    public HUD hud;
    private int vidas = 3;
    [SerializeField] private GameObject CanvasGameOver;

    public void SumarPuntos(int puntosAsumar)
    {
        puntostotales += puntosAsumar;
        //Debug.Log(puntostotales);
        hud.ActualizarPuntos(puntostotales);
    }
    public void retry()
    {
        
        SceneManager.LoadScene("SampleScene");
    }
    public void PerderVidas()
    {
        vidas -= 1;

        if(vidas == 0)
        {
            hud.DesactivarVidas(vidas);
            CanvasGameOver.SetActive(true);
            Time.timeScale = 0f;
          
        }

        hud.DesactivarVidas(vidas);
       // vidas -= 1;
    }
    private void Start()
    {
        Time.timeScale = 1f;
        CanvasGameOver.SetActive(false);
        
    }
    public void RecuperarVida()
    {
        if(vidas == 3)
        {
            return;
        }


        hud.ActivarVidas(vidas);
        vidas += 1;
    }

}
