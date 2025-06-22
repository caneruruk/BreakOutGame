using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    private TextMeshProUGUI text;
    private int score;

    public void IncrementScore(int points, float increaseSpeed, float decreaseWidth)
    {
        score += points;
    }

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        text.text = score.ToString();
    }
}
