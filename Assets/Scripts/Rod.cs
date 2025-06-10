using UnityEngine;
using UnityEngine.InputSystem;

public class Rod : MonoBehaviour
{
    [SerializeField] private Key leftKey;
    [SerializeField] private Key rightKey;
    [SerializeField] private float pace;

    void Update()
    {
        if (Keyboard.current[leftKey].isPressed)
        {
            transform.position += Vector3.left * pace * Time.deltaTime;
        }

        if (Keyboard.current[rightKey].isPressed)
        {
            transform.position += Vector3.right * pace * Time.deltaTime;
        }

        Rectangle rectangle = new Rectangle(transform.position, transform.lossyScale);
        CameraBorders cameraBorders = new CameraBorders();
        if (rectangle.GetLeft() < cameraBorders.GetMinX())
        {
            rectangle.SetLeft(cameraBorders.GetMinX());
        }
        else if (rectangle.GetRight() > cameraBorders.GetMaxX())
        {
            rectangle.SetRight(cameraBorders.GetMaxX());
        }
        transform.position = rectangle.GetCenter();
    }
}
