using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cember1 : MonoBehaviour
{
    public float speed = 10.0f;
    public string yatayEksen = "Horizontal";
    public string dikeyEksen = "Vertical";

    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw(yatayEksen);
        float moveVertical = Input.GetAxisRaw(dikeyEksen);

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        movement *= speed * Time.deltaTime;
        transform.position += movement;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
