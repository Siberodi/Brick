
using UnityEngine;

public class Brick : MonoBehaviour
{
    public SpriteRenderer spriteRenderer { get; private set; }
    public Sprite[] states;
    public int health {  get; private set; }
    public bool irrompible;
    public int points = 10;

    private void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        ResetBrick();
    }

    public void ResetBrick()
    {
        //this.gameObject.SetActive(true);
        if (!this.irrompible)
        {
            this.health = this.states.Length;
            this.spriteRenderer.sprite = this.states[this.health - 1];
        }
    }

    private void hit()
    {
        if(this.irrompible) {
            return;
        }
        this.health--;
        
        if(this.health <= 0)
        {
            this.gameObject.SetActive(false);   
        }else{
            this.spriteRenderer.sprite = this.states[(int)this.health - 1];
        }
        FindObjectOfType<gameManager>().hit(this);
    }

    private void OnCollisionEnter2D(Collision2D colision )
    {
        ball pelota = colision.gameObject.GetComponent<ball>();
        if (pelota != null)
        {
            hit();
        }
    }
}
