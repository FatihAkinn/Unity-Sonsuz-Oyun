using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public GameObject objectToDestroy; // Yok edilecek nesnenin referansı

    public void DestroyObject()
    {
        Destroy(objectToDestroy); // Nesneyi yok et
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject otherObject = collision.gameObject;

        // İlk obje bu kodu içeren obje ise çarpışma işlemini gerçekleştirme
        if (gameObject.CompareTag("Destroyer"))
        {
            // İki objenin boyutunu karşılaştırma
            if (transform.localScale.x > otherObject.transform.localScale.x)
            {
                // Küçük olan objeyi yok etme
                Destroy(otherObject);
            }
            else
            {
                // Büyük olan objeyi yok etme
                Destroy(gameObject);
            }
        }
    }
}
