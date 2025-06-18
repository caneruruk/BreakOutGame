using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    private TextMeshProUGUI text;
    private int score;

    public void IncrementScore(int points)
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
