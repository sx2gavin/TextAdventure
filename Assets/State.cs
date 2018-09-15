using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State", order = 1)]
public class State : ScriptableObject {

    [TextArea(15, 20)]
    public string TextContent;

    [SerializeField]
    public List<State> NextStates;

    public IList<State> GetAllNextStates()
    {
        return NextStates;
    } 
}
