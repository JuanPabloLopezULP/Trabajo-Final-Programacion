using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escopeta : MonoBehaviour
{
    private Camera cam;
    private GameObject go;
    private GameObject pos;
    private Transform ubicacionMira;

    // Start is called before the first frame update
    void Start()
    {
        pos = GameObject.FindGameObjectWithTag("Jugador");
        transform.position = pos.transform.position;
        go = GameObject.FindGameObjectWithTag("Mira");
        ubicacionMira = go.transform;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pos.transform.position;
        Vector3 posRelativa = ubicacionMira.position - transform.position;
        transform.rotation = Quaternion.LookRotation(posRelativa);
    }
}
