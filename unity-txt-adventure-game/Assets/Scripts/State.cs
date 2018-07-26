using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {
    [TextArea(14, 10)]
    [SerializeField]
    private string mStoryText;

    [TextArea(14, 10)]
    [SerializeField]
    private string mAnswerAText;

    [TextArea(14, 10)]
    [SerializeField]
    private string mAnswerBText;

    [SerializeField]
    private bool isGameOverOrWin;

    [SerializeField]
    private State[] mNextStates;

    public string GetStoryText()
    {
        return mStoryText;
    }

    public string GetAnswerAText()
    {
        return mAnswerAText;
    }

    public string GetAnswerBText()
    {
        return mAnswerBText;
    }

    public State[] GetNextStates()
    {
        return mNextStates;
    }

    public bool GetIsGameOverOrWin()
    {
        return isGameOverOrWin;
    }
}
