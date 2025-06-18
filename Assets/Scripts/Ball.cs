using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float pace;
    private new Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.linearVelocity = direction.normalized * pace;
    }

    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection;
        rigidbody2D.linearVelocity = direction.normalized * pace;
    }

    public Vector3 GetDirection()
    {
        return direction;
    }

    public void SwapDirectionHorizontally()
    {
        direction.x = -direction.x;
    }

    public void SwapDirectionVertically()
    {
        direction.y = -direction.y;
    }
}
