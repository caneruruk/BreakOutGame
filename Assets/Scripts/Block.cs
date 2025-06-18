using UnityEngine;
using UnityEngine.Events;

public class Block : MonoBehaviour
{
    public UnityEvent OnDestroy;

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag != "Ball")
        {
            return;
        }

        OnDestroy?.Invoke();
        Destroy(gameObject);
    }
}
