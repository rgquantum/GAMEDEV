using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public GameObject health;
    private Image Healthbar1;
    public float p1healthb;
    public float p1maxh;
    GameManager Script1;

    private void Awake() 
    {
        Script1 = GetComponent<GameManager>();
    }

    private void Start() 
   {
        DontDestroyOnLoad(this.gameObject);

   }


}
