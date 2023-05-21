
using UnityEngine;

public class paddle : MonoBehaviour
{

    public new Rigidbody2D rigidbody { get; private set; }
    public Vector2 direction { get; private set; }
    public float speed = 30f;
    public float maxBounceAngle = 75f;

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>(); //no lo entiendo mucho, solo se que 
        //rigid body es para el movimiento
    }

    public void ResetPaddle()
    {
        this.rigidbody.velocity = Vector2.zero;
        this.transform.position = new Vector2(0f, this.transform.position.y);
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.direction = Vector2.left;
        }else if (Input.GetKey(KeyCode.RightArrow)) {
            this.direction = Vector2.right;
        }else {
            this.direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
       if (this.direction != Vector2.zero)
       {
       this.rigidbody.AddForce(this.direction * this.speed);
       }
    }

    private void OnCollisionEnter2D(Collision2D colision)
    {
        ball pelota = colision.gameObject.GetComponent<ball>();
        if (pelota != null)
        {
            Vector3 paddlePosicion = this.transform.position;
            Vector2 contactPoint = colision.GetContact(0).point;

            float offset = paddlePosicion.x - contactPoint.x;
            float paddleWidht = colision.otherCollider.bounds.size.x / 2;

            float currentAngle = Vector2.SignedAngle(Vector2.up, pelota.rigidbody.velocity);
            float bounceAngle = (offset / paddleWidht)* this.maxBounceAngle;
            float newAngle = Mathf.Clamp(currentAngle + bounceAngle, -this.maxBounceAngle, this.maxBounceAngle);

            Quaternion rotation = Quaternion.AngleAxis(newAngle, Vector3.forward);
            pelota.rigidbody.velocity = rotation * Vector2.up * pelota.rigidbody.velocity.magnitude;
        }
    }
    
}