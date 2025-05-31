using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_buttons : MonoBehaviour
{
    public GameObject canvas;

    public void mandaralmenuprincipal()
    {
        SceneManager.LoadScene("titlescreen");
    }
    public void mandaracreditos()
    {
        SceneManager.LoadScene("credits");
    }
    public void empezarjuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void cerrareljuego()
    {
        Application.Quit();
    }
}
