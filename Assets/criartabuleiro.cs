using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criartabuleiro : MonoBehaviour
{
    private int numfogo;
    public GameObject[] todos;
    void Start()
    {
        gerarfogoHex();
    }


    public void gerarfogoHex()
    {
        for (int i = 0; i < todos.Length; i++)
        {
            numfogo = Random.Range(1, 4);

            if (numfogo == 1)
            {
                todos[i].transform.Find("fogo_1_floresta").gameObject.SetActive(true);
                todos[i].transform.Find("fogo_2_floresta").gameObject.SetActive(false);
                todos[i].transform.Find("fogo_3_floresta").gameObject.SetActive(false);

            }
            else if (numfogo == 2)
            {
                todos[i].transform.Find("fogo_1_floresta").gameObject.SetActive(false);
                todos[i].transform.Find("fogo_2_floresta").gameObject.SetActive(true);
                todos[i].transform.Find("fogo_3_floresta").gameObject.SetActive(false);
            }
            else
            {
                todos[i].transform.Find("fogo_1_floresta").gameObject.SetActive(false);
                todos[i].transform.Find("fogo_2_floresta").gameObject.SetActive(false);
                todos[i].transform.Find("fogo_3_floresta").gameObject.SetActive(true);
            }

            
        }
    }

   

}