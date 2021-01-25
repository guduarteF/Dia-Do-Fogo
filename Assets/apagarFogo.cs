using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apagarFogo : MonoBehaviour
{
    public static apagarFogo a;
    public GameObject floresta;
    public int fogo_qtd;
    private GameObject carta1, carta2, carta3, carta4, carta5;
    
    void Start()
    {
        a = this;

    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.name == "fogo_1_floresta")
        {
            fogo_qtd = 1;
        }
        else if (gameObject.name == "fogo_2_floresta")
        {
            fogo_qtd = 2;
        }
        else if (gameObject.name == "fogo_3_floresta")
        {
            fogo_qtd = 3;
        }
    }

    private void OnMouseDown()
    {
        GameObject papai = gameObject.transform.parent.gameObject;

        if (paicartas.p.cancela_row1 == true && paicartas.p.go_1 != null)
        {
           

            if (papai.GetComponent<tabManager>().pegandofogo)
            {
                if (paicartas.p.go_1.GetComponent<cartasmanager>().poder_de_agua >= fogo_qtd)
                {
                    floresta.SetActive(true);
                    
                    paicartas.p.ativa_row1 = true;
                    gameObject.SetActive(false);
                    
                }
                else
                {
                    // DESTRUIR CARTAS INFERIORES
                }
            }
            else
            {
                Debug.Log("nao esta pegaando fogo");
            }
           
            
            
        }
        else if(paicartas.p.cancela_row2 == true && paicartas.p.go_2 != null)
        {
            if (papai.GetComponent<tabManager>().pegandofogo)
            {

                if (paicartas.p.go_2.GetComponent<cartasmanager>().poder_de_agua >= fogo_qtd)
                {
                    floresta.SetActive(true);
                    
                    paicartas.p.ativa_row2 = true;
                    gameObject.SetActive(false);
                   
                }
            }
            
            
        }
        else if(paicartas.p.cancela_row3 == true && paicartas.p.go_3 != null)
        {
            if (papai.GetComponent<tabManager>().pegandofogo)
            {
                if (paicartas.p.go_3.GetComponent<cartasmanager>().poder_de_agua >= fogo_qtd)
                {
                    floresta.SetActive(true);
                    
                    paicartas.p.ativa_row3 = true;
                    gameObject.SetActive(false);
                    

                }
            }

        }
        else if(paicartas.p.cancela_row4 == true && paicartas.p.go_4 != null)
        {
            if (papai.GetComponent<tabManager>().pegandofogo)
            {

                if (paicartas.p.go_4.GetComponent<cartasmanager>().poder_de_agua >= fogo_qtd)
                {
                    floresta.SetActive(true);
                    
                    paicartas.p.ativa_row4 = true;
                    gameObject.SetActive(false);
                    
                }
            }
            
        }
        else if(paicartas.p.cancela_row5 == true && paicartas.p.go_5 != null)
        {
            if (papai.GetComponent<tabManager>().pegandofogo)
            {
                if (paicartas.p.go_5.GetComponent<cartasmanager>().poder_de_agua >= fogo_qtd)
                {
                    floresta.SetActive(true);
                   
                    paicartas.p.ativa_row5 = true;
                    gameObject.SetActive(false);
                    
                }
            }
        }
    }

    public void verificarNivel(GameObject carta , int row)
    {
        switch (row)
        {
            case 1: carta1 = carta;
                break;
            case 2:
                carta2 = carta;
                break;
            case 3:
                carta3 = carta;
                break;
            case 4:
                carta4 = carta;
                break;
            case 5:
                carta5 = carta;
                break;
        }
    }

   
}
