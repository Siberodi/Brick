using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class MainMenuController : MonoBehaviour
{
    gameManager game_manager;
    TextMeshProUGUI puntos;
    TextMeshProUGUI nivel;
    
    // Start is called before the first frame update
    void Start()
    {
        try
        {

            game_manager = FindAnyObjectByType<gameManager>();
            puntos = GameObject.Find("puntos").GetComponent<TextMeshProUGUI>();
            nivel = GameObject.Find("nivel").GetComponent<TextMeshProUGUI>();      
        }
        catch
        {

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            puntos.text = "Puntos: " + game_manager.score;
            if (game_manager.score >=0 && game_manager.score <= 125)
            {
                nivel.text = "dependiente";
            }else if (game_manager.score >= 126 && game_manager.score <= 245) {
                nivel.text = "semidependiente";
            }else if(game_manager.score >= 246 && game_manager.score <= 310)
            {
                nivel.text = "coordinado";

            }else if (game_manager.score >= 311 && game_manager.score <= 400)
            {
                nivel.text = "motriz";
            }else if (game_manager.score >= 401 && game_manager.score <= 490)
            {
                nivel.text = "implacable";
            }
        }
        catch { 
            
        }
    }
    public void restart()
    {
        SceneManager.LoadScene("Global");


    }
}
