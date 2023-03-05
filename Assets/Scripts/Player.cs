using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody2D rb;
    public BirdAnimation birdAnimation;


    private void Update()
    {
        if ((Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) ||
            Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2();
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            birdAnimation.StartRotation();
        }
        birdAnimation.ApplyRotation(rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PipePart") || other.gameObject.CompareTag("Floor"))
        {
            GameManager.instance.Lose();
        }
    }
}
