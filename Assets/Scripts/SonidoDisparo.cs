using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoDisparo : MonoBehaviour
{
    private SonidoDisparo sd;

    private void Awake()
    {

    }

    void Start()
    {

    }

    void Update()
    {

    }

    private void InstanciaControlador()
    {
        if (sd == null)
        {
            sd = this;
            DontDestroyOnLoad(this);
        }
        else if (this != sd)
        {
            Destroy(this.gameObject);
        }
    }
}
