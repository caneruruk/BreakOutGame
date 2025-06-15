using UnityEngine;
using UnityEngine.InputSystem;

public class Rod : MonoBehaviour
{
    private bool isMouseMoved = false;
    [SerializeField] private GameObject leftWall;
    [SerializeField] private GameObject rightWall;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (!isMouseMoved)
        {
            if (Mouse.current.delta.ReadValue() != Vector2.zero)
            {
                isMouseMoved = true;
            }
        }
        else
        {
            Vector3 deltaMousePositionInWorldUnits = GetDeltaMousePositionInWorldUnits();
            transform.position = new Vector3(transform.position.x + deltaMousePositionInWorldUnits.x, transform.position.y, transform.position.z);

            Rectangle thisRectangle = new Rectangle(transform.position, transform.lossyScale);
            Rectangle leftWallRectangle = new Rectangle(leftWall.transform.position, leftWall.transform.lossyScale);
            Rectangle rightWallRectangle = new Rectangle(rightWall.transform.position, rightWall.transform.lossyScale);

            if (thisRectangle.GetLeft() < leftWallRectangle.GetRight())
            {
                thisRectangle.SetLeft(leftWallRectangle.GetRight());
            }

            if (thisRectangle.GetRight() > rightWallRectangle.GetLeft())
            {
                thisRectangle.SetRight(rightWallRectangle.GetLeft());
            }

            transform.position = thisRectangle.GetCenter();
        }
    }

    private Vector3 GetDeltaMousePositionInWorldUnits()
    {
        Vector2 deltaMousePositionInPixels = Mouse.current.delta.ReadValue();
        return 16 * deltaMousePositionInPixels / Camera.main.pixelWidth;
    }
}
