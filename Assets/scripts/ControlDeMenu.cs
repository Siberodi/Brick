using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControlDeMenu : MonoBehaviour
{
    public void changeEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }
}
