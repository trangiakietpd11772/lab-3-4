using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public int totalCoins = 0; // Tổng số coin cần thu thập
    private int collectedCoins = 0; // Số coin đã nhặt
    public Text finishText; // Text thông báo Win Game

    void Start()
    {
        if (finishText != null)
        {
            finishText.gameObject.SetActive(false); // Ẩn text ban đầu
        }
    }

    public void CollectCoin()
    {
        collectedCoins++; // Tăng số coin đã nhặt
        Debug.Log("Coin collected: " + collectedCoins + "/" + totalCoins);

        if (collectedCoins >= totalCoins)
        {
            Debug.Log("Tất cả coin đã được thu thập!");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && collectedCoins >= totalCoins) // Kiểm tra đủ coin mới win
        {
            Debug.Log("YOU WIN!");
            if (finishText != null)
            {
          
                finishText.gameObject.SetActive(true); // Hiện chữ WIN
            }
            Invoke("StopGame", 1f); // Delay 1s rồi dừng game
        }
    }

    void StopGame()
    {
        Time.timeScale = 0f; // Dừng game
    }
}