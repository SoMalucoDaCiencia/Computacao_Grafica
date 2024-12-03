using UnityEngine;

public class Aliens : MonoBehaviour
{
    public float speed = 2f;
    private Vector3 direction;

    void Start()
    {
        direction = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.magnitude > 10f) // Limite do mundo
            direction = -direction;
    }
}
