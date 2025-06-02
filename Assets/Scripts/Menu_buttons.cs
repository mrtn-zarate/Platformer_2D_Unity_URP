using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_buttons : MonoBehaviour
{
    public GameObject canvas;
    public GameObject transitionPanel;
    void Start()
    {
        transitionPanel.SetActive(false);
    }
    public void mandaralmenuprincipal()
    {
        
        transitionPanel.SetActive(true);
        Invoke("gototitlescreen", 1f);
    }
    public void mandaracreditos()
    {
        SceneManager.LoadScene("credits");
        
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
    void nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void gototitlescreen()
    {
        SceneManager.LoadScene("titlescreen");
    }
}
