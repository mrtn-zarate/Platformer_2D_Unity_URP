using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UI_Canvas : MonoBehaviour
{
    public GameObject textmeshpro_totalscrolls;
    public GameObject pausepanel;
    public GameObject gameoverpanel;
    public GameObject transitionPanel;
    public bool panelabierto = false;
    static public int scrolls;
    TextMeshProUGUI textmeshpro_totalscrolls_text;

    void Start()
    {
        pausepanel.SetActive(false);
        Time.timeScale = 1;
        scrolls = 0;
        textmeshpro_totalscrolls_text = textmeshpro_totalscrolls.GetComponent<TextMeshProUGUI>();

    }


    void Update()
    {
        textmeshpro_totalscrolls_text.text = scrolls.ToString();

        if (Input.GetKeyDown(KeyCode.Tab) || Input.GetKeyDown(KeyCode.Escape))
        {
            if (panelabierto)
            {
                pausepanel.SetActive(false);
                Time.timeScale = 1;
                panelabierto = false;
            }
            else
            {
                pausepanel.SetActive(true);
                Time.timeScale = 0;
                panelabierto = true;
            }
        }
        if(scrolls>=4)
        {
            Time.timeScale = 0;

        }
    }
    public void reiniciarjuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void abrirpanel()
    {
        pausepanel.SetActive(true);
        Time.timeScale = 0;
        panelabierto = true;
    }
    public void cerrarpanel()
    {
        pausepanel.SetActive(false);
        Time.timeScale = 1;
        panelabierto = false;
    }
    public void mandaralmenuprincipal()
    {

        SceneManager.LoadScene("titlescreen");
    }
    public void mandaralanextlevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void cerrareljuego()
    {
        Application.Quit();
    }
    void nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void gototitlescreen()
    {
        SceneManager.LoadScene("titlescreen");
    }

}