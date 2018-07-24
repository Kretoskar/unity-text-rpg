using System.Collections;
using System.Collections.Generic;
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
}
