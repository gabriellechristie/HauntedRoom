using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inspect_Info : MonoBehaviour
{
    Image textBox;
    Text pressE;
    public Text circleWords;
    public GameObject circle;
    
    // Start is called before the first frame update
    void Start()
    {
        textBox = GameObject.Find("Text_Box").GetComponent<Image>();
        pressE = GameObject.Find("Press E").GetComponent<Text>();

        textBox.enabled = false;
        pressE.enabled = false;
        circleWords.enabled = false;
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
                if (hit.transform != null && (hit.collider.gameObject == circle))
                {
                    textBox.enabled = true;
                    pressE.enabled = true;
                    circleWords.enabled = true;
                    circleWords.text = "Lore goes here";
                }
            }            
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            textBox.enabled = false;
            pressE.enabled = false;
            circleWords.enabled = false;

        }
    }
}

