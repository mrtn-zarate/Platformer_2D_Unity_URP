using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treemusic : MonoBehaviour
{
    public AudioSource clip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            clip.Play();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        clip.Stop();
    }
}
