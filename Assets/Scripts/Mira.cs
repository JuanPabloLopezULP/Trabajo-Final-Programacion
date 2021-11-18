using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mira : MonoBehaviour
{
    private Camera cam;
    private Ray rayo;
    private GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        go = GameObject.FindGameObjectWithTag("Puntero");
    }

    // Update is called once per frame
    void Update()
    {
        rayo = cam.ScreenPointToRay(Input.mousePosition);
        transform.position = go.transform.position + (rayo.direction*15);
    }
    
}
