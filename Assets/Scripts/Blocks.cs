using UnityEngine;
using UnityEngine.Events;

[ExecuteAlways]
public class Blocks : MonoBehaviour
{
    [SerializeField] private GameObject[] blocks;
    [SerializeField] private Vector2 size;
    [SerializeField] private Vector2 screenSize;
    [SerializeField] private float gap;
    [SerializeField] public UnityEvent<int, float, float> OnBlockDestroy;
    [SerializeField] private UnityEvent OnEmpty;
    [SerializeField] private AudioClip scoreAudio;
    [SerializeField] private AudioClip finishedSound;

    private void OnBlockDestroyed(int points, float increaseSpeed, float decreaseWidth)
    {
        AudioSource.PlayClipAtPoint(scoreAudio, transform.position);

        OnBlockDestroy?.Invoke(points, increaseSpeed, decreaseWidth);

        if (transform.childCount == 0)
        {
            AudioSource.PlayClipAtPoint(finishedSound, Vector2.zero);

            OnEmpty?.Invoke();
        }
    }

    void Start()
    {
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            GameObject child = transform.GetChild(i).gameObject;
            if (Application.isEditor)
            {
                DestroyImmediate(child);
            }
            else
            {
                Destroy(child);
            }
        }

        Vector2 blockSize = new Vector2(screenSize.x / size.x, screenSize.y / size.y);
        for (int y = 0; y < size.y; y++)
        {
            for (int x = 0; x < size.x; x++)
            {
                Vector3 position = new Vector3(transform.position.x + -size.x / 2 * blockSize.x + (blockSize.x / 2) + blockSize.x * x, transform.position.y + -size.y / 2 * blockSize.y + (blockSize.y / 2) + blockSize.y * y);

                GameObject newBlock = Instantiate(BlockToInstantiate(y));
                newBlock.transform.localPosition = position;
                newBlock.transform.localScale = new Vector2(blockSize.x - gap / 2, blockSize.y - gap / 2);
                newBlock.transform.SetParent(transform);
                newBlock.GetComponent<Block>().OnDestroy.AddListener(OnBlockDestroyed);
            }
        }
    }

    private GameObject BlockToInstantiate(int y)
    {
        return blocks[(int)(y / (size.y / blocks.Length))];
    }
}
