using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    private void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        var playButton = root.Q<Button>("PlayButton");

        if (playButton != null)
        {
            playButton.clicked += () => {
                Debug.Log("Play clicked");
                SceneManager.LoadScene("Level_1"); // đổi thành tên scene của cu
            };
        }
        else
        {
            Debug.LogError("Play button not found!");
        }
    }
}