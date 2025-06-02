using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundcheck : MonoBehaviour
{
    public static bool touchingtheground;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        touchingtheground = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        touchingtheground = false;
    }
}
