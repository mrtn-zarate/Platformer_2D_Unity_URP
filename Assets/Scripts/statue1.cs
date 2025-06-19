using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statue1 : MonoBehaviour
{
    public GameObject Scrollpanel;
    public AudioSource clip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Scrollpanel.SetActive(true);
        clip.Play();

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Scrollpanel.SetActive(false);
        clip.Stop();
    }
}
