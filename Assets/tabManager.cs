using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabManager : MonoBehaviour
{
    public static tabManager tm;
    public GameObject[] faces;
    private int randomfogo;
    public bool pegandofogo;
    private GameObject pai1, pai2;
    private bool once, once2, once3, once4, once5, once6,once7,once8;

    void Start()
    {
        pegandofogo = false;
        tm = this;
        once2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch (turnos.t.turno)
        {
            case 0:

                if (gameObject.name == "meio_casa" && once == false)
                {

                    fogoInicial();
                    fogoInicial();
                    once = true;

                    //Debug.Log(pai1);
                    //Debug.Log(pai2);
                }
                break;
            case 1:

                if (once2 == false)
                {


                    if (pai1 != null)
                    {

                        if (pai1.GetComponent<tabManager>().pegandofogo)
                        {
                            umfogoSeguinte(pai1,1);

                        }


                    }


                    if (pai2 != null)
                    {

                        if (pai2.GetComponent<tabManager>().pegandofogo)
                        {
                            umfogoSeguinte(pai2,2);
                        }


                    }

                    once2 = true;
                    
                }
                break;

            case 2:
                if (!once3)
                {
                    if (pai1 != null)
                    {

                        if (pai1.GetComponent<tabManager>().pegandofogo)
                        {
                            umfogoSeguinte(pai1,1);

                        }


                    }


                    if (pai2 != null)
                    {

                        if (pai2.GetComponent<tabManager>().pegandofogo)
                        {
                            umfogoSeguinte(pai2,2);
                        }


                    }

                    once3 = true;
                }
                break;

            case 3:
                if (!once4)
                {
                    if (pai1 != null)
                    {

                        if (pai1.GetComponent<tabManager>().pegandofogo)
                        {
                            umfogoSeguinte(pai1,1);

                        }


                    }

                    if (pai2 != null)
                    {

                        if (pai2.GetComponent<tabManager>().pegandofogo)
                        {
                            umfogoSeguinte(pai2,2);
                        }


                    }
                    once4 = true;
                }
                break;
            case 4:
                if (!once5)
                {
                    if (pai1 != null)
                    {

                        if (pai1.GetComponent<tabManager>().pegandofogo)
                        {
                            umfogoSeguinte(pai1,1);

                        }


                    }


                    if (pai2 != null)
                    {

                        if (pai2.GetComponent<tabManager>().pegandofogo)
                        {
                            umfogoSeguinte(pai2,2);
                        }


                    }
                    once5 = true;
                }
                break;
            case 5:
                if (!once6)
                {
                    if (pai1 != null)
                    {

                        if (pai1.GetComponent<tabManager>().pegandofogo)
                        {
                            umfogoSeguinte(pai1,1);

                        }


                    }


                    if (pai2 != null)
                    {

                        if (pai2.GetComponent<tabManager>().pegandofogo)
                        {
                            umfogoSeguinte(pai2,2);
                        }


                    }
                    once6 = true;
                }
                break;

            case 6:
                if (!once7)
                {
                    if (pai1 != null)
                    {

                        if (pai1.GetComponent<tabManager>().pegandofogo)
                        {
                            umfogoSeguinte(pai1,1);

                        }


                    }


                    if (pai2 != null)
                    {

                        if (pai2.GetComponent<tabManager>().pegandofogo)
                        {
                            umfogoSeguinte(pai2,2);
                        }


                    }
                    once7 = true;
                }
                break;

            case 7:
                if (!once8)
                {
                    if (pai1 != null)
                    {

                        if (pai1.GetComponent<tabManager>().pegandofogo)
                        {
                            umfogoSeguinte(pai1,1);

                        }


                    }


                    if (pai2 != null)
                    {

                        if (pai2.GetComponent<tabManager>().pegandofogo)
                        {
                            umfogoSeguinte(pai2,2);
                        }


                    }
                    once8 = true;
                }
                break;

        }
    }
    #region INICIAL
    public void fogoInicial()
    {
        randomfogo = Random.Range(0, 6);
       
        if(faces[randomfogo].GetComponent<tabManager>().pegandofogo == false)
        {
            GameObject pai1 = faces[randomfogo];
            
            Transform child = pai1.transform.Find("fogo_2_floresta");
           
            child.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
            pai1.GetComponent<tabManager>().pegandofogo = true;
            if(this.pai1 == null)
            {
                this.pai1 = pai1;
                
            }
            else
            {
                this.pai2 = pai1;
                this.pai2.GetComponent<tabManager>().pegandofogo = true;
                
            }
            
           
        }
    }
    #endregion

    public void umfogoSeguinte(GameObject pai,int umdois)
    {
        // CONSTRUTOR COM UM INTEIRO : 1 e 2 
        randomfogo = Random.Range(0, 6);
        Debug.Log(pai.name +" " +randomfogo);
        if (pai.GetComponent<tabManager>().faces[randomfogo] != null && pai.GetComponent<tabManager>().faces[randomfogo].name != "meio_casa" && pai.GetComponent<tabManager>().faces[randomfogo].GetComponent<tabManager>().pegandofogo == false)
        {
            
            GameObject paigo = pai.GetComponent<tabManager>().faces[randomfogo];
            if(umdois == 1)
            {
                pai1 = paigo;
            }
            else
            {
                pai2 = paigo;
            }            
            Transform childdachild = paigo.transform.Find("fogo_2_floresta");            
            paigo.GetComponent<tabManager>().pegandofogo = true;
            childdachild.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
        }
        else
        {
            Debug.Log("Fim de jogo ou meio casa ou pegando fogo"); 
        }
       
    }


    //public void doisfogoSeguinte(GameObject pai1, GameObject pai2)
    //{
    //    randomfogo1 = Random.Range(0, 6);
    //    randomfogo2 = Random.Range(0, 6);
    //    if (randomfogo1 == randomfogo2)
    //    {

    //    }
    //    if (faces[randomfogo1].name != "meio_casa")
    //    {
    //        GameObject papai = pai1.GetComponent<tabManager>().faces[randomfogo1];
    //        Transform childdachild1 = pai1.GetComponent<tabManager>().faces[randomfogo1].transform.Find("fogo_2_floresta");
    //        childdachild1.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);

    //        GameObject papai2 = pai2.GetComponent<tabManager>().faces[randomfogo2];
    //        Transform childdachild2 = pai2.GetComponent<tabManager>().faces[randomfogo2].transform.Find("fogo_2_floresta");
    //        childdachild2.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);


    //    }
    //}



}







