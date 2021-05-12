using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCutscene : MonoBehaviour
{
    public List<string> messages = new List<string>();
    private int currentmessage;
    bool inTrigger = false;
    public GameObject CutsceneIndicator;
    [SerializeField]
    private GameObject cutscenecharacters;

    // Start is called before the first frame update
    void Start()
    {
        currentmessage = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (inTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (currentmessage < messages.Count)
                {
                    GameManager.MainTextbox.text = messages[currentmessage];
                    currentmessage++;
                    GameManager.MainTextBoxImage.gameObject.SetActive(true);
                    cutscenecharacters.SetActive(true);
                    CutsceneIndicator.SetActive(false);
                }
                else
                {
                    GameManager.MainTextbox.text = "";
                    GameManager.MainTextBoxImage.gameObject.SetActive(false);
                    currentmessage = 0;
                    cutscenecharacters.SetActive(false);
                    CutsceneIndicator.SetActive(true);
                }
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
