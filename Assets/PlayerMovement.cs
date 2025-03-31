using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;  // Tốc độ di chuyển
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector3 startPosition; // Lưu vị trí xuất phát ban đầu

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position; // Lưu vị trí ban đầu của player
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveInput = new Vector2(moveX, moveY).normalized; // Lấy hướng di chuyển
    }

    void FixedUpdate()
    {
        rb.velocity = moveInput * speed; // Di chuyển nhân vật
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy")) // Nếu chạm Enemy
        {
            Debug.Log("Player bị chạm! Respawn...");
            GameManager.instance.IncreaseDeathCount();
            Respawn(); // Gọi hàm respawn
        }
    }

    void Respawn()
    {
        transform.position = startPosition; // Đưa player về vị trí ban đầu
        rb.velocity = Vector2.zero; // Reset vận tốc để không bị trôi
    }
}
