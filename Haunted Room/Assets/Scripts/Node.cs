using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Node : MonoBehaviour
{
    public Transform cameraPos;
    public List<Node> reachableN = new List<Node>();

    [HideInInspector]
    public Collider col;  
   

    void Start()
    {
        col = GetComponent<Collider>();
    }

    private void OnMouseDown()
    {
        OnArrival();
    }
    public void OnArrival()
    {
        Manager.ins.currentN = this;
        Manager.ins.rig.Align(cameraPos);
    }
}


