using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droparcarta : MonoBehaviour
{
    public static droparcarta d;
   
    public GameObject carta;

    public Transform cartapos;

    void Start()
    {
        d = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        Debug.Log("mousedown");
       

        cartasmanager.c.clickado = false;
        if (carta != null)
        {
            carta.transform.position = cartapos.position;
            carta.transform.localScale = new Vector3(0.79f, 0.79f, 0.79f);
            Debug.Log("not null");
        }
    }

}
