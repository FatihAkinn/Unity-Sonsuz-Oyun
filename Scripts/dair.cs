using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NesneYokEtme : MonoBehaviour
{
    public GameObject hedefNesne;
    public float speed;
    public string yatayEksen;
    public string dikeyEksen;

    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw(yatayEksen);
        float moveVertical = Input.GetAxisRaw(dikeyEksen);

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f);
        movement *= speed * Time.deltaTime;
        transform.position += movement;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(hedefNesne);
        }
    }
}
