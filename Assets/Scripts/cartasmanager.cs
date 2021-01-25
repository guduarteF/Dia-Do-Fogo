using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartasmanager : MonoBehaviour
{
    public bool clickado_carta,clickado_gota;
    public static cartasmanager c;
    public GameObject thisobj;
    private int num;
    public int poder_de_agua;
    public bool esta_na_mao;
    public int pos_atual_mao;
    

    void Start()
    {
        c = this;
        //setarNum();
    }

    // Update is called once per frame
    void Update()
    {

        
        Vector2 cursosPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (clickado_carta || clickado_gota)
        {
            gameObject.transform.position = cursosPos;
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }

       
    }

    private void OnMouseDown()
    {
        if (paicartas.p.cancela_row1 == false && paicartas.p.cancela_row2 == false && paicartas.p.cancela_row3 == false && paicartas.p.cancela_row4 == false && paicartas.p.cancela_row5 == false)
        { 
            if (gameObject.CompareTag("gota"))
            {
                thisobj = gameObject;
                clickado_gota = true;
                GetComponent<BoxCollider2D>().enabled = false;
                esta_na_mao = false;
            }
            else
            {
                thisobj = gameObject;
                clickado_carta = true;
                GetComponent<BoxCollider2D>().enabled = false;
                esta_na_mao = false;
            }
        }
    }



    

}
