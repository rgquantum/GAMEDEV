using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class getname : MonoBehaviour
{
    public TextMeshProUGUI p2name;
    public TextMeshProUGUI p1name;

    void Start()
    {
        p1name.text = PlayerPrefs.GetString("p2sn");
        p2name.text = PlayerPrefs.GetString("p1sn");
    }
}
