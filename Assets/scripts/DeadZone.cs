
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D colision)
    {
        ball pelota = colision.gameObject.GetComponent<ball>();
        if (pelota != null)
        {
            FindObjectOfType<gameManager>().Dead();
        }
    }
}
