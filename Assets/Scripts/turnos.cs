using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class turnos : MonoBehaviour
{
    public static turnos t;
    public int turno;
    void Start()
    {
        t = this;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            turno++;
            Debug.Log(turno);
            
        }


    }


}
