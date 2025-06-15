using UnityEngine;
using UnityEngine.InputSystem;

public class Rod : MonoBehaviour
{
    private bool isMouseMoved = false;

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
        }
    }

    private Vector3 GetDeltaMousePositionInWorldUnits()
    {
        Vector2 deltaMousePositionInPixels = Mouse.current.delta.ReadValue();
        return 16 * deltaMousePositionInPixels / Camera.main.pixelWidth;
    }
}
