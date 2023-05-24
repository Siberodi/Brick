using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespuestasScript : MonoBehaviour
{
    public bool Escorrecta = false;
    public QuizM Manejo;
    public void Respuesta()
    {
        if(Escorrecta){
            Debug.Log("Respuesta Dada");
            Manejo.correcta();
        }
        else
        {
            Debug.Log("Respuesta Dada");
            Manejo.correcta();
        }

    }
}
