using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RETRYORQUIT : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void retry()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.DeleteAll();
    }

    public void quit()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
