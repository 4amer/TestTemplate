using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Question
{
    [SerializeField] private string _questionTitle = string.Empty;
    [SerializeField] private Answer[] _answerAmount = new Answer[0];

    [SerializeField] private Sprite _spreite;
    public string QuestionTitle { get { return _questionTitle; } }
    public Answer[] Answers { get { return _answerAmount; } }
    public Sprite Sprite { get { return _spreite; } }
}
