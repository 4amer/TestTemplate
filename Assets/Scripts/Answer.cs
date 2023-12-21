using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Answer
{
    [SerializeField] string answerText = string.Empty;
    [SerializeField] bool isCorrectly = false;

    public string getAnswerText()
    {
        return answerText;
    }

    public bool getIsCurrectly(){
        return isCorrectly;
    }
}
