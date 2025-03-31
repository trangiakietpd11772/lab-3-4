using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int deathCount = 0; // Số lần chết
    public float playTime = 0f; // Thời gian chơi
    public Text deathText;
    public Text timeText;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Giữ lại khi chuyển scene
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        playTime += Time.deltaTime; // Cập nhật thời gian liên tục
        UpdateUI();
    }

    public void IncreaseDeathCount()
    {
        deathCount++;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (deathText != null)
            deathText.text = "Deaths: " + deathCount;

        if (timeText != null)
            timeText.text = "Time: " + playTime.ToString("F2") + "s"; // Hiển thị 2 chữ số sau dấu phẩy
    }
}