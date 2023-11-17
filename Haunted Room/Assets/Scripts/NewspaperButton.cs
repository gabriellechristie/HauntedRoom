using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewspaperButton : MonoBehaviour
{
    GameObject newspaperWhole;
    Image button;

    private void Start()
    {
        button = GameObject.Find("X").GetComponent<Image>();

        newspaperWhole = GameObject.Find("NewspaperWhole");
    }
    public void Close()
    {
        button.enabled = false;
        newspaperWhole.SetActive(false);
    }
    public void Open()
    {
        button.enabled = true;
        newspaperWhole.SetActive(true);
    }

}
