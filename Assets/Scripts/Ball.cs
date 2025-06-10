using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float pace;

    void Update()
    {
        transform.position += direction.normalized * pace * Time.deltaTime;

        Rectangle rectangle = new Rectangle(transform.position, transform.lossyScale);
        CameraBorders cameraBorders = new CameraBorders();
        if (rectangle.GetLeft() < cameraBorders.GetMinX())
        {
            rectangle.SetLeft(cameraBorders.GetMinX());
            direction.x = -direction.x;
        }
        else if (rectangle.GetRight() > cameraBorders.GetMaxX())
        {
            rectangle.SetRight(cameraBorders.GetMaxX());
            direction.x = -direction.x;
        }

        if (rectangle.GetTop() > cameraBorders.GetMaxY())
        {
            rectangle.SetTop(cameraBorders.GetMaxY());
            direction.y = -direction.y;
        }
        else if (rectangle.GetBottom() < cameraBorders.GetMinY())
        {
            rectangle.SetBottom(cameraBorders.GetMinY());
            direction.y = -direction.y;
        }
    }
}
