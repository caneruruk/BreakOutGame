using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Bottom : MonoBehaviour
{
    [SerializeField] private UnityEvent OnBallInBottom;
    [SerializeField] private GameObject timerGameObject;
    [SerializeField] private GameObject ballSpawnerGameObject;

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag != "Ball")
        {
            return;
        }

        OnBallInBottom?.Invoke();
        Destroy(collider2D.gameObject);
        GameObject timer = Instantiate(timerGameObject);
        GameObject ballSpawner = Instantiate(ballSpawnerGameObject);
        timer.GetComponent<Timer>().AddListener(ballSpawner.GetComponent<BallSpawner>().Spawn);
    }
}
