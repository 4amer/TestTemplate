using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Question
{
    [SerializeField] private string _questionTitle = string.Empty;
    [SerializeField] private Answer[] _answerAmount = new Answer[0];

    public string QuestionTitle { get { return _questionTitle; } }
    public Answer[] Answers { get { return _answerAmount; } }
}
