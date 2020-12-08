using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabManager : MonoBehaviour
{
    public static tabManager tm;
    public GameObject[] faces;
    public int randomfogo;
    public bool pegandofogo;
    private GameObject pai1, pai2;
    private bool once, once2, once3, once4, once5, once6,once7,once8;
    private Transform childdachild, child;
    public GameObject fogoanim;
    public GameObject[] todos;
    private int count;
    

    void Start()
    {
        for (int i = 0; i < todos.Length; i++)
        {
          //  Instantiate(fogoanim, todos[i].transform.position, fogoanim.transform.rotation);
        }
        pegandofogo = false;
        tm = this;
        once2 = false;

       
    }

    // Update is called once per frame
    void Update()
    {
        #region SWITCH

        switch (dados.d.dado_turno)
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
        #endregion

       
       
        

    }



    #region INICIAL
    public void fogoInicial()
    {
        randomfogo = Random.Range(0, 6);
       
        if(faces[randomfogo].GetComponent<tabManager>().pegandofogo == false)
        {
            GameObject pai1 = faces[randomfogo];

            if (pai1.transform.Find("fogo_1_floresta").gameObject.active == true)
            {
                child = pai1.transform.Find("fogo_1_floresta");
            }
            else if (pai1.transform.Find("fogo_2_floresta").gameObject.active == true)
            {
                child = pai1.transform.Find("fogo_2_floresta");
            }
            else
            {
                child = pai1.transform.Find("fogo_3_floresta");
            }

            child.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
            Instantiate(fogoanim, child.transform.position, fogoanim.transform.rotation);
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
        
        randomfogo = Random.Range(0, 6);
        count++;
        if (count / 2 == 0)
        {
            dados.d.jogarDados(randomfogo,2);
        }
        else
        {
            dados.d.jogarDados(randomfogo,1);
        }
        
        if(pai.GetComponent<tabManager>().faces[randomfogo].name == "limite")
        {
            
                sceneManager.s.fimDeJogo();
            
        }
        else
        {
            if (pai.GetComponent<tabManager>().faces[randomfogo] != null && pai.GetComponent<tabManager>().faces[randomfogo].name != "meio_casa" && pai.GetComponent<tabManager>().faces[randomfogo].GetComponent<tabManager>().pegandofogo == false)
            {

                GameObject paigo = pai.GetComponent<tabManager>().faces[randomfogo];
                if (umdois == 1)
                {
                    pai1 = paigo;
                }
                else
                {
                    pai2 = paigo;
                }



                if (paigo.transform.Find("fogo_1_floresta").gameObject.active == true)
                {
                    childdachild = paigo.transform.Find("fogo_1_floresta");
                }
                else if (paigo.transform.Find("fogo_2_floresta").gameObject.active == true)
                {
                    childdachild = paigo.transform.Find("fogo_2_floresta");
                }
                else
                {
                    childdachild = paigo.transform.Find("fogo_3_floresta");
                }



                paigo.GetComponent<tabManager>().pegandofogo = true;
                childdachild.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
                Instantiate(fogoanim, childdachild.transform.position, fogoanim.transform.rotation);
            }
            else
            {
                Debug.Log("Fim de jogo ou meio casa ou pegando fogo");
            }
        }
        
       
       
    }

}







