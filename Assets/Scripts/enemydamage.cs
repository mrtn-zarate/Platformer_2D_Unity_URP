using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class enemydamage : MonoBehaviour
{
    public AudioSource hit;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            hit.Play();
            Invoke("restartlevel", 0.5f);
        }

    }
    void restartlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}