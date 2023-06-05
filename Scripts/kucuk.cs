using UnityEngine;

public class CircleController : MonoBehaviour
{
    public float growthRate = 0.1f; // Dairenin büyüme hızı

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Food")) // Yemek etiketi "Food" olarak varsayılmıştır
        {
            transform.localScale += new Vector3(growthRate, growthRate, 0); // Dairenin ölçeğini büyüt
            Destroy(collision.gameObject); // Yemek nesnesini yok et
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject otherObject = collision.gameObject;

        if (gameObject.CompareTag("Destroyer"))
        {
            if (transform.localScale.x > otherObject.transform.localScale.x)
            {
                Destroy(otherObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
