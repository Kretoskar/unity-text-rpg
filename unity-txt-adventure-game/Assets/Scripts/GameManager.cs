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
        storyText.text = currentState.GetStoryText();
        answerAText.text = currentState.GetAnswerAText();
        answerBText.text = currentState.GetAnswerBText();
	}

	void Update () {
		
	}
}
