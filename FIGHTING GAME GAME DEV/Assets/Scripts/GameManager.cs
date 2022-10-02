using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float p1health;
    public float p2health;
    public int rand;
    public GameObject health;


    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void P2turn()
    {
        SceneManager.LoadScene(3);
    }

    public void P1turn()
    {
        SceneManager.LoadScene(2);
    }

    public void setp1HP100()
    {
        p1health = 100f;
        Debug.Log("Player 1 set Health to 100");
    }

    public void setp2HP100()
    {
        p2health = 100f;
        Debug.Log("Player 2 set Health to 100");
    }

    public void setp1HP50()
    {
        p1health = 50f;
        Debug.Log("Player 1 set Health to 50");
    }
    public void setp2HP50()
    {
        p2health = 50f;
        Debug.Log("Player 2 set Health to 50");
    }

    public void setp1HP100text()
    {
 
    }

    public void setp2HP100text()
    {
        p2health = 100f;
        Debug.Log("Player 2 set Health to 100");
    }

    public void setp1HP50text()
    {
        p1health = 50f;
        Debug.Log("Player 1 set Health to 50");
    }
    public void setp2HP50text()
    {
        p2health = 50f;
        Debug.Log("Player 2 set Health to 50");
    }

    public void p1lowpunch()
    {
        rand = Random.Range(0,100);
        if (rand <= 75) 
        {
        SceneManager.LoadScene(6);
        p2health -= 3f;
        }
        else
        {
        SceneManager.LoadScene(7);
        }
        Debug.Log("Player 2 HP: "+ p2health);
    }

    public void p1highpunch()
    {
        int rand = Random.Range(0,100);
        if (rand <= 55) 
        {
        SceneManager.LoadScene(4);
        p2health -= 8f;
        }
        else
        {
        SceneManager.LoadScene(5);
        }


        Debug.Log("Player 2 HP: "+ p2health);
    }

    public void p2lowpunch()
    {
        rand = Random.Range(0,100);
        if (rand <= 75) 
        {
        SceneManager.LoadScene(20);
        p2health -= 3f;
        }
        else
        {
        SceneManager.LoadScene(21);
        }
        Debug.Log("Player 1 HP: "+ p1health);

    }

    public void p2highpunch()
    {
        int rand = Random.Range(0,100);
        if (rand <= 55) 
        {
        SceneManager.LoadScene(16);
        p2health -= 8f;
        }
        else
        {
        SceneManager.LoadScene(17);
        }
        Debug.Log("Player 1 HP: "+ p1health);

    }

    public void p1lowKick()
    {
        int rand = Random.Range(0,100);
        if (rand <= 65) 
        {
        SceneManager.LoadScene(10);
        p2health -= 6f;
        }
        else
        {
        SceneManager.LoadScene(11);
        }
        Debug.Log("Player 2 HP: "+ p2health);
    }

    public void p1highKick()
    {
        int rand = Random.Range(0,100);
        if (rand <= 45) 
        {
        SceneManager.LoadScene(8);
        p2health -= 12f;
        }
        else
        {
        SceneManager.LoadScene(9);
        }
        Debug.Log("Player 2 HP: "+ p2health);

    }

    public void p2lowKick()
    {
        int rand = Random.Range(0,100);
        if (rand <= 65) 
        {
        SceneManager.LoadScene(18);
        p2health -= 6f;
        }
        else
        {
        SceneManager.LoadScene(19);
        }
        Debug.Log("Player 1 HP: "+ p1health);
    }

    public void p2highKick()
    {
        int rand = Random.Range(0,100);
        if (rand <= 45) 
        {
        SceneManager.LoadScene(14);
        p2health -= 12f;
        }
        else
        {
        SceneManager.LoadScene(15);
        }
        Debug.Log("Player 1 HP: "+ p1health);

    }

    public void p1specialattack()
    {
        if (p1health <= 20f)
        {
        int rand = Random.Range(0,100);
        if (rand <= 90) 
        {
        SceneManager.LoadScene(12);
        p2health -= 6f;
        }
        else
        {
        SceneManager.LoadScene(13);
        }
        Debug.Log("Player 2 hp: "+ p2health);
        }
        
        
    }

    public void p2specialattack()
    {
        if (p2health <= 20f)
        {
        int rand = Random.Range(0,100);
        if (rand <= 90) 
        {
        SceneManager.LoadScene(23);
        p2health -= 6f;
        }
        else
        {
        SceneManager.LoadScene(22);
        }
        Debug.Log("Player 1 hp: "+ p1health);
    }
    }
}

