using UnityEngine;

public class Block : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag != "Ball")
        {
            return;
        }

        Destroy(gameObject);
    }
}
