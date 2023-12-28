using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TestWindow : BaseWindowWithData<TestWindowData>
{
    [SerializeField] private TextMeshProUGUI _title; 
    [SerializeField] private TextMeshProUGUI[] _answerText;

    private void Start()
    {
        GlobalContext.UIManager.UpdateWindowData(EWindows.TestWindow, UpdateData());
    }

    public void OnButtonClick(int AnswerId)
    {
        GlobalContext.TestManager.checkAnswerCurrectly(AnswerId);
    }

    public override void UpdateWindowData(BaseWindowData data)
    {
        base.UpdateWindowData(data);
        _title.text = Data.title;
    }

    private TestWindowData UpdateData()
    {
        Question question = GlobalContext.TestData.CurrentQuestion;
        TestWindowData newTestWindowData = new TestWindowData();
        newTestWindowData.title = question.QuestionTitle;
        for (int i = 0; i < _answerText.Length; i++)
        {
            _answerText[i].text = question.Answers[i].Text;
        }
        return newTestWindowData;
    }
}
