using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class turnos : MonoBehaviour
{
    public static turnos t;
    public int turno;
    public Text turnotxt;
    public string turnostrng;

    void Start()
    {
        t = this;
        turnotxt.text = "fogo";
        turno = 1;
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
