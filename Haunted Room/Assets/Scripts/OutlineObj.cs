using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OutlineObj : MonoBehaviour
{
    private Transform highlight;
    private RaycastHit raycastHit;
    private Transform select;

    private void Update()
    {
        if (highlight != null)
        {
            highlight.gameObject.GetComponent<Outline>().enabled = false;
            highlight = null;
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (!EventSystem.current.IsPointerOverGameObject() && Physics.Raycast(ray, out raycastHit))
        {
            highlight = raycastHit.transform;
            if (highlight.CompareTag("Select") && highlight != select)
            {
                if (highlight.gameObject.GetComponent<Outline>() != null)
                {
                    highlight.gameObject.GetComponent<Outline>().enabled = true;
                }
                else
                {
                    Outline outline = highlight.gameObject.AddComponent<Outline>();
                    outline.enabled = true;
                    highlight.gameObject.GetComponent<Outline>().OutlineWidth = 7.0f;
                }
            }
            else
            {
                highlight = null; 
            }
        }

        /* if (Input.GetMouseButtonDown(0))
         {
             if (highlight)
             {
                 if (select != null)
                 {
                     select.gameObject.GetComponent<Outline>().enabled = false;
                 }
                 select = raycastHit.transform;
                 select.gameObject.GetComponent<Outline>().enabled = true;
                 highlight = null;
             }
             else
             {
                 if (select)
                 {
                     select.gameObject.GetComponent<Outline>().enabled = false;
                     select = null;
                 }
             }
         }*/
    }
}
