using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class DisplayTimelineCutscene : MonoBehaviour
{
    bool inTrigger = false;
    public GameObject CutsceneIndicator;
    public GameObject Tony;
    public GameObject Nathan;
    public GameObject Mathew;
    public GameObject Drake;
    public GameObject Max;
    [SerializeField]
    private GameObject CutsceneDirector;

    // Start is called before the first frame update
    void Start()
    {
        CutsceneIndicator.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (inTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                CutsceneDirector.SetActive(true);
                Tony.SetActive(true);
                Nathan.SetActive(true);
                Mathew.SetActive(true);
                Drake.SetActive(true);
                Max.SetActive(true);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        inTrigger = true;
        CutsceneIndicator.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        inTrigger = false;
        CutsceneIndicator.SetActive(false);
        CutsceneDirector.SetActive(false);
        Tony.SetActive(false);
        Nathan.SetActive(false);
        Mathew.SetActive(false);
        Drake.SetActive(false);
        Max.SetActive(false);
    }
}
