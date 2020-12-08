using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public static sceneManager s;
    public GameObject GameOver;
    public GameObject YouWin;
    void Start()
    {
        s = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            RestartScene();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            proximaFase();
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            YouWin.SetActive(true);
        }
    }

    public void RestartScene()
    {
        SceneManager.LoadScene("diadofogo");
    }

    public void sairDoJogo()
    {
        Application.Quit();
    }

    public void jogarNovamente()
    {
        SceneManager.LoadScene("diadofogo");
    }

    public void proximaFase()
    {
        SceneManager.LoadScene("diadofogo 1");
    }


    public void fimDeJogo()
    {
        GameOver.SetActive(true);
    }

}
