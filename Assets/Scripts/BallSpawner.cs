using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ballGameObject;
    [SerializeField] private GameObject blocks;

    public void Spawn()
    {
        Debug.Log("Hello");
        GameObject ball = Instantiate(ballGameObject, new Vector3(0, -1), Quaternion.identity);
        blocks.GetComponent<Blocks>().OnBlockDestroy.AddListener(ball.GetComponent<Ball>().IncreaseSpeed);
        Destroy(gameObject);
    }

    public void SetBlocks(GameObject blocks)
    {
        this.blocks = blocks;
    }
}
