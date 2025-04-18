using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    // Tên scene kế tiếp, chỉnh trong Unity Editor
    public string nextSceneName = "Level_2"; // Ví dụ: "Level_3" cho level 2

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Kiểm tra player chạm vào
        {
            SceneManager.LoadScene(nextSceneName); // Load scene tiếp theo
        }
    }
}