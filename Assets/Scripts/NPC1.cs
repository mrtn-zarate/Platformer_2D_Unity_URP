using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1 : MonoBehaviour
{
    public GameObject NPCpanel;
    public AudioSource audiosource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        NPCpanel.SetActive(true);
        audiosource.Play();

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        NPCpanel.SetActive(false);
    }
    
}
