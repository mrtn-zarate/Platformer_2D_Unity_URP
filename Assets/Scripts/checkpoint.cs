using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public static bool checkpointtouched=false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            checkpointtouched = true;
            collision.GetComponent<playerrespawn>().reachedcheckpoint(transform.position.x, transform.position.y);
            this.GetComponent<SpriteRenderer>().enabled = false;
            Debug.Log("checpint tocado");
        }
    }
}
