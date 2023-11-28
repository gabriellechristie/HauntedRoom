using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning2 : MonoBehaviour
{
    public GameObject lightning1;
    public GameObject lightning2;
    public GameObject lightning3;

    public GameObject audioSource;

    // Start is called before the first frame update
    void Start()
    {
        lightning1.SetActive(false);
        lightning2.SetActive(false);
        lightning3.SetActive(false);

        audioSource.SetActive(false);

        Invoke("LightningOn", 1.75f);
    }

    void LightningOn()
    {
        int range = Random.Range(0, 3);
        if (range == 0)
        {
            lightning1.SetActive(true);
            Invoke("EndLightning", .125f);
            Invoke("PlayAudio", .395f);
        }
        else if(range == 1)
        {
            lightning2.SetActive(true);
            Invoke("EndLightning", .105f);
            Invoke("PlayAudio", .195f);
        }
        else if (range == 2)
        {
            lightning3.SetActive(true);
            Invoke("EndLightning", .75f);
            PlayAudio();
        }
    }

    void EndLightning()
    {
        lightning1.SetActive(false);
        lightning2.SetActive(false);
        lightning3.SetActive(false);

    }
    void PlayAudio()
    {
        audioSource.SetActive(true);
        Invoke("EndAudio", 3.4f);
    }
    void EndAudio()
    {
        audioSource.SetActive(false);
    }
}
