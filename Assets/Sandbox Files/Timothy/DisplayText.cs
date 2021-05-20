using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayText : MonoBehaviour
{

    public List<string> messages = new List<string>();
    private int currentmessage;
    bool inTrigger = false;
    public GameObject Light;

    // Start is called before the first frame update
    void Start()
    {
        currentmessage = 0;
        Light.SetActive(false);
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
                    Light.SetActive(false);
                }
                else
                {
                    GameManager.MainTextbox.text = "";
                    GameManager.MainTextBoxImage.gameObject.SetActive(false);
                    currentmessage = 0;
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        inTrigger = true;
        Light.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        inTrigger = false;
        Light.SetActive(false);
        GameManager.MainTextBoxImage.gameObject.SetActive(false);
    }
}
