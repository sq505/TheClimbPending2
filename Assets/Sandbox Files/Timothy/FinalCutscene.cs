using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCutscene : MonoBehaviour
{
    bool inTrigger = false;
    public GameObject CutsceneIndicator;
    public GameObject Joe;
    public GameObject Camera2;
    public GameObject playerJoe;
    public GameObject Dialogue;
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
                Joe.SetActive(true);
                Camera2.SetActive(true);
                playerJoe.SetActive(false);
                Dialogue.SetActive(true);
                CutsceneIndicator.SetActive(false);
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
