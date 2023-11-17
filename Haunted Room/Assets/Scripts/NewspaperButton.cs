using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewspaperButton : MonoBehaviour
{
    public GameObject newspaperWhole;
    Image x;
    private void Start()
    {
        x = GameObject.Find("X").GetComponent<Image>();
    }
    public void Close()
    {
        x.enabled = false;
        newspaperWhole.SetActive(false);
    }
    public void Open()
    {
        x.enabled = true;
        newspaperWhole.SetActive(true);
    }

}
