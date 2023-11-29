using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collectibles : MonoBehaviour
{
	private Image newspaper1;
	private Image newspaper2;
	private Image newspaper3;
	private Image newspaper4;
	private Image x;
	private Image button;

	public GameObject collectible1;
	public GameObject collectible2;
	public GameObject collectible3;
	public GameObject collectible4;
	public GameObject notes;

	public Animator anim;
	
	public AudioSource audioSource;


	int counter = 0;
	void Start()
    {
		notes.SetActive(false);
		newspaper1 = GameObject.Find("Newspaper1").GetComponent<Image>();
		newspaper2 = GameObject.Find("Newspaper2").GetComponent<Image>();
		newspaper3 = GameObject.Find("Newspaper3").GetComponent<Image>();
		newspaper4 = GameObject.Find("Newspaper4").GetComponent<Image>();
		button = GameObject.Find("Open").GetComponent<Image>();
		
		newspaper1.enabled = false;
		newspaper2.enabled = false;
		newspaper3.enabled = false;
		newspaper4.enabled = false;

		
		button.enabled = false;

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
					collectible1.SetActive(false);
					newspaper1.enabled = true;
					audioSource.Play();
				}
				if (hit.transform != null && (hit.collider.name == "collectible2"))
				{
					counter++;
					collectible2.SetActive(false);
					newspaper2.enabled = true;
					audioSource.Play();
				}
				if (hit.transform != null && (hit.collider.name == "collectible3"))
				{
					counter++;
					collectible3.SetActive(false);
					newspaper3.enabled = true;					audioSource.Play();

				}
				if (hit.transform != null && (hit.collider.name == "collectible4"))
				{
					counter++;
					newspaper4.enabled = true;
					collectible4.SetActive(false);
					audioSource.Play();
				}
				if (counter == 4)
				{
					//animationObj.SetActive(true);
					//animation.Play("Newspaper");
					//animationObj.SetActive(false);
					notes.SetActive(true);
					anim.SetBool("IsNoteOn", true);
					counter++;
					//x.enabled = true;
					button.enabled = true;
					//newspaperWhole.SetActive(true);
				}
			}
		}
    }
}
