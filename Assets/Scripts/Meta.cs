using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    GameObject go1;
    GameObject go2;
    TextMesh tm1;
    TextMesh tm2;
    public int nivel;
    void Start()
    {
        go1 = GameObject.FindGameObjectWithTag("Objetivo");
        tm1 = go1.GetComponent<TextMesh>();
        go2 = GameObject.FindGameObjectWithTag("Timer");
        tm2 = go2.GetComponent<TextMesh>();
    }

  
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Jugador")
        {
            if (tm1.text == "OBJETIVOS: " + 0)
            {
                if (nivel == 1)
                {
                    SceneManager.LoadScene("Nivel2");
                }
                else if (nivel == 2)
                {
                    SceneManager.LoadScene("Nivel3");
                }
                else if (nivel == 3)
                {
                    SceneManager.LoadScene("PantallaGO");
                }
            }
        }
    }

}
