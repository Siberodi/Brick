using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class HUD : MonoBehaviour
{
    public CoinManager coinManager;
    public TextMeshProUGUI puntos;
    public GameObject[] vidas;
    [SerializeField] private TextMeshProUGUI Coins;
    [SerializeField] private Text Score;
    [SerializeField] private sebmov playerController;
    // Update is called once per frame
    private void Start()
    {
       
    }
    void Update()
    {
        puntos.text = coinManager.Puntostotales.ToString();
        try
        {
            Coins.text = coinManager.Puntostotales.ToString();
            Score.text = playerController.puntos.ToString();
        }
        catch
        {

        }
    }

    public void ActualizarPuntos(int PuntosTotales)
    {
        puntos.text = PuntosTotales.ToString();
    }

    public void DesactivarVidas(int indice)
    {
        vidas[indice].SetActive(false);
        Debug.Log("sirvio");

    }

    public void ActivarVidas(int indice)
    {
        vidas[indice].SetActive(true);
        Debug.Log("sirvio2");
    }
}
