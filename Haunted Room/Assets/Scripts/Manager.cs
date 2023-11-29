using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager ins;

    [HideInInspector]
    public Node currentN;

    public CamRig rig;

    private AudioSource audioSource;
    private void Awake()
    {
        ins = this;
        audioSource = GameObject.Find("CameraSwoosh").GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(1) && currentN.GetComponent<Prop>() != null)
        {
            audioSource.Play();
            currentN.GetComponent<Prop>().location.OnArrival();
        }
    }
}
