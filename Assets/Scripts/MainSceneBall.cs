using UnityEngine;

public class MainSceneBall : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float pace;
    [SerializeField] private new Rigidbody2D rigidbody2D;

    void Awake()
    {
        rigidbody2D.MovePosition(new Vector2(Random.Range(-3.5f, 3.5f), -1));
        rigidbody2D.linearVelocity = direction.normalized * pace;
    }

    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection;
        rigidbody2D.linearVelocity = direction.normalized * pace;
    }
}
