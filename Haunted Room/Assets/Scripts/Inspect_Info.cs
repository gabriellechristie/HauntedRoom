using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inspect_Info : MonoBehaviour
{   
    public GameObject dialogBox;
    public Text textFill;
    public GameObject piano;
    public GameObject fireplace;
    public Animator woman;
    public Animator boy;
    public GameObject womanStill;
    public GameObject boyStill;
    public Animator baby;
    public GameObject babyStill;
    public GameObject clock;
    public GameObject painting;
    public GameObject table;
    //audio
    public AudioSource pianoSource;

    //table animation
    public Animator phonoAnim; 

    void Start()
    {       
        dialogBox.SetActive(false);        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 500.0f))
            {
                if (hit.transform != null && (hit.collider.gameObject == fireplace))
                {                   
                    dialogBox.SetActive(true);
                    textFill.text = "Approaching the fireplace, you'd expect warmth, but the closer you get, the more it transforms. Flickering flames, eerie and cold, a ghostly chill, the tale unfolds.";
                }
                if (hit.transform != null && (hit.collider.gameObject == piano))
                {
                    pianoSource.Play();
                    dialogBox.SetActive(true);
                    textFill.text = "No fingers touch, yet melodies of the unseen play, A ghostly pianist, where echoes of silence and music lay";
                }
                if (hit.transform != null && (hit.collider.gameObject == clock))
                {
                    dialogBox.SetActive(true);
                    textFill.text = "No ticking hands, no pendulum's swing, In the house on Hollow’s street, time holds an eerie, motionless ring.";
                }
                if (hit.transform != null && (hit.collider.gameObject == painting))
                {
                    dialogBox.SetActive(true);
                    textFill.text = "The paintings seem to carry life within them, maybe even death. You could’ve sworn some paintings inched closer to you, not the frames, but the subjects themselves";
                }
                if (hit.transform != null && (hit.collider.gameObject == womanStill))
                {
                    woman.SetBool("IsWomanClicked", true);                   
                }
                if (hit.transform != null && (hit.collider.gameObject == babyStill))
                {
                    baby.SetBool("IsBabyOn", true);
                }
                if (hit.transform != null && (hit.collider.gameObject == boyStill))
                {
                    StartCoroutine(DelayAnimation());                    
                }
                if (hit.transform != null && (hit.collider.gameObject == table))
                {
                    phonoAnim.SetBool("isCrankOn", true);
                    phonoAnim.SetBool("IsDiskOn", false);

                    StartCoroutine(DelayDisk());
                }
            }            
        }

        if (Input.GetMouseButtonDown(1))
        {
            woman.SetBool("IsWomanClicked", false);
            boy.SetBool("IsBoyClicked", false);
            baby.SetBool("IsBabyOn", false);
            pianoSource.Stop();
            phonoAnim.SetBool("isCrankOn", false);
            phonoAnim.SetBool("IsDiskOn", false);

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            dialogBox.SetActive(false);
        }        
    }

    IEnumerator DelayAnimation()
    {
        yield return new WaitForSeconds(1);
        boy.SetBool("IsBoyClicked", true);
    }
    IEnumerator DelayDisk()
    {        
        if (Input.GetMouseButtonDown(1))
        {
            phonoAnim.SetBool("isCrankOn", false);
            phonoAnim.SetBool("IsDiskOn", false);

        }
        else
        {
            yield return new WaitForSeconds(3);
            phonoAnim.SetBool("IsDiskOn", true);
        }
    }
}

