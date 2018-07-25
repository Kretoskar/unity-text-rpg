using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private Text storyText;

    [SerializeField]
    private Text answerAText;

    [SerializeField]
    private Text answerBText;

    [SerializeField]
    private State startingState;

    private State currentState;

	void Start () {
        currentState = startingState;
        UpdateText();
	}

	void Update () {
        if (!currentState.GetIsGameOverOrWin())
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                ManageStates(0);
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                ManageStates(1);
            }
        } else
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                ManageStates(0);
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                Application.Quit();
            }
        }
	}

    private void ManageStates(int stateNumber)
    {
        State[] nextStates = currentState.GetNextStates();
        currentState = nextStates[stateNumber];
        UpdateText();
    }

    private void UpdateText()
    {
        storyText.text = currentState.GetStoryText();
        answerAText.text = currentState.GetAnswerAText();
        answerBText.text = currentState.GetAnswerBText();
    }
}
