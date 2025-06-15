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
            direction.y = -direction.y;
        }

        if (thisRectangle.GetBottom() < bottomWallRectangle.GetTop())
        {
            thisRectangle.SetBottom(bottomWallRectangle.GetTop());
            direction.y = -direction.y;
        }

        if (thisRectangle.GetLeft() < leftWallRectangle.GetRight())
        {
            thisRectangle.SetLeft(leftWallRectangle.GetRight());
            direction.x = -direction.x;
        }

        if (thisRectangle.GetRight() > rightWallRectangle.GetLeft())
        {
            thisRectangle.SetRight(rightWallRectangle.GetLeft());
            direction.x = -direction.x;
        }

        transform.position = thisRectangle.GetCenter();
    }
}
