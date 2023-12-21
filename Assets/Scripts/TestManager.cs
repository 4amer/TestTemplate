using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    TestData testData = TestData.Instance();
    [SerializeField] private Question[] questionAmount = new Question[0];

    private void Start()
    {
        testData.settQuestionAmount(questionAmount.Length);
    }
}
