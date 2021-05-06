using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StairTrigger : MonoBehaviour
{
    public GameObject Stair;
    public GameObject Trigger;

    void Start()
    {
        Stair.GetComponent<PolygonCollider2D>().enabled = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            Stair.GetComponent<PolygonCollider2D>().enabled = true;
            
        }
    }
    void Update()
    {

    }
}
