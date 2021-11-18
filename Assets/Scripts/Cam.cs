using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private GameObject go;

    void Start()
    {
        go = GameObject.FindGameObjectWithTag("Jugador");
    }

    void Update()
    {
        transform.position = go.transform.position;
        transform.rotation = go.transform.rotation;
    }
}
