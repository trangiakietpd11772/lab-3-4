using UnityEngine;
using UnityEngine.UIElements;

public class PauseMenuManager : MonoBehaviour
{
    public UIDocument pauseMenuUI;
    private VisualElement root;

    private void OnEnable()
    {
        root = pauseMenuUI.rootVisualElement;
        root.style.display = DisplayStyle.None; // Ẩn menu lúc đầu

        Button resumeButton = root.Q<Button>("resume-button");
        resumeButton.clicked += ResumeGame;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        bool isPaused = root.style.display == DisplayStyle.Flex;
        root.style.display = isPaused ? DisplayStyle.None : DisplayStyle.Flex;
        Time.timeScale = isPaused ? 1f : 0f;
    }

    void ResumeGame()
    {
        root.style.display = DisplayStyle.None;
        Time.timeScale = 1f;
    }
}
