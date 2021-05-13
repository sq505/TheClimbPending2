using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName ="New Story Sequence", menuName ="Story/Sequence/Create New Sequence", order = 0)]
public class StorySequence : ScriptableObject
{
    public List<StoryNode> _nodes;
}
