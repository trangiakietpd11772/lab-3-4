using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text deathText;
    public Text timeText;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Giữ UI khi đổi màn
        }
        else
        {
            Destroy(gameObject); // Nếu đã có UIManager, hủy cái mới
        }
    }

    public void UpdateDeathCount(int deathCount)
    {
        if (deathText != null)
            deathText.text = "Deaths: " + deathCount;
    }

    public void UpdateTime(float playTime)
    {
        if (timeText != null)
            timeText.text = "Time: " + playTime.ToString("F2") + "s";
    }
}
