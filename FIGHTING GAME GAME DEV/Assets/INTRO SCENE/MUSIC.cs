using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MUSIC : MonoBehaviour
{
    public static MUSIC instance; 

    private void Awake() 
    {
        DontDestroyOnLoad(this.gameObject); 

        if (instance == null) 
        {
            instance = this; 
        }
        else 
        {
            Destroy(gameObject); 
        }
    }
}