using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paicartas : MonoBehaviour
{
    public static paicartas p;
    public Text gota_txt, carta_txt;
    private int gota_qtd, carta_qtd;
    public string row;
    public GameObject go_1, go_2, go_3, go_4, go_5;
    private GameObject[] gota_row1;
    private GameObject[] gota_row2;
    private GameObject[] gota_row3;
    private GameObject[] gota_row4;
    private GameObject[] gota_row5;
    private int gota_storage, carta_power;
   public int gotas_soma1, gotas_soma2, gotas_soma3, gotas_soma4,gotas_soma5;
    public bool cancela_row1, cancela_row2,cancela_row3, cancela_row4, cancela_row5;
    public bool ativa_row1, ativa_row2, ativa_row3, ativa_row4, ativa_row5;
    private int count1,count2,count3,count4,count5;


    void Start()
    {
        p = this;
        gota_row1 = new GameObject[4];
        gota_row2 = new GameObject[4];
        gota_row3 = new GameObject[4];
        gota_row4 = new GameObject[4];
        gota_row5 = new GameObject[4];
        count1 = 0;
        count2 = 0;
        count3 = 0;
        count4 = 0;
        count5 = 0;



    }

    // Update is called once per frame
    void Update()
    {       
        cancelar_row();
        apagar_Fogo();  
    }


    public void setar_carta_row(GameObject carta,int num)
    {

        switch (num)
        {
            case 1:
                go_1 = carta;
               // apagarFogo.a.verificarNivel(go_1, 1);
                
                break;
            case 2:
                go_2 = carta;
               // apagarFogo.a.verificarNivel(go_2, 2);
                break;
            case 3:
                go_3 = carta;
              //  apagarFogo.a.verificarNivel(go_3, 3);
                break;
            case 4:
                go_4 = carta;
               // apagarFogo.a.verificarNivel(go_4, 4);
                break;
            case 5:
                go_5 = carta;
               // apagarFogo.a.verificarNivel(go_5, 5);
                break;
        }
    }

    #region setar_gota_row
    public void setar_gota_row(GameObject gota, int num)
    {
       
        switch (num)
        {
            case 1:

                if (gota_row1[0] == null)
                {
                    gota_row1[0] = gota;

                }
                else if (gota_row1[1] == null)
                {
                    gota_row1[1] = gota;
                }
                else if (gota_row1[2] == null)
                {
                    gota_row1[2] = gota;
                }
                else if (gota_row1[3] == null)
                {
                    gota_row1[3] = gota;
                }
                else if (gota_row1[4] == null)
                {
                    gota_row1[4] = gota;
                }
                break;

            case 2:
                if (gota_row2[0] == null)
                {
                    gota_row2[0] = gota;

                }
                else if (gota_row2[1] == null)
                {
                    gota_row2[1] = gota;
                }
                else if (gota_row2[2] == null)
                {
                    gota_row2[2] = gota;
                }
                else if (gota_row2[3] == null)
                {
                    gota_row2[3] = gota;
                }
                else if (gota_row2[4] == null)
                {
                    gota_row2[4] = gota;
                }
                break;
            case 3:
                if (gota_row3[0] == null)
                {
                    gota_row3[0] = gota;
                }
                else if (gota_row3[1] == null)
                {
                    gota_row3[1] = gota;
                }
                else if (gota_row3[2] == null)
                {
                    gota_row3[2] = gota;
                }
                else if (gota_row3[3] == null)
                {
                    gota_row3[3] = gota;
                }
                else if(gota_row3[4] == null)
                {
                    gota_row3[4] = gota;
                }
                break;
            case 4:
                if (gota_row4[0] == null)
                {
                    gota_row4[0] = gota;
                }
                else if (gota_row4[1] == null)
                {
                    gota_row4[1] = gota;
                }
                else if (gota_row4[2] == null)
                {
                    gota_row4[2] = gota;
                }
                else if (gota_row4[3] == null)
                {
                    gota_row4[3] = gota;
                }
                else if (gota_row4[4] == null)
                {
                    gota_row4[4] = gota;
                }
                break;
            case 5:
                 if (gota_row5[0] == null)
                {
                    gota_row5[0] = gota;
                }
                else if (gota_row5[1] == null)
                {
                    gota_row5[1] = gota;
                }
                else if (gota_row5[2] == null)
                {
                    gota_row5[2] = gota;
                }
                else if (gota_row5[3] == null)
                {
                    gota_row5[3] = gota;
                }
                else if (gota_row5[4] == null)
                {
                    gota_row5[4] = gota;
                }
                break;
        }

       


    }
    #endregion

    public void somar_gota()
    {
        
        for (int i = 0; i < 4; i++)
        {
            if(gota_row1[i] != null && count1== i)
            {
               
                gotas_soma1 = gotas_soma1 + gota_row1[i].GetComponent<cartasmanager>().poder_de_agua;                                           
                count1++;

            }

            if (gota_row2[i] != null && count2 == i)
            {
                
                gotas_soma2 = gotas_soma2 + gota_row2[i].GetComponent<cartasmanager>().poder_de_agua;
                count2++;
            }

            if (gota_row3[i] != null && count3 == i)
            {
                gotas_soma3 = gotas_soma3 + gota_row3[i].GetComponent<cartasmanager>().poder_de_agua;

                count3++;
                
            }

            if (gota_row4[i] != null && count4 == i)
            {
                gotas_soma4 = gotas_soma4 + gota_row4[i].GetComponent<cartasmanager>().poder_de_agua;

                count4++;
            }

            if (gota_row5[i] != null && count5 == i)
            {
                gotas_soma5 = gotas_soma5 + gota_row5[i].GetComponent<cartasmanager>().poder_de_agua;

                count5++;
                
            }
            
        }


    }

    public void apagar_Fogo()
    {
        if(cancela_row1)
        {            
            if (ativa_row1)
            {               
                for (int i = 0; i < gota_row1.Length; i++)
                {
                   
                    Destroy(go_1);
                    Destroy(gota_row1[i]);
                    cancela_row1 = false;

                }
                
            }
        }
        else if(cancela_row2)
        {
            if (ativa_row2)
            {
                for (int i = 0; i < gota_row2.Length; i++)
                {

                    Destroy(go_2);
                    Destroy(gota_row2[i]);
                    cancela_row2 = false;

                }
            }
        }
        else if(cancela_row3)
        {
            if (ativa_row3)
            {
                for (int i = 0; i < gota_row3.Length; i++)
                {

                    Destroy(go_3);
                    Destroy(gota_row3[i]);
                    cancela_row3 = false;

                }
               
            }
        }
        else if(cancela_row4)
        {
            if (ativa_row4)
            {
                for (int i = 0; i < gota_row4.Length; i++)
                {

                    Destroy(go_4);
                    Destroy(gota_row4[i]);
                    cancela_row4 = false;

                }
            }
        }
        else if(cancela_row5)
        {
            if (ativa_row5)
            {
                for (int i = 0; i < gota_row5.Length; i++)
                {

                    Destroy(go_5);
                    Destroy(gota_row5[i]);
                    cancela_row5 = false;

                }
            }
        }

    }

    public void cancelar_row()
    {
        if (go_1 != null)
        {
            if (go_1.GetComponent<cartasmanager>().poder_de_agua <= gotas_soma1)
            {
                Debug.Log(go_1.GetComponent<cartasmanager>().poder_de_agua);
                Debug.Log(gotas_soma1);
                cancela_row1 = true;
                
            }

        }
        else if (go_2 != null)
        {
            if (go_2.GetComponent<cartasmanager>().poder_de_agua <= gotas_soma2)
            {
                Debug.Log(go_2.GetComponent<cartasmanager>().poder_de_agua);
                Debug.Log(gotas_soma2);
                cancela_row2 = true;
                
            }
        }
        else if (go_3 != null)
        {
            if (go_3.GetComponent<cartasmanager>().poder_de_agua <= gotas_soma3)
            {
                Debug.Log(go_3.GetComponent<cartasmanager>().poder_de_agua);
                Debug.Log(gotas_soma3);
                cancela_row3 = true;
                
            }
        }
        else if (go_4 != null)
        {
            if (go_4.GetComponent<cartasmanager>().poder_de_agua <= gotas_soma4)
            {
                Debug.Log(go_4.GetComponent<cartasmanager>().poder_de_agua);
                Debug.Log(gotas_soma4);
                cancela_row4 = true;
            }
        }
        else if (go_5 != null)
        {
            if (go_5.GetComponent<cartasmanager>().poder_de_agua <= gotas_soma5)
            {
                Debug.Log(go_5.GetComponent<cartasmanager>().poder_de_agua);
                Debug.Log(gotas_soma5);
                cancela_row5 = true;
            }
        }
    }

   

}
