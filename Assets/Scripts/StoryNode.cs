using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Story Node", menuName = "Story/Sequence/Create New Node", order = 1)]
public class StoryNode : ScriptableObject
{
    public string _name;
    public string _text;
    public float _duration;
    public Vector2 _dialoguePosition;
}
