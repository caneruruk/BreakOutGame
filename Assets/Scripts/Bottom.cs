using UnityEngine;
using UnityEngine.Events;

public class Bottom : MonoBehaviour
{
    [SerializeField] private UnityEvent OnBallInBottom;

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag != "Ball")
        {
            return;
        }

        OnBallInBottom?.Invoke();
    }
}
