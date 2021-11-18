using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoJuego : MonoBehaviour
{
    private static SonidoJuego instancia;
    
    private void Awake()
    {
        this.InstanciarControlador();
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void InstanciarControlador()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(this);
        }
        else if (this!= instancia)
        {
            Destroy(this.gameObject);
        }
    }
}
