using UnityEngine;

public class MainSceneRod : MonoBehaviour
{
    [SerializeField] private float ballDirectionMultiplier = 1;

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag != "Ball")
        {
            return;
        }

        Vector3 newDirection = new Vector3((collider2D.gameObject.transform.position.x - transform.position.x) / (transform.lossyScale.x / 2) * ballDirectionMultiplier, 1, 0);
        collider2D.gameObject.GetComponent<MainSceneBall>().SetDirection(newDirection);

        Rectangle thisRectangle = new Rectangle(transform.position, transform.lossyScale);
        Rectangle otherRectangle = new Rectangle(collider2D.gameObject.transform.position, collider2D.transform.lossyScale);

        otherRectangle.SetBottom(thisRectangle.GetTop());

        collider2D.gameObject.transform.position = otherRectangle.GetCenter();
    }

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
