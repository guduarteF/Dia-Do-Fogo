using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class dados : MonoBehaviour
{
    public static dados d;
    public Text turno;
    public Text dado1_txt,dado2_txt;
    public int dado_turno;
    private int dado_random, dado_random2;
    public GameObject[] dado01;
    public GameObject[] dado02;
    
    void Start()
    {
        d = this;
        dado_turno = 0;
     
    }

    // Update is called once per frame
    void Update()
    {
        turno.text = "Turno : " + dado_turno.ToString();
        dado1_txt.text = dado_random.ToString();
        dado2_txt.text = dado_random2.ToString();
    }



    public void jogarDados(int dado_random_ref, int num)
    {
        if(num == 1)
        {
            switch (dado_random_ref)
            {
                case 0: dado01[0].SetActive(true);
                    dado01[1].SetActive(false);
                    dado01[2].SetActive(false);
                    dado01[3].SetActive(false);
                    dado01[4].SetActive(false);
                    dado01[5].SetActive(false);

                    break;
                case 1:
                    dado01[0].SetActive(false);
                    dado01[1].SetActive(true);
                    dado01[2].SetActive(false);
                    dado01[3].SetActive(false);
                    dado01[4].SetActive(false);
                    dado01[5].SetActive(false);
                    break;
                case 2:
                    dado01[0].SetActive(false);
                    dado01[1].SetActive(false);
                    dado01[2].SetActive(true);
                    dado01[3].SetActive(false);
                    dado01[4].SetActive(false);
                    dado01[5].SetActive(false);
                    break;
                case 3:
                    dado01[0].SetActive(false);
                    dado01[1].SetActive(false);
                    dado01[2].SetActive(false);
                    dado01[3].SetActive(true);
                    dado01[4].SetActive(false);
                    dado01[5].SetActive(false);
                    break;
                case 4:
                    dado01[0].SetActive(false);
                    dado01[1].SetActive(false);
                    dado01[2].SetActive(false);
                    dado01[3].SetActive(false);
                    dado01[4].SetActive(true);
                    dado01[5].SetActive(false);
                    break;
                case 5:
                    dado01[0].SetActive(false);
                    dado01[1].SetActive(false);
                    dado01[2].SetActive(false);
                    dado01[3].SetActive(false);
                    dado01[4].SetActive(false);
                    dado01[5].SetActive(true);
                    break;

              
            }
            dado_random = dado_random_ref + 1;
        }
        else
        {
            switch (dado_random_ref)
            {
                case 0:
                    dado02[0].SetActive(true);
                    dado02[1].SetActive(false);
                    dado02[2].SetActive(false);
                    dado02[3].SetActive(false);
                    dado02[4].SetActive(false);
                    dado02[5].SetActive(false);

                    break;
                case 1:
                    dado02[0].SetActive(false);
                    dado02[1].SetActive(true);
                    dado02[2].SetActive(false);
                    dado02[3].SetActive(false);
                    dado02[4].SetActive(false);
                    dado02[5].SetActive(false);
                    break;
                case 2:
                    dado02[0].SetActive(false);
                    dado02[1].SetActive(false);
                    dado02[2].SetActive(true);
                    dado02[3].SetActive(false);
                    dado02[4].SetActive(false);
                    dado02[5].SetActive(false);
                    break;
                case 3:
                    dado02[0].SetActive(false);
                    dado02[1].SetActive(false);
                    dado02[2].SetActive(false);
                    dado02[3].SetActive(true);
                    dado02[4].SetActive(false);
                    dado02[5].SetActive(false);
                    break;
                case 4:
                    dado02[0].SetActive(false);
                    dado02[1].SetActive(false);
                    dado02[2].SetActive(false);
                    dado02[3].SetActive(false);
                    dado02[4].SetActive(true);
                    dado02[5].SetActive(false);
                    break;
                case 5:
                    dado02[0].SetActive(false);
                    dado02[1].SetActive(false);
                    dado02[2].SetActive(false);
                    dado02[3].SetActive(false);
                    dado02[4].SetActive(false);
                    dado02[5].SetActive(true);
                    break;


            }
            dado_random2 = dado_random_ref + 1;
        }
        


    }

    public void passarTurno()
    {
        dado_turno++;
    }
}
