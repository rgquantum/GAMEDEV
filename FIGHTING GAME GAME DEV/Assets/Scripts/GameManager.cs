using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public float sp1;
    public float sp2;
    public float spc2;
    public float spc1;
    public float nrg1 = 0f;
    public float nrg2 = 0f;
    public float p1health;
    public float p2health;
    public float p1max;
    public float p2max;
    public int rand;
    public TextMeshProUGUI ultr;
    public TextMeshProUGUI ultr2;





    private void Start()  
    {
        sp1 = spc1;
        sp2 = spc2;
        p1health = PlayerPrefs.GetFloat("p1hp");
        p2health = PlayerPrefs.GetFloat("p2hp");
        p1max = PlayerPrefs.GetFloat("p1m");
        p2max = PlayerPrefs.GetFloat("p2m");
        sp1 = PlayerPrefs.GetFloat("csp1");
        sp2 = PlayerPrefs. GetFloat("csp2");
        nrg1 = PlayerPrefs.GetFloat("spn");
        nrg2 = PlayerPrefs.GetFloat("spn1");
        healthcheck();
        specialcheck();


    }

    private void Update() 
    {
        PlayerPrefs.SetFloat("p1hn", p1health);
        PlayerPrefs.SetFloat("p2hn", p2health);
        PlayerPrefs.SetFloat("p1max", p1max);
        PlayerPrefs.SetFloat("p2max", p2max);
        PlayerPrefs.SetFloat("p1sp", sp1);
        PlayerPrefs.SetFloat("p2sp", sp2);
        PlayerPrefs.SetFloat("spn", nrg1);
        PlayerPrefs.SetFloat("spn1", nrg2);
        PlayerPrefs.GetFloat("nnrg1", nrg1);
        PlayerPrefs.GetFloat("nnrg2", nrg2);
    }   

    public void specialcheck()
    {
        if(sp1 < 1f)
        {
        if(nrg1 >= 3f)
        {
            ultr.text = "Ultimate is ready";
        }
        }
        if(sp2 < 1f)
        {
        if(nrg2 >= 3f)
        {
            ultr2.text = "Ultimate is ready";
        }
        }
    }

    public void healthcheck()
    {
        if (p1health < 1f)
        {
            SceneManager.LoadScene(25);
        }
        if (p2health < 1f)
        {
            SceneManager.LoadScene(24);
        }
    }

    

    public void p1lowpunch()
    {
        rand = Random.Range(0,100);
        if (rand <= 75) 
        {
        SceneManager.LoadScene(6);
        p2health -= 3f;
        nrg1 += 1f;
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
        nrg1 += 1f;
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
        p1health -= 3f;
        nrg2 += 1f;
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
        p1health -= 8f;
        nrg2 += 1f;
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
        nrg1 += 1f;
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
        nrg1 += 1f;
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
        p1health -= 6f;
        nrg2 += 1f;
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
        p1health -= 12f;
        nrg2 += 1f;
        }
        else
        {
        SceneManager.LoadScene(15);
        }
        Debug.Log("Player 1 HP: "+ p1health);

    }

    public void p1specialattack()
    {
        if(sp1 >= 1f)
        {

        }
        else
        {
        if(nrg1 >= 3f)
        {
        SceneManager.LoadScene(12);
        p2health -= 25f;
        sp1 += 1f;
        Debug.Log("Player 2 hp: "+ p2health);
        }
        }
    }
        

    public void p2specialattack()
    {   
        if(sp2 >= 1f)
        {

        }
        else
        {
        if(nrg2 >= 3f)
        {
        SceneManager.LoadScene(23);
        p1health -= 25f;
        sp2 += 1f;
        Debug.Log("Player 1 hp: "+ p1health);
        }
        }
    }   
    
}

