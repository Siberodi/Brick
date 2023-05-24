
using UnityEngine;
using UnityEngine.SceneManagement; //Para manejo de pestañas, o niveles
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public ball bolita { get; private set; }
    public paddle barra { get; private set; } 
    public Brick bricks { get; private set; } 

    public int score = 0;
    public int lives = 3;
    public int pestaña = 1;
   // public Button start; 

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnLevelLoaded;
        
    }
    private void Start()
    {
        //loadGame(1);
        newGame();
        //Button btn = start.GetComponent<Button>();
        //btn.onClick.AddListener(TaskOnClick);
    }

    public void EscenaJuego()
    {
        LoadGame(2);
    }

    private void newGame()
    {
        this.score = 0;
        this.lives = 3;
        LoadGame(1);
    }

    private void LoadGame(int pestaña)
    {
        this.pestaña = pestaña;
        SceneManager.LoadScene(pestaña);
    }

    private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
    {
        this.bolita = FindObjectOfType<ball>();
        this.barra = FindObjectOfType<paddle>();
        this.bricks = FindObjectOfType<Brick>();
    }

    private void ResetLevel()
    {
        this.bolita.ResetBall();
        this.barra.ResetPaddle();

      //  for(int i = 0; i < this.bricks.Lenght; i++)
       // {
           // this.bricks[i].ResetBrick();
        //}
    }
    
    private void GameOver()
    {
        LoadGame(2);
    }

    public void Dead()
    {
        this.lives--;

        if (this.lives > 0)
        {
            ResetLevel();
        }
        else if (this.lives <= 0)
        {
            GameOver();
        }
    }

    public void hit(Brick brick)
    {
        this.score += brick.points;
    }

   

    
}
