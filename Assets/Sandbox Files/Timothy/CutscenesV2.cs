using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutscenesV2 : MonoBehaviour
{
    bool inTrigger = false;
    public GameObject CutsceneIndicator;
    public GameObject Actors;
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
                Actors.SetActive(true);
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
        Actors.SetActive(false);
    }
}
