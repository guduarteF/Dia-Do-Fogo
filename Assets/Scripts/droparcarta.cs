using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droparcarta : MonoBehaviour
{
    public static droparcarta d;
    private GameObject r_carta; 
    public Transform cartapos;
    public Transform gotapos;
    public Transform gotapos2;
    public Transform gotapos3;
    public Transform gotapos4;
    private GameObject clicked;
    private bool temcarta;
    private int qtd_gota;
    public int pos_num;

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
        if (paicartas.p.cancela_row1 == false && paicartas.p.cancela_row2 == false && paicartas.p.cancela_row3== false && paicartas.p.cancela_row4 == false && paicartas.p.cancela_row5 == false)
        {
            GameObject[] carta = GameObject.FindGameObjectsWithTag("carta");
            GameObject[] gota = GameObject.FindGameObjectsWithTag("gota");

            for (int i = 0; i < gota.Length; i++)
            {
                if (gota[i].GetComponent<cartasmanager>().clickado_gota == true)
                {
                    r_carta = gota[i].gameObject;
                }
            }

            for (int i = 0; i < carta.Length; i++)
            {
                if (carta[i].GetComponent<cartasmanager>().clickado_carta == true)
                {
                    r_carta = carta[i].gameObject;
                }
            }

            if (r_carta != null && temcarta == false && r_carta.tag == "carta")
            {
                r_carta.GetComponent<cartasmanager>().clickado_carta = false;
                r_carta.GetComponent<SpriteRenderer>().sortingOrder = 4;
                r_carta.transform.position = cartapos.position;
                r_carta.transform.localScale = new Vector3(1.03f, 1.03f, 1.03f);
                temcarta = true;
                passar_ref_carta(r_carta);

            }

            if (r_carta != null && r_carta.tag == "gota")
            {
                r_carta.GetComponent<cartasmanager>().clickado_gota = false;

                r_carta.transform.localScale = new Vector3(1.03f, 1.03f, 1.03f);
                passar_ref_gota(r_carta);
                paicartas.p.somar_gota();

                switch (qtd_gota)
                {
                    case 0:
                        r_carta.GetComponent<SpriteRenderer>().sortingOrder = 3;
                        r_carta.transform.position = gotapos.position;
                        qtd_gota++;
                        break;

                    case 1:
                        r_carta.GetComponent<SpriteRenderer>().sortingOrder = 2;
                        r_carta.transform.position = gotapos2.position;
                        qtd_gota++;
                        break;

                    case 2:
                        r_carta.GetComponent<SpriteRenderer>().sortingOrder = 1;
                        r_carta.transform.position = gotapos3.position;
                        qtd_gota++;
                        break;

                    case 3:
                        r_carta.GetComponent<SpriteRenderer>().sortingOrder = 0;
                        r_carta.transform.position = gotapos4.position;
                        break;

                }
            }
        }
       
    }

    public void passar_ref_carta(GameObject carta)
    {
        if (pos_num == 1)
        {
            paicartas.p.setar_carta_row(carta,1);
            apagarFogo.a.verificarNivel(carta, 1);
        }
        else if (pos_num == 2)
        {
            paicartas.p.setar_carta_row(carta, 2);
            apagarFogo.a.verificarNivel(carta, 2);
        }
        else if (pos_num == 3)
        {
            paicartas.p.setar_carta_row(carta, 2);
            apagarFogo.a.verificarNivel(carta, 2);
        }
        else if (pos_num == 4)
        {
            paicartas.p.setar_carta_row(carta, 3);
            apagarFogo.a.verificarNivel(carta, 3);
        }
        else
        {
            paicartas.p.setar_carta_row(carta, 4);
            apagarFogo.a.verificarNivel(carta, 4);
        }
    }

    public void passar_ref_gota(GameObject gota)
    {
        if (pos_num == 1)
        {
            paicartas.p.setar_gota_row(gota, 1);
        }
        else if (pos_num == 2)
        {
            paicartas.p.setar_gota_row(gota, 2);
        }
        else if (pos_num == 3)
        {
            paicartas.p.setar_gota_row(gota, 2);
        }
        else if (pos_num == 4)
        {
            paicartas.p.setar_gota_row(gota, 3);
        }
        else
        {
            paicartas.p.setar_gota_row(gota, 4);
        }
    }

}
