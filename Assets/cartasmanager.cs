using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartasmanager : MonoBehaviour
{
    private bool clickado;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cursosPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
  
       if(clickado)
       {
            gameObject.transform.position = cursosPos;
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
       }
    }

    private void OnMouseDown()
    {
        clickado = true;
        Debug.Log("clickado");
    }





   
}
