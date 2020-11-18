using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartasmanager : MonoBehaviour
{
    public bool clickado;
    public static cartasmanager c;
    void Start()
    {
        c = this;
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
        
        if(clickado)
        {
            GetComponent<BoxCollider>().enabled = false;
        }
      
    }





   
}
