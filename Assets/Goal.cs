using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public string nextSceneName = "Level_2"; // Đổi thành tên scene tiếp theo

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Kiểm tra đúng tag Player
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
