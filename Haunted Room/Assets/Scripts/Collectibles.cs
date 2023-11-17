using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collectibles : MonoBehaviour
{
	//public bool isNewsOn;
	private Image newspaper1;
	private Image newspaper2;
	private Image newspaper3;
	private Image newspaper4;

	public GameObject collectible1;
	public GameObject collectible2;
	public GameObject collectible3;
	public GameObject collectible4;


	int counter = 0;
	void Start()
    {
		//img = GameObject.Find("ItemsFound").GetComponent<Image>();
		newspaper1 = GameObject.Find("Newspaper1").GetComponent<Image>();
		newspaper2 = GameObject.Find("Newspaper2").GetComponent<Image>();
		newspaper3 = GameObject.Find("Newspaper3").GetComponent<Image>();
		newspaper4 = GameObject.Find("Newspaper4").GetComponent<Image>();

		newspaper1.enabled = false;
		newspaper2.enabled = false;
		newspaper3.enabled = false;
		newspaper4.enabled = false;
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
				if (hit.transform != null && (hit.collider.name == "collectible1"))
				{
					counter++;
					if (counter == 1)
					{
						newspaper1.enabled = true;
						collectible1.SetActive(false);
					}
				}
				if (hit.transform != null && (hit.collider.name == "collectible2"))
				{
					counter++;
					if (counter == 2)
					{
						newspaper2.enabled = true;
						collectible2.SetActive(false);
					}
				}
				if (hit.transform != null && (hit.collider.name == "collectible3"))
				{
					counter++;
					if (counter == 3)
					{
						newspaper3.enabled = true;
						collectible3.SetActive(false);
					}
				}
				if (hit.transform != null && (hit.collider.name == "collectible4"))
				{
					counter++;
					if (counter == 4)
					{
						newspaper4.enabled = true;
						collectible4.SetActive(false);
					}
				}
			}
		}
    }
}
