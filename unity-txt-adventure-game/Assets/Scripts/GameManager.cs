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

    [SerializeField]
    private AudioClip clickAudio;

    private AudioSource audioSource;

    private State currentState;


	void Start () {
        audioSource = GetComponent<AudioSource>();
        currentState = startingState;
        UpdateText();
	}

	void Update () {
        GetUserInput();
	}

    private void ManageStates(int stateNumber)
    {
        ClickSound();
        State[] nextStates = currentState.GetNextStates();
        currentState = nextStates[stateNumber];
        UpdateText();
    }

    private void GameOver()
    {
        ClickSound();
        Application.Quit();
    }

    private void UpdateText()
    {
        storyText.text = currentState.GetStoryText();
        answerAText.text = currentState.GetAnswerAText();
        answerBText.text = currentState.GetAnswerBText();
    }

    private void ClickSound()
    {
        audioSource.PlayOneShot(clickAudio);
    }

    private void GetUserInput()
    {
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
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                ManageStates(0);
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                GameOver();
            }
        }
    }
}
