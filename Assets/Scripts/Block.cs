using UnityEngine;
using UnityEngine.Events;

public class Block : MonoBehaviour
{
    [SerializeField] private int points;
    public UnityEvent<int> OnDestroy;

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag != "Ball")
        {
            return;
        }

        OnDestroy?.Invoke(points);
        Destroy(gameObject);
    }
}
