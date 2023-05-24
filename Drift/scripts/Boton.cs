using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Boton : MonoBehaviour
{
    public Button empezar, StartBrick;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = empezar.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        Button btn2 = StartBrick.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(2);
        Debug.Log("si sirveeeeeeeeeeeeeeeeeeeeeeeee");

    }
    void TaskOnClick2()
    {
        SceneManager.LoadScene(6);
        Debug.Log("si sirveeeeeeeeeeeeeeeeeeeeeeeee");

    }
}

