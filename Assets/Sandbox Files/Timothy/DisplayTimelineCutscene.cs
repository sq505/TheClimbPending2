using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class DisplayTimelineCutscene : MonoBehaviour
{
    bool inTrigger = false;
    public GameObject CutsceneIndicator;
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
    }
}
