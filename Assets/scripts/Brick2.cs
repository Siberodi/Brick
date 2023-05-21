using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Brick2 : MonoBehaviour
{
    public SpriteRenderer spriteRenderer { get; private set; }
    public Sprite[] states;
    public int health { get; private set; }
    public bool irrompible;

    private void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        if (!this.irrompible)
        {
            this.health = this.states.Length;
            this.spriteRenderer.sprite = this.states[this.health - 1];
        }
    }
    private void hit()
    {
        if (this.irrompible)
        {
            return;
        }
        this.health--;
        if (this.health <= 0)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.spriteRenderer.sprite = this.states[(int)this.health - 1];
        }
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "ball")
        {
            hit();
        }
    }
}

