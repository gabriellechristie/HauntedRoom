using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerControl : MonoBehaviour
{
    //works on any light
    //make light appropriately cool
    public bool isFlickering = false;
    public float timeDelay = 10f;
    public float timeDelay2 = 0f;
    //private float thunderDelay;
    public AudioSource audioSource;
    public Camera cam;
    private void Start()
    {
        
        cam.backgroundColor = Color.black;
    }
    void Update()
    {
        if (this.gameObject.GetComponent<Light>().enabled == false)
        {
            cam.backgroundColor = Color.black;
        }
        else
        {
            cam.backgroundColor = new Color(114, 210, 255);
        }
        if (isFlickering == false) //immediately jump right back into the coroutine
        {
            StartCoroutine(FlickeringLight());
            StartCoroutine(ThunderDelay());
        }
        
    }
    IEnumerator FlickeringLight()
    {
        isFlickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(6, 15);
        yield return new WaitForSeconds(timeDelay); //delay between groups of flashes

        for (int i = 0; i < Random.Range(2, 5); i++) //create this random amount of flashes
        {
            
            this.gameObject.GetComponent<Light>().enabled = true;
            timeDelay = Random.Range(1f, 3f); //stay on for this long            
            yield return new WaitForSeconds(timeDelay);
            this.gameObject.GetComponent<Light>().enabled = false;
            timeDelay2 = Random.Range(0.01f, 0.2f); //delay between each flash
            yield return new WaitForSeconds(timeDelay2);

            //isFlickering = false;
        }
        isFlickering = false;

    }
    IEnumerator ThunderDelay()
    {
        yield return new WaitForSeconds(timeDelay);
        audioSource.Play();
    }
}
