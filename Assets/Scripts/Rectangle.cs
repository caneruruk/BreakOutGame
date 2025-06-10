using UnityEngine;

public class Rectangle
{
    public Rectangle(Vector3 center, Vector3 size)
    {
        this.center = center;
        this.size = size;
    }

    public float GetTop()
    {
        return center.y + size.y / 2;
    }

    public float GetBottom()
    {
        return center.y - size.y / 2;
    }

    public float GetRight()
    {
        return center.x + size.x / 2;
    }

    public float GetLeft()
    {
        return center.x - size.x / 2;
    }

    public void SetLeft(float left)
    {
        center = new Vector3(left + size.x / 2, center.y, center.z);
    }

    public void SetRight(float right)
    {
        center = new Vector3(right - size.x / 2, center.y, center.z);
    }

    public Vector3 GetCenter()
    {
        return center;
    }

    private Vector3 center;
    private Vector3 size;
}