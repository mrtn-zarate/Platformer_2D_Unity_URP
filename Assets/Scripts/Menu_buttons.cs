using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_buttons : MonoBehaviour
{
    public GameObject canvas;
    public GameObject transitionPanel;
    public GameObject instructionsPanel;
    void Start()
    {
        Time.timeScale = 1;
        transitionPanel.SetActive(false);
        instructionsPanel.SetActive(false);
    }
    public void mandaralmenuprincipal()
    {
        
        transitionPanel.SetActive(true);
        Invoke("gototitlescreen", 1f);
    }
    public void mandaracreditos()
    {
        transitionPanel.SetActive(true);
        Invoke("gotocredits", 1f);

    }
    public void empezarjuego()
    {
        transitionPanel.SetActive(true);
        Invoke("nextlevel", 1f);
    }
    public void cerrareljuego()
    {
        Application.Quit();
    }
    public void mostrarinstructionspanel()
    {
        instructionsPanel.SetActive(true);
    }
    public void cerrarinstructionspanel()
    {
        instructionsPanel.SetActive(false);
    }
    void nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void gototitlescreen()
    {
        SceneManager.LoadScene("titlescreen");
    }
    void gotocredits()
    {
        SceneManager.LoadScene("credits");
    }

}
