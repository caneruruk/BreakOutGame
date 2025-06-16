using UnityEngine;

public class Block : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag != "Ball")
        {
            return;
        }

        Ball ballScript = collider2D.gameObject.GetComponent<Ball>();
        Direction ballDirection = new Direction(ballScript.GetDirection());
        Rectangle ballRectangle = new Rectangle(collider2D.gameObject.transform.position, collider2D.gameObject.transform.lossyScale);
        Rectangle thisRectangle = new Rectangle(transform.position, transform.lossyScale);

        if (ballDirection.isTopLeft())
        {
            if (ballRectangle.GetCenter().x > thisRectangle.GetLeft() && ballRectangle.GetCenter().x < thisRectangle.GetRight())
            {
                ballRectangle.SetTop(thisRectangle.GetBottom());
                ballScript.SwapDirectionVertically();
            }
            else
            {
                ballRectangle.SetLeft(thisRectangle.GetRight());
                ballScript.SwapDirectionHorizontally();
            }
        }
        else if (ballDirection.isTopRight())
        {
            if (ballRectangle.GetCenter().x > thisRectangle.GetLeft() && ballRectangle.GetCenter().x < thisRectangle.GetRight())
            {
                ballRectangle.SetTop(thisRectangle.GetBottom());
                ballScript.SwapDirectionVertically();
            }
            else
            {
                ballRectangle.SetRight(thisRectangle.GetLeft());
                ballScript.SwapDirectionHorizontally();
            }
        }
        else if (ballDirection.isBottomLeft())
        {
            if (ballRectangle.GetCenter().x > thisRectangle.GetLeft() && ballRectangle.GetCenter().x < thisRectangle.GetRight())
            {
                ballRectangle.SetBottom(thisRectangle.GetTop());
                ballScript.SwapDirectionVertically();
            }
            else
            {
                ballRectangle.SetLeft(thisRectangle.GetRight());
                ballScript.SwapDirectionHorizontally();
            }
        }
        else if (ballDirection.isBottomRight())
        {
            if (ballRectangle.GetCenter().x > thisRectangle.GetLeft() && ballRectangle.GetCenter().x < thisRectangle.GetRight())
            {
                ballRectangle.SetBottom(thisRectangle.GetTop());
                ballScript.SwapDirectionVertically();
            }
            else
            {
                ballRectangle.SetRight(thisRectangle.GetLeft());
                ballScript.SwapDirectionHorizontally();
            }
        }
        else if (ballDirection.isTop())
        {
            ballRectangle.SetTop(thisRectangle.GetBottom());
            ballScript.SwapDirectionVertically();
        }
        else if (ballDirection.isBottom())
        {
            ballRectangle.SetBottom(thisRectangle.GetTop());
            ballScript.SwapDirectionVertically();
        }
        else if (ballDirection.isLeft())
        {
            ballRectangle.SetLeft(thisRectangle.GetRight());
            ballScript.SwapDirectionHorizontally();
        }
        else if (ballDirection.isRight())
        {
            ballRectangle.SetRight(thisRectangle.GetLeft());
            ballScript.SwapDirectionHorizontally();
        }
    }
}
