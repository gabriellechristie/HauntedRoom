using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager ins;

    [HideInInspector]
    public Node currentN;

    public CamRig rig;

    private void Awake()
    {
        ins = this;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(1) && currentN.GetComponent<Prop>() != null)
        {
            currentN.GetComponent<Prop>().location.OnArrival();
        }
    }
}
