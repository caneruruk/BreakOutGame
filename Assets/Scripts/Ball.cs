using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float pace;

    void Update()
    {
        transform.position += direction.normalized * pace * Time.deltaTime;
    }
}
