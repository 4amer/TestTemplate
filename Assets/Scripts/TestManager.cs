using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using static UnityEngine.Mesh;

public class TestManager : MonoBehaviour
{
    [SerializeField] private Question[] _questionAmount = new Question[0];

    private void Start()
    {
        TestData.Instance.settQuestionAmount(_questionAmount.Length);
    }

    public void startTest()
    {
        GlobalContext.UIManager.setWindow(EWindows.TestWindow);
        GlobalContext.TestData.setCurrentQuestion(_questionAmount[GlobalContext.TestData.CurrentQuestionID]);
    }

    public  void endTest() 
    {
        GlobalContext.UIManager.setWindow(EWindows.ResultWindow);
    }

    public void restartTest()
    {
        GlobalContext.UIManager.setWindow(EWindows.MenuWindow);
    }

    public void checkAnswerCurrectly(int answerId)
    {
        if (_questionAmount.Length == 0)
        {
            Debug.LogError("Questions does'nt search");
            return;
        }
        if(answerId > GlobalContext.TestData.CurrentQuestion.Answers.Length)
        {
            Debug.LogError("The button ID is greater than the number of answers");
            return;
        }
        answerId -= 1;
        Answer answer = GlobalContext.TestData.CurrentQuestion.Answers[answerId];
        Boolean isCorrectly = answer.IsCurrectly;
        if (isCorrectly)
        {
            Debug.Log("Currect Answer!!!");
            GlobalContext.TestData.addCorrectlyAnswers();
            GlobalContext.TestData.addCurrentScore(answer.Score);
        }
        NextQuestion();
    }

    private void NextQuestion()
    {
        TestData TestData = GlobalContext.TestData;
        TestData.NextQuestionID();
        if (TestData.CurrentQuestionID >= _questionAmount.Length) 
        {
            GlobalContext.UIManager.setWindow(EWindows.ResultWindow);
        }
        Question question = _questionAmount[TestData.CurrentQuestionID];
        TestData.setCurrentQuestion(question);
        GlobalContext.GlobalManager.ReloadScene();
    }
}
