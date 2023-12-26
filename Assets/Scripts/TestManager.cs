using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    [SerializeField] private Question[] questionAmount = new Question[0];

    private void Start()
    {
        TestData.Instance.settQuestionAmount(questionAmount.Length);
    }

    public void startTest()
    {
        Debug.Log("Method start test was emited");
        GlobalContext.UIManager.setWindow(EWindows.TestWindow);
    }

    public  void endTest() 
    {
        GlobalContext.UIManager.setWindow(EWindows.ResultWindow);
    }

    public void restartTest()
    {
        GlobalContext.UIManager.setWindow(EWindows.MenuWindow);
    }
}
