using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar1 : MonoBehaviour
{
    public GameObject health;
    private Image Healthbar2;
    public float p2healthb;
    public float p2maxh;
    GameManager Script1;

    private void Awake() 
    {
        Script1 = GetComponent<GameManager>();
    }

    private void Start() 
   {
        DontDestroyOnLoad(this.gameObject);

   }

   private void Update() 
   {
    
   }
}
