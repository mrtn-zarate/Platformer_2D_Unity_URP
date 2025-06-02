using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerrespawn : MonoBehaviour
{
    private float checkpointpositionx, checkpointpositiony;

    void Start()
    {
        if(checkpoint.checkpointtouched)
        {
            transform.position=(new Vector2(PlayerPrefs.GetFloat("checkpointpositionx"), PlayerPrefs.GetFloat("checkpointpositiony")));
        }
    }


    public void reachedcheckpoint(float x, float y)
    {
        PlayerPrefs.SetFloat("checkpointpositionx", x);
        PlayerPrefs.SetFloat("checkpointpositionx", y);
    }


}
