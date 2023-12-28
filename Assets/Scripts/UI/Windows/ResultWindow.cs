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
        correctAnswers.text = "Вы ответили верно на: " + correctQuestions + "/" + allQuestion + " вопросов!";
    }
    public void GoToStart()
    {
        GlobalContext.TestData.RestartTest();
        GlobalContext.UIManager.setWindow(EWindows.MenuWindow);
    }
}
