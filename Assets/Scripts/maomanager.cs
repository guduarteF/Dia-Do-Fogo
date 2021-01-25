using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maomanager : MonoBehaviour
{
    public static maomanager m;
    public GameObject[] todascartas;
    public Transform[] cartas_pos;
    private int[] c_num;
    private int[] ref_pos;
    private GameObject cartamao;
    GameObject[] array_cartaomao = new GameObject[5];
    private bool comprou;
    



    void Start()
    {
        m = this;   
        montarMao();
      
       


    }

    
    void Update()
    {
        
    }


    public void comprarCarta()
    {
        int[] c_num = new int[5];
      
        for (int i = 0; i < 5; i++)
        {
           if(array_cartaomao[i].GetComponent<cartasmanager>().esta_na_mao == false & comprou == false)
            {
                c_num[i] = Random.Range(0, 8);
                cartamao = Instantiate(todascartas[c_num[i]], cartas_pos[i].position, cartas_pos[i].rotation);
                cartamao.GetComponent<cartasmanager>().esta_na_mao = true;
                cartamao.GetComponent<cartasmanager>().pos_atual_mao = i;
                array_cartaomao[i] = cartamao;
                comprou = true;
                break;
            }
           else
            {
                Debug.Log("nao conseguiu comprar carta pois a posicao" + i + " ja esta ocupada com outra carta no momento");
                comprou = false;
            }
        }
    }

    public void montarMao()
    {
        int[] c_num = new int[5];
      
        
        for(int i=0; i<5; i++)
        {
           c_num[i] = Random.Range(0, 8);
            cartamao = Instantiate(todascartas[c_num[i]],cartas_pos[i].position,cartas_pos[i].rotation);
            cartamao.GetComponent<cartasmanager>().esta_na_mao = true;
            cartamao.GetComponent<cartasmanager>().pos_atual_mao = i;
            array_cartaomao[i] = cartamao;
            


            //todascartas[c_num[i]].transform.position = cartas_pos[i].position;
            //todascartas[c_num[i]].transform.rotation = cartas_pos[i].rotation;
        }

        
         
        
    }

    


}
