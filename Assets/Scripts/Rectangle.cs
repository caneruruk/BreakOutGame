using UnityEngine;

public class Rectangle
{
    public Rectangle(Vector3 center, Vector3 size)
    {
        this.center = center;
        this.size = size;
    }

    public Vector3 GetCenter()
    {
        return center;
    }

    public float GetLeft()
    {
        return center.x - size.x / 2;
    }

    public void SetLeft(float left)
    {
        center.x = left + size.x / 2;
    }

    public float GetRight()
    {
        return center.x + size.x / 2;
    }

    public void SetRight(float right)
    {
        center.x = right - size.x / 2;
    }

    public float GetTop()
    {
        return center.y + size.y / 2;
    }

    public void SetTop(float top)
    {
        center.y = top - size.y / 2;
    }

    public float GetBottom()
    {
        return center.y - size.y / 2;
    }

    public void SetBottom(float bottom)
    {
        center.y = bottom + size.y / 2;
    }

    private Vector3 center;
    private Vector3 size;
}