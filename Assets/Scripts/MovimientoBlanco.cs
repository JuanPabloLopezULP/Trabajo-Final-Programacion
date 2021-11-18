using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBlanco : MonoBehaviour
{
    private GameObject go1;
    private GameObject go2;
    private GameObject go3;
    private GameObject go4;
    private GameObject go5;
    private GameObject go6;
    private GameObject go7;
    private GameObject go8;
    private GameObject go9;
    private GameObject go10;
    public int var;
    public int nivel;
    private Vector3 avance1;
    private Vector3 avance2;

    void Start()
    {
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

        avance1 = (Vector3.right) * 8;
        avance2 = (Vector3.forward) * 8;
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (nivel == 1)
        {
            if (var == 1)
            {
                if (other.gameObject.name == "Jugador")
                {
                    go1.transform.position = go1.transform.position - avance1;
                    Destroy(this.gameObject);
                }
            }
            if (var == 2)
            {
                if (other.gameObject.name == "Jugador")
                {
                    go2.transform.position = go2.transform.position + avance1;
                    go3.transform.position = go3.transform.position - avance2;
                    Destroy(this.gameObject);
                }
            }
            if (var == 3)
            {
                if (other.gameObject.name == "Jugador")
                {
                    go4.transform.position = go4.transform.position - avance2;
                    go5.transform.position = go5.transform.position - avance2;
                    Destroy(this.gameObject);
                }
            }
            
        }
        else if (nivel == 2)
        {
            if (var == 1)
            {
                if (other.gameObject.name == "Jugador")
                {
                    go1.transform.position = go1.transform.position + avance2;
                    Destroy(this.gameObject);
                }
            }
            if (var == 2)
            {
                if (other.gameObject.name == "Jugador")
                {
                    go2.transform.position = go2.transform.position - avance2;
                    go3.transform.position = go3.transform.position - avance1;
                    Destroy(this.gameObject);
                }
            }
            if (var == 3)
            {
                if (other.gameObject.name == "Jugador")
                {
                    go4.transform.position = go4.transform.position - avance2;
                    go5.transform.position = go5.transform.position - avance1;
                    Destroy(this.gameObject);
                }
            }
            if (var == 4)
            {
                if (other.gameObject.name == "Jugador")
                {
                    go6.transform.position = go6.transform.position + avance2;
                    go7.transform.position = go7.transform.position - avance2;
                    Destroy(this.gameObject);
                }
            }
          
        }
        else if (nivel == 3)
        {
            if (var == 1)
            {
                if (other.gameObject.name == "Jugador")
                {
                    go1.transform.position = go1.transform.position + avance2;
                    Destroy(this.gameObject);
                }
            }
            if (var == 2)
            {
                if (other.gameObject.name == "Jugador")
                {
                    go2.transform.position = go2.transform.position - avance2;
                    go3.transform.position = go3.transform.position - avance2;
                    Destroy(this.gameObject);
                }
            }
            if (var == 3)
            {
                if (other.gameObject.name == "Jugador")
                {
                    go4.transform.position = go4.transform.position - avance2;
                    go5.transform.position = go5.transform.position - avance1;
                    Destroy(this.gameObject);
                }
            }
            if (var == 4)
            {
                if (other.gameObject.name == "Jugador")
                {
                    go6.transform.position = go6.transform.position + avance2;
                    go7.transform.position = go7.transform.position - avance2;
                    Destroy(this.gameObject);
                }
            }
            if (var == 5)
            {
                if (other.gameObject.name == "Jugador")
                {
                    go8.transform.position = go8.transform.position + avance2;
                    go9.transform.position = go9.transform.position - avance2;
                    go10.transform.position = go10.transform.position + avance1;
                    Destroy(this.gameObject);
                }
            }
        }
        
        
        if (var==1)
        {
            if (other.gameObject.name == "Jugador")
            {
                go1.transform.position = go1.transform.position + avance2;
                Destroy(this.gameObject);
            }
        }
        if (var==2)
        {
            if (other.gameObject.name == "Jugador")
            {
                go2.transform.position = go2.transform.position - avance2;
                go3.transform.position = go3.transform.position - avance2;
                Destroy(this.gameObject);
            }
        }        
        if (var==3)
        {
            if (other.gameObject.name == "Jugador")
            {
                go4.transform.position = go4.transform.position - avance2;
                go5.transform.position = go5.transform.position - avance1;
                Destroy(this.gameObject);
            }
        }
        if (var == 4)
        {
            if (other.gameObject.name == "Jugador")
            {
                go6.transform.position = go6.transform.position + avance2;
                go7.transform.position = go7.transform.position - avance2;
                Destroy(this.gameObject);
            }
        }
        if (var == 5)
        {
            if (other.gameObject.name == "Jugador")
            {
                go8.transform.position = go8.transform.position + avance2;
                go9.transform.position = go9.transform.position - avance2;
                go10.transform.position = go10.transform.position + avance1;
                Destroy(this.gameObject);
            }
        }
    }
}
