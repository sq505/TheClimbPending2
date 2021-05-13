using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnter : MonoBehaviour
{
    [SerializeField] string _startDialogueButton;
    [SerializeField] bool _onPressButton = false;
    [SerializeField] UnityEvent _dialogueStartFunction;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if (_onPressButton == false)
            {
                _dialogueStartFunction?.Invoke();
            }
        }
    }

    private void Update()
    {
        if (_onPressButton == true)
        {
            if (Input.GetButtonDown(_startDialogueButton))
            {
                _dialogueStartFunction?.Invoke();
            }
        }
    }
}
