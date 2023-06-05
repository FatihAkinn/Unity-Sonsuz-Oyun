using UnityEngine;

public class HAM : MonoBehaviour
{
    public Rigidbody projectile;
    public GameObject targetObject;

    void Start()
    {
        LaunchProjectile();
    }

    void LaunchProjectile()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0);
        transform.position = randomPosition;

        Rigidbody instance = Instantiate(projectile);
        instance.velocity = Random.insideUnitSphere * 5.0f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == targetObject)
        {
            Destroy(gameObject);
        }
    }
}
