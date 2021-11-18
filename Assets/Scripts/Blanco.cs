using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blanco : MonoBehaviour
{
    private Vector3 posIni;
 
    void Start()
    {
        posIni = transform.position;

    }

    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
       

        if (other.gameObject.name == "Bala")
        {
            if (posIni != transform.position)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

