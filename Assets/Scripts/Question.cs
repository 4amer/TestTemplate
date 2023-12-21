using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Question
{
    [SerializeField] private string questionTitle = string.Empty;
    [SerializeField] private Answer[] answerAmount = new Answer[0];

    public string getQuestionTitle { get { return questionTitle; } }
    public Answer[] getAnswers { get { return answerAmount; } }
}
