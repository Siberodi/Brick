using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class sebmov : MonoBehaviour
{
    public float JumpForce, Speed;
    private Rigidbody2D RigidBody2D;
    private Animator Animator;
    private float Horizontal;
    public Text score;
    public float puntos = 0;
    public Button Iniciar,Inicio;
    public CoinManager coinmanager;
    public GameObject CanvasGameOver;

    //public GameObject GameOver;
    //private bool Grounded;

    void Start()
    {
        //GameOver.SetActive(false);
        RigidBody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();

        

        Button btn1 = Inicio.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick2);
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        Animator.SetBool("running", Horizontal != 0.0f);

        

        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
            SumarPuntuacion();
        }

        CanvasGameOver.SetActive(true);
    }

    private void Jump()
    {
        RigidBody2D.AddForce(Vector2.up * JumpForce);
    }

    private void FixedUpdate()
    {
        RigidBody2D.velocity = new Vector2(Horizontal * Speed, RigidBody2D.velocity.y);
    }

    
    public void SumarPuntuacion()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            puntos += 100;
            score.text = puntos.ToString();
        }
    }
    void TaskOnClick()
    {
       
        Debug.Log("si sirveeeeeeeeeeeeeeeeeeeeeeeee");
        
    }

    void TaskOnClick2()
    {

        Debug.Log("si sirveeeeeeeeeeeeeeeeeeeeeeeee");

    }

    private void OnCollisionEnter2D(Collision2D fin)
    {
        if (fin.gameObject.CompareTag("Finish"))
        {
            //coinmanager.PerderVidas();
            CanvasGameOver.SetActive(true);
            
            Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            //Time.timeScale = 0f;
        }
    }


}

