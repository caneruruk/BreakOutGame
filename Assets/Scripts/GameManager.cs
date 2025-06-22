using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private string mainSceneName;

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMainScene()
    {
        Debug.Log("Hello");
        SceneManager.LoadScene(mainSceneName);
    }
}
