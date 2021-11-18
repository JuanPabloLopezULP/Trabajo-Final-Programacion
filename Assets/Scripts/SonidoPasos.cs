using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoPasos : MonoBehaviour
{
    private SonidoPasos sp;

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
        if (sp == null)
        {
            sp = this;
            DontDestroyOnLoad(this);
        }
        else if (this != sp)
        {
            Destroy(this.gameObject);
        }
    }
}
