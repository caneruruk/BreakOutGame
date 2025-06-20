using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private UnityEvent OnHealthIsZero;

    void Update()
    {
        text.text = health.ToString();
    }

    public void DecreaseHealth()
    {
        health--;

        if (health == 0)
        {
            OnHealthIsZero?.Invoke();
        }
    }
}
