using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    //light source
    public Light lightSource;

    //lightning strike on
    public float onMin = 0.25f;
    public float onMax = 0.8f;

    //between lightning strikes
    public float bewteenMin = 10f;
    public float betweenMax = 60f;    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LightningDelay()); 
    }   
    IEnumerator LightningDelay()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(bewteenMin, betweenMax));
            lightSource.enabled = true;

            yield return new WaitForSeconds(Random.Range(onMin, onMax));
            lightSource.enabled = false;
        }
    }
}
