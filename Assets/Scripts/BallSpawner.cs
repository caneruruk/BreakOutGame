using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ballGameObject;

    public void Spawn()
    {
        GameObject ball = Instantiate(ballGameObject, new Vector3(0, -1), Quaternion.identity);
        Destroy(gameObject);
    }
}
