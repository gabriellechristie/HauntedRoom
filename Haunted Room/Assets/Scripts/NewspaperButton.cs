using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewspaperButton : MonoBehaviour
{
    //public Image newspaperWhole;
    public GameObject notes;
    //Image x;
    public AudioSource audioSource;

    private void Start()
    {
        //newspaperWhole.enabled = false;
        notes.SetActive(false);
       // x = GameObject.Find("X").GetComponent<Image>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            notes.SetActive(false);
        }
    }
    /*public void Close()
    {
       // x.enabled = false;
        notes.SetActive(false);
        //newspaperWhole.enabled = false;
    }*/
    public void Open()
    {
        audioSource.Play();

        notes.SetActive(true);

       // x.enabled = true;
        //newspaperWhole.enabled = true;
    }

}
