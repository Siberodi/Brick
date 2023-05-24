using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class reinicio : MonoBehaviour
{
    
    public Text score;
    public Button reiniciar;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = reiniciar.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(0);
        Debug.Log("si sirveeeeeeeeeeeeeeeeeeeeeeeee");

    }

}
