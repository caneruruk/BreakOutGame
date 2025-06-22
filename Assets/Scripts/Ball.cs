using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float startingPace;
    private float pace;
    private new Rigidbody2D rigidbody2D;

    void Awake()
    {
        pace = startingPace;
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.MovePosition(new Vector2(Random.Range(-3.5f, 3.5f), -1));
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

    public float GetPace()
    {
        return pace;
    }

    public void IncreaseSpeed(int points, float increaseSpeed, float decreaseWidth)
    {
        float newPace = startingPace * increaseSpeed;
        if (newPace > pace)
        {
            pace = newPace;
            rigidbody2D.linearVelocity = rigidbody2D.linearVelocity.normalized * pace;
        }
    }
}
