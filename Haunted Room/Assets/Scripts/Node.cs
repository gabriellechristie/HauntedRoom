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
        if (Manager.ins.currentN != null)
        {
            Manager.ins.currentN.OnLeave();
        }
        Manager.ins.currentN = this;
        Manager.ins.rig.Align(cameraPos);
        if (col != null)
        {
            col.enabled = false;
        }

        foreach(Node node in reachableN)
        {
            if (node.col != null)
            {
                node.col.enabled = true;
            }
            //node.col.enabled = true;
        }
    }
    /*
    private void OnMouseDown()
    {
        Manager.ins.currentN = this;
        Sequence sequence = DOTween.Sequence();
        sequence.Append(Camera.main.transform.DOMove(cameraPos.position, 0.75f));
        sequence.Join(Camera.main.transform.DORotate(cameraPos.rotation.eulerAngles, 0.75f));

    }*/
    public void OnLeave()
    {
        foreach (Node node in reachableN)
        {
            if (node.col != null)
            {
                node.col.enabled = true;
            }
        }
    }

}


