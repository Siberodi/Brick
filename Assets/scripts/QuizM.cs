using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizM : MonoBehaviour
{
   public List<PregYResp> QA;
   public GameObject[] opciones;
   public int PreguntaGenerada;
   public Text TextoPreguntas;
   public GameObject PanelQuiz;
   public GameObject SigPanel;
   

   private void Start()
   {
       SigPanel.SetActive(false);
       GenerarPregunta();
   }

   public void correcta()
   {
        QA.RemoveAt(PreguntaGenerada);
     GenerarPregunta();
   }


   void DarRespuesta()
   {
    for(int i = 0; i < opciones.Length; i++)
    {
        opciones[i].GetComponent<RespuestasScript>().Escorrecta = false;
        opciones[i].transform.GetChild(0).GetComponent<Text>().text = QA[PreguntaGenerada].Respuestas[i];

        if(QA[PreguntaGenerada].RespCorrecta == i+1)
        {
            opciones[i].GetComponent<RespuestasScript>().Escorrecta = true;
        }
    }
   }

   public void volver()
   {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
   void Fin()
   {
       PanelQuiz.SetActive(false);
       SigPanel.SetActive(true);
   }
   
   void GenerarPregunta()
   {
    if(QA.Count > 0){
        PreguntaGenerada = Random.Range(0,QA.Count);
    TextoPreguntas.text = QA[PreguntaGenerada].Pregunta;
    DarRespuesta();
    }else{
        Debug.Log("Se acabó el cuestionario");
        Fin();
    }
    


   }
}
