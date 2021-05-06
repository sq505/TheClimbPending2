using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneTrigger : MonoBehaviour
{
    public GameObject Trigger;
    public GameObject CutObj;

    void Start()
    {
        Trigger.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            Trigger.SetActive(true);
            
        }
    }
    void Update()
    {

    }
}
