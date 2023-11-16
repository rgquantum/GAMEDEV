using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class specialbar : MonoBehaviour
{
    public Image nrgbar1;
    public Image nrgbar2;
    public float enrg;
    public float enrg2;
    public float maxn = 3f;
    public float maxn2 = 3f;
    




    void Start()
    {
 
        enrg = maxn;
        enrg2 = maxn2;         
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("nnrg1", enrg);
        PlayerPrefs.SetFloat("nnrg2", enrg2);
        enrg = PlayerPrefs.GetFloat("spn");
        enrg2 = PlayerPrefs.GetFloat("spn1");   
        nrgbar1.fillAmount = enrg / maxn;
        nrgbar2.fillAmount = enrg2 / maxn2;
    }
}
