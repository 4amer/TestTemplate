using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class TestData
{
    private int currentCorrectlyAnswers = 0;
    private int questionAmount = 0;
    private int currentScore = 0;
    private int maxScore = 0;

    private Question currentQuestion = null;

    private static TestData testData = null;
    private TestData() { }
    public static TestData Instance()
    {
        if (testData == null) 
            testData = new TestData();
        return testData;
    }

    public void addCorrectlyAnswers(int num) { currentCorrectlyAnswers += num; }
    public int getCorrectlyAnswers () { return currentCorrectlyAnswers; }
    public void settQuestionAmount(int num) { questionAmount = num; }
    public int getQuestionAmount () {  return questionAmount; }
    public void addCurrentScore(int num) { currentScore += num; }
    public int getCurrentScore () { return currentScore; }
    public void setMaxScore(int num) { maxScore = num; }
    public int getMaxScore () { return maxScore; }
    public void setCurrentQuestion(Question question) { currentQuestion = question; }
    public Question getCurrentQuestion() { return currentQuestion; }
}
