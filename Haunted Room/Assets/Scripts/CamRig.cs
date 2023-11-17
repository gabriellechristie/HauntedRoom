using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CamRig : MonoBehaviour
{
    public Transform xAxis;
    public Transform yAxis;
    public float travelTime;

   public void Align(Transform target)
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(yAxis.DOMove(target.position, 0.75f));
        sequence.Join(yAxis.DORotate(new Vector3(0f,target.rotation.eulerAngles.y, 0f), 0.75f));
        sequence.Join(xAxis.DOLocalRotate(new Vector3(target.rotation.eulerAngles.x, 0f, 0f), 0.75f));
    }
}
