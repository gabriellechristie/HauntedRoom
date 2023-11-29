using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwoosh : MonoBehaviour
{
    //audio
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.Find("CameraSwoosh").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if ((hit.collider.name == "Sofa")||(hit.collider.name == "Chair_Front") || (hit.collider.name == "Piano") || (hit.collider.name == "Fireplace") || (hit.collider.name == "pCube2") || (hit.collider.name == "pCube3") || (hit.collider.name == "Clock") || (hit.collider.name == "Table"))
                {
                    audioSource.Play();
                }
            }
        }
        /*if (Input.GetMouseButtonDown(1))
        {
            audioSource.Play();
        }*/
    }
}
