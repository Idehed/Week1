using UnityEngine;

public class LeftAndRight : MonoBehaviour
{
    [SerializeField] private float delta = 1.5f;
    [SerializeField] public float speed = 2.0f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
