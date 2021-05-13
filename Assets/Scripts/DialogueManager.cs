using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textBox;
    [SerializeField] string _skipButtonAxis;

    StorySequence _currentSequence;
    int _currentNode = 0;
    bool _isPlaying = false;

    private void Start()
    {
        _textBox.text = "";
    }

    public void PlaySequence(StorySequence storySequence)
    {
        if (_isPlaying) return;
        _textBox.text = "";
        _isPlaying = true;
        _currentSequence = storySequence;
        _duration = _currentSequence._nodes[_currentNode]._duration / _currentSequence._nodes[_currentNode]._text.Length;
        StartCoroutine("PrintText");
    }

    private void Update()
    {
        if (Input.GetButtonDown(_skipButtonAxis) && _isPlaying)
        {
            if (_currentNode > _currentSequence._nodes.Count - 1)
            {

                EndSequence();
            }
            else
            {
                if(!_isPrinting)
                    _duration = _currentSequence._nodes[_currentNode]._duration / _currentSequence._nodes[_currentNode]._text.Length;
                else
                    _duration = 0;
                NextNode();
            }
        }
    }

    void NextNode()
    {
        _textBox.text = "";
        StopCoroutine("PrintText");
        StartCoroutine("PrintText");
    }

    bool _isPrinting = false;
    float _duration = 0;
    IEnumerator PrintText()
    {
        _isPrinting = true;
        _textBox.rectTransform.position = new Vector2(_currentSequence._nodes[_currentNode]._dialoguePosition.x, _currentSequence._nodes[_currentNode]._dialoguePosition.y);
        foreach (char character in _currentSequence._nodes[_currentNode]._text)
        {
            _textBox.text += character;
            yield return new WaitForSeconds(_duration);
        }
        _currentNode++;
        _isPrinting = false;
    }

    void EndSequence()
    {
        StopCoroutine("PrintText");
        _textBox.text = "";
        _currentNode = 0;
        _isPlaying = false;
        _isPrinting = false;
    }
}
