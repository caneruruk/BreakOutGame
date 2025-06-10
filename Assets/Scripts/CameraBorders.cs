using UnityEngine;

public class CameraBorders
{
    public float GetMinY()
    {
        return Camera.main.transform.position.y - Camera.main.orthographicSize;
    }

    public float GetMaxY()
    {
        return Camera.main.transform.position.y + Camera.main.orthographicSize;
    }

    public float GetMinX()
    {
        return Camera.main.transform.position.x - GetHalfWidth();
    }

    public float GetMaxX()
    {
        return Camera.main.transform.position.x + GetHalfWidth();
    }

    private float GetHalfWidth()
    {
        return Camera.main.orthographicSize * Camera.main.aspect;
    }
}