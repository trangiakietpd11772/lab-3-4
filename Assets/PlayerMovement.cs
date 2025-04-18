using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;

    private Vector3 respawnPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position; // spawn ban đầu
    }

    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * moveSpeed;
    }

    void FixedUpdate()
    {
        rb.velocity = moveVelocity;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Chạm enemy!");
            if (GameManager.instance != null)
            {
                GameManager.instance.IncreaseDeathCount();
            }

            Respawn();
        }
        else if (other.CompareTag("Checkpoint"))
        {
            respawnPoint = other.transform.position + Vector3.up * 3f; // né enemy
            Debug.Log("Checkpoint saved tại: " + respawnPoint);
        }
    }

    void Respawn()
    {
        Debug.Log("Respawning...");
        transform.position = respawnPoint;
        rb.velocity = Vector2.zero;
        gameObject.SetActive(true);
    }
}
