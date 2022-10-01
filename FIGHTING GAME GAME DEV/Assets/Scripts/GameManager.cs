using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float p1health;
    public float p2health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setHP100()
    {
        p1health = 100f;
        p2health = 100f;
        Debug.Log("Player 1 set Health to 100");
        Debug.Log("Player 2 set Health to 100");
    }

    public void setHP50()
    {
        p1health = 50f;
        p2health = 60f;
        Debug.Log("Player 1 set Health to 100");
        Debug.Log("Player 2 set Health to 100");
    }

    public void p1punch()
    {
        p2health -= 11f;
        Debug.Log("Player 2 HP: "+ p2health);

    }

    public void p2punch()
    {
        p1health -= 11f;
        Debug.Log("Player 1 HP: "+ p1health);

    }

    public void p1Kick()
    {
        p2health -= 8f;
        Debug.Log("Player 2 HP: "+ p2health);
    }

    public void p2Kick()
    {
        p1health -= 8f;
        Debug.Log("Player 1 HP: "+ p1health);

    }
}
