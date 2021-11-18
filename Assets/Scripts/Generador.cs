using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(prefab1, transform.position, transform.rotation);
            Instantiate(prefab2, transform.position, transform.rotation);
        }
    }
}
