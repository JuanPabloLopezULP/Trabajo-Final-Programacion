using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private Ray rayo;
    private Camera cam;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rayo = cam.ScreenPointToRay(Input.mousePosition);
        rb.AddForce(rayo.direction*60,ForceMode.Impulse);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Blanco_1")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Blanco_2")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Blanco_3")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Blanco_4")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Blanco_5")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Blanco_6")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Blanco_7")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Blanco_8")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Blanco_9")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Blanco_10")
        {
            Destroy(other.gameObject);
        }
    }
}
