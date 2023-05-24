using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public CoinManager coinmanager;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            coinmanager.RecuperarVida();
            Destroy(this.gameObject);
        }
    }
}
