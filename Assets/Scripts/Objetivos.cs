using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivos : MonoBehaviour
{
    private int objetivosRestantes;
    GameObject go1;
    GameObject go2;
    GameObject go3;
    GameObject go4;
    GameObject go5;
    GameObject go6;
    GameObject go7;
    GameObject go8;
    GameObject go9;
    GameObject go10;
    public int nivel;
    TextMesh tm;
    void Start()
    {
        tm = gameObject.GetComponent<TextMesh>();
        go1 = GameObject.FindGameObjectWithTag("Blanco_1");
        go2 = GameObject.FindGameObjectWithTag("Blanco_2");
        go3 = GameObject.FindGameObjectWithTag("Blanco_3");
        go4 = GameObject.FindGameObjectWithTag("Blanco_4");
        go5 = GameObject.FindGameObjectWithTag("Blanco_5");
        go6 = GameObject.FindGameObjectWithTag("Blanco_6");
        go7 = GameObject.FindGameObjectWithTag("Blanco_7");
        go8 = GameObject.FindGameObjectWithTag("Blanco_8");
        go9 = GameObject.FindGameObjectWithTag("Blanco_9");
        go10 = GameObject.FindGameObjectWithTag("Blanco_10");
    }


    void Update()
    {
        ObjRest();
        tm.text = ("OBJETIVOS: "+ objetivosRestantes);

    }

    private void ObjRest()
    {
        if (nivel == 1)
        {
            if ((go1 == false) && (go2 == false) && (go3 == false) && (go4 == false) && (go5 == false))
            {
                objetivosRestantes = 0;
            }
            else if ((go1 == false) && (go2 == false) && (go3 == false) && (go4 == false))
            {
                objetivosRestantes = 1;
            }
            else if ((go1 == false) && (go2 == false) && (go3 == false))
            {
                objetivosRestantes = 2;
            }
            else if ((go1 == false) && (go2 == false))
            {
                objetivosRestantes = 3;
            }
            else if (go1 == false)
            {
                objetivosRestantes = 4;
            }
            else
            {
                objetivosRestantes = 5;
            }
        }
        else if (nivel == 2)
        {
            if ((go1 == false) && (go2 == false) && (go3 == false) && (go4 == false) && (go5 == false) && (go6 == false) && (go7 == false))
            {
                objetivosRestantes = 0;
            }
            else if ((go1 == false) && (go2 == false) && (go3 == false) && (go4 == false) && (go5 == false) && (go6 == false))
            {
                objetivosRestantes = 1;
            }
            else if ((go1 == false) && (go2 == false) && (go3 == false) && (go4 == false) && (go5 == false))
            {
                objetivosRestantes = 2;
            }
            else if ((go1 == false) && (go2 == false) && (go3 == false) && (go4 == false))
            {
                objetivosRestantes = 3;
            }
            else if ((go1 == false) && (go2 == false) && (go3 == false))
            {
                objetivosRestantes = 4;
            }
            else if ((go1 == false) && (go2 == false))
            {
                objetivosRestantes = 5;
            }
            else if (go1 == false)
            {
                objetivosRestantes = 6;
            }
            else
            {
                objetivosRestantes = 7;
            }
        }
        else if (nivel == 3)
        {
            if ((go1 == false) && (go2 == false) && (go3 == false) && (go4 == false) && (go5 == false) && (go6 == false) && (go7 == false) && (go8 == false) && (go9 == false) && (go10 == false))
            {
                objetivosRestantes = 0;
            }
            else if ((go1 == false) && (go2 == false) && (go3 == false) && (go4 == false) && (go5 == false) && (go6 == false) && (go7 == false) && (go8 == false) && (go9 == false))
            {
                objetivosRestantes = 1;
            }
            else if ((go1 == false) && (go2 == false) && (go3 == false) && (go4 == false) && (go5 == false) && (go6 == false) && (go7 == false) && (go8 == false))
            {
                objetivosRestantes = 2;
            }
            else if ((go1 == false) && (go2 == false) && (go3 == false) && (go4 == false) && (go5 == false) && (go6 == false) && (go7 == false))
            {
                objetivosRestantes = 3;
            }
            else if ((go1 == false) && (go2 == false) && (go3 == false) && (go4 == false) && (go5 == false) && (go6 == false))
            {
                objetivosRestantes = 4;
            }
            else if ((go1 == false) && (go2 == false) && (go3 == false) && (go4 == false) && (go5 == false))
            {
                objetivosRestantes = 5;
            }
            else if ((go1 == false) && (go2 == false) && (go3 == false) && (go4 == false))
            {
                objetivosRestantes = 6;
            }
            else if ((go1 == false) && (go2 == false) && (go3 == false))
            {
                objetivosRestantes = 7;
            }
            else if ((go1 == false) && (go2 == false))
            {
                objetivosRestantes = 8;
            }
            else if (go1 == false)
            {
                objetivosRestantes = 9;
            }
            else
            {
                objetivosRestantes = 10;
            }
        }


        
    }
}
