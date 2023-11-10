using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-1 * Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}   