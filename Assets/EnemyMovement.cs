using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 4f;

    [SerializeField]
    private bool moveLeft;

    void Update()
    {
        if (moveLeft)
        {
            Vector3 temp = transform.position;
            temp.x -= moveSpeed * Time.deltaTime;
            transform.position = temp;
        }
        else
        {
            Vector3 temp = transform.position;
            temp.x += moveSpeed * Time.deltaTime;
            transform.position = temp;
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Wall")
        {
            moveLeft = !moveLeft;
        }
    }
}