﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayTextwTrigger : MonoBehaviour
{

    public GameObject Trigger;
    public List<string> messages = new List<string>();
    private int currentmessage;
    bool inTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        currentmessage = 0;
        Trigger.SetActive(false);
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
                    Trigger.SetActive(true);
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
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        inTrigger = false;       
    }
}
