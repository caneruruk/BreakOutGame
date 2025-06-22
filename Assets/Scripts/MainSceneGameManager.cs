using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainSceneGameManager : MonoBehaviour
{
    [SerializeField] private string gameSceneName;

    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            SceneManager.LoadScene(gameSceneName);
        }

        if (Keyboard.current.escapeKey.wasReleasedThisFrame)
        {
            Application.Quit();
        }
    }
}
