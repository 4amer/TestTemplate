using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultWindow : BaseWindowWithData<ResultWindowData>
{
    [SerializeField] private TextMeshProUGUI correctAnswers;

    private void Start()
    {
        string allQuestion = GlobalContext.TestData.QuestionAmount.ToString();
        string correctQuestions = GlobalContext.TestData.CorrectlyAnswers.ToString();
        correctAnswers.text = "�� �������� ����� ��: " + correctQuestions + "/" + allQuestion + " ��������!";
    }
    public void GoToStart()
    {
        GlobalContext.TestData.RestartTest();
        GlobalContext.UIManager.setWindow(EWindows.MenuWindow);
    }
}
