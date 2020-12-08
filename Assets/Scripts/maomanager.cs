using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maomanager : MonoBehaviour
{
    public GameObject[] todascartas;
    public Transform[] cartas_pos;
    private int[] c_num;
    


    void Start()
    {
        
        montarMao();
        
        
       
    }

    
    void Update()
    {
        
    }


    public void comprarCarta()
    {

    }

    public void montarMao()
    {
        int[] c_num = new int[5];
        for(int i=0; i<5; i++)
        {
           c_num[i] = Random.Range(0, 8);
            Instantiate(todascartas[c_num[i]],cartas_pos[i].position,cartas_pos[i].rotation);
            //todascartas[c_num[i]].transform.position = cartas_pos[i].position;
            //todascartas[c_num[i]].transform.rotation = cartas_pos[i].rotation;

        }

        
         
        
    }


}
