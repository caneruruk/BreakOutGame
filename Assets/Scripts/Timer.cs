using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private float time;
    private float passedTime = 0;
    [SerializeField] private UnityEvent OnTimeComes;

    void FixedUpdate()
    {
        if (passedTime > time)
        {
            OnTimeComes?.Invoke();
            Destroy(gameObject);
        }
        else
        {
            passedTime += Time.fixedDeltaTime;
        }
    }

    public void AddListener(UnityAction unityAction)
    {
        OnTimeComes.AddListener(unityAction);
    }
}
