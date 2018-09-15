using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour {

    [SerializeField] Text text;
    [SerializeField] State CurrentState;

	// Use this for initialization
	void Start ()
    {
        UpdateText();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            IList<State> states = CurrentState.GetAllNextStates();
            CurrentState = states[0];
            UpdateText();
        }
	}

    private void UpdateText()
    {
        text.text = CurrentState.TextContent;
    }
}
