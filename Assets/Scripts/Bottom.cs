using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Bottom : MonoBehaviour
{
    [SerializeField] private UnityEvent OnBallInBottom;
    [SerializeField] private GameObject timerGameObject;
    [SerializeField] private GameObject ballSpawnerGameObject;
    [SerializeField] private GameObject blocks;
    [SerializeField] private AudioClip dieSound;

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag != "Ball")
        {
            return;
        }

        AudioSource.PlayClipAtPoint(dieSound, collider2D.transform.position);

        OnBallInBottom?.Invoke();
        Destroy(collider2D.gameObject);
        GameObject timer = Instantiate(timerGameObject);
        GameObject ballSpawner = Instantiate(ballSpawnerGameObject);
        ballSpawner.GetComponent<BallSpawner>().SetBlocks(blocks);
        timer.GetComponent<Timer>().AddListener(ballSpawner.GetComponent<BallSpawner>().Spawn);
    }
}
