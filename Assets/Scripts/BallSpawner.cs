using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ballGameObject;
    [SerializeField] private GameObject blocks;

    public void Spawn()
    {
        GameObject ball = Instantiate(ballGameObject, new Vector3(0, -1), Quaternion.identity);
        blocks.GetComponent<Blocks>().OnBlockDestroy.AddListener(ball.GetComponent<Ball>().IncreaseSpeed);
        Destroy(gameObject);
    }
}
