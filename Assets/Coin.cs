using UnityEngine;

public class Coin : MonoBehaviour
{
    private Finish finish; 

    void Start()
    {
        finish = FindObjectOfType<Finish>(); // Tìm Finish trong Scene
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            finish.CollectCoin(); // Báo cho Finish biết đã nhặt Coin
            Destroy(gameObject); // Xóa Coin
        }
    }
}