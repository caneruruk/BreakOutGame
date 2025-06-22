using UnityEngine;
using UnityEngine.Events;

public class Block : MonoBehaviour
{
    [SerializeField] private int points;
    [SerializeField] private float increaseSpeed;
    [SerializeField] private float decreaseWidth;
    public UnityEvent<int, float, float> OnDestroy;

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag != "Ball")
        {
            return;
        }

        OnDestroy?.Invoke(points, increaseSpeed, decreaseWidth);
        Destroy(gameObject);
    }
}
