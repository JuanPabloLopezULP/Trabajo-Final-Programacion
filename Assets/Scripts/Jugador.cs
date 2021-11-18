using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    private Camera cam;
    Rigidbody rb;
    public float velocidad = 50f;
    public GameObject prefab;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Movimiento();
        Salto();
    }

    public void Movimiento()
    {
        if ((Input.GetKey(KeyCode.UpArrow)) && (Input.GetKey(KeyCode.RightArrow)))
        {
            rb.MovePosition(transform.position + transform.forward / 5);
            transform.Rotate(Vector3.up, 1);
        }
        else if ((Input.GetKey(KeyCode.UpArrow)) && (Input.GetKey(KeyCode.LeftArrow)))
        {
            rb.MovePosition(transform.position + transform.forward / 5);
            transform.Rotate(Vector3.down, 1);
        }
        if ((Input.GetKey(KeyCode.DownArrow)) && (Input.GetKey(KeyCode.RightArrow)))
        {
            rb.MovePosition(transform.position - transform.forward / 5);
            transform.Rotate(Vector3.up, 1);
        }
        else if ((Input.GetKey(KeyCode.DownArrow)) && (Input.GetKey(KeyCode.LeftArrow)))
        {
            rb.MovePosition(transform.position - transform.forward / 5);
            transform.Rotate(Vector3.down, 1);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.MovePosition(transform.position + transform.forward / 5);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.MovePosition(transform.position - transform.forward/5);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down, 1);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, 1);
        }        
    }
    public void Salto()
    {
        if (rb.transform.position.y < 2)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(Vector3.up/5, ForceMode.Impulse);
            }
        }
    }
}
