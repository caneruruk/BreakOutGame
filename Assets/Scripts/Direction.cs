using UnityEngine;

public class Direction
{
    public Direction(Vector3 vector3)
    {
        this.vector3 = vector3;
    }

    public bool isTop()
    {
        return vector3.y > 0;
    }

    public bool isBottom()
    {
        return vector3.y < 0;
    }

    public bool isLeft()
    {
        return vector3.x < 0;
    }

    public bool isRight()
    {
        return vector3.x > 0;
    }

    public bool isTopLeft()
    {
        return isTop() && isLeft();
    }

    public bool isTopRight()
    {
        return isTop() && isRight();
    }

    public bool isBottomLeft()
    {
        return isBottom() && isLeft();
    }

    public bool isBottomRight()
    {
        return isBottom() && isRight();
    }

    private Vector3 vector3;
}