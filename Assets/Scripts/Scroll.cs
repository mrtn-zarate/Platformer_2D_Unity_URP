using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Scroll : MonoBehaviour
{

    public AudioSource clip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            clip.Play();
            UI_Canvas.scrolls += 1;
            this.GetComponent<Collider2D>().enabled = false;
            this.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Invoke("dissapearchindren", 1f);
        }
        
    }
    void dissapearchindren()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false); 
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
    }
}
