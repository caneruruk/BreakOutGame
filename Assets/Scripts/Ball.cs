using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float pace;
    [SerializeField] private GameObject topWall;
    [SerializeField] private GameObject bottomWall;
    [SerializeField] private GameObject leftWall;
    [SerializeField] private GameObject rightWall;

    void Update()
    {
        transform.position += direction.normalized * pace * Time.deltaTime;

        Rectangle thisRectangle = new Rectangle(transform.position, transform.lossyScale);
        Rectangle topWallRectangle = new Rectangle(topWall.transform.position, topWall.transform.lossyScale);
        Rectangle bottomWallRectangle = new Rectangle(bottomWall.transform.position, bottomWall.transform.lossyScale);
        Rectangle leftWallRectangle = new Rectangle(leftWall.transform.position, leftWall.transform.lossyScale);
        Rectangle rightWallRectangle = new Rectangle(rightWall.transform.position, rightWall.transform.lossyScale);

        if (thisRectangle.GetTop() > topWallRectangle.GetBottom())
        {
            thisRectangle.SetTop(topWallRectangle.GetBottom());
            SwapDirectionVertically();
        }

        if (thisRectangle.GetBottom() < bottomWallRectangle.GetTop())
        {
            thisRectangle.SetBottom(bottomWallRectangle.GetTop());
            SwapDirectionVertically();
        }

        if (thisRectangle.GetLeft() < leftWallRectangle.GetRight())
        {
            thisRectangle.SetLeft(leftWallRectangle.GetRight());
            SwapDirectionHorizontally();
        }

        if (thisRectangle.GetRight() > rightWallRectangle.GetLeft())
        {
            thisRectangle.SetRight(rightWallRectangle.GetLeft());
            SwapDirectionHorizontally();
        }

        transform.position = thisRectangle.GetCenter();
    }

    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection;
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
