using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    TextMesh tm;
    public float time;
    public float currentTime;

    void Start()
    {
        currentTime = time;
        tm = gameObject.GetComponent<TextMesh>();
       
    }


    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            tm.text = ("TIEMPO: "+ (int)currentTime);
        }
        if (currentTime <= 0)
        {
            SceneManager.LoadScene("PantallaGO");
        }

    }

    
}
