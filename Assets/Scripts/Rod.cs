using UnityEngine;
using UnityEngine.InputSystem;

public class Rod : MonoBehaviour
{
    [SerializeField] private Key leftKey;
    [SerializeField] private Key rightKey;
    [SerializeField] private float pace;

    void Update()
    {
        if (Keyboard.current[leftKey].isPressed)
        {
            transform.position += Vector3.left * pace * Time.deltaTime;
        }

        if (Keyboard.current[rightKey].isPressed)
        {
            transform.position += Vector3.right * pace * Time.deltaTime;
        }
    }
}
