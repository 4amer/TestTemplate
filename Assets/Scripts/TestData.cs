public class TestData
{
    private string _testName = string.Empty;

    private int currentCorrectlyAnswers = 0;
    private int questionAmount = 0;
    private int currentScore = 0;
    private int maxScore = 0;

    private Question currentQuestion = null;
    private int currentQuestionID = 0;

    private static TestData testData = null;
    private TestData() { }
    public static TestData Instance
    {
        get {
            if (testData == null) 
                testData = new TestData();
            return testData;
        }
    }

    public string TestName 
    { 
        get {  return _testName; } 
    }

    public void addCorrectlyAnswers() 
    { 
        currentCorrectlyAnswers++; 
    }

    public int CorrectlyAnswers
    { 
        get{ return currentCorrectlyAnswers; } 
    }

    public void settQuestionAmount(int num) 
    { 
        questionAmount = num; 
    }

    public int QuestionAmount
    {
        get { return questionAmount; }
    }

    public void addCurrentScore(int num) 
    { 
        currentScore += num; 
    }

    public int CurrentScore 
    { 
        get { return currentScore; }
    }

    public void setMaxScore(int num) 
    { 
        maxScore = num; 
    }

    public int MaxScore
    { 
        get { return maxScore; }
    }

    public void setCurrentQuestion(Question question) 
    { 
        currentQuestion = question;
    }

    public Question CurrentQuestion 
    { 
        get { return currentQuestion; } 
    }

    public int CurrentQuestionID
    {
        get { return currentQuestionID; }
    }

    public void NextQuestionID()
    {
        currentQuestionID++;
    }

    public void ReturnToFirstQuestion()
    {
        currentQuestionID = 0;
    }
    public void RestartTest()
    {
        currentQuestionID = 0;
        currentScore = 0;
        currentCorrectlyAnswers = 0;
    }
}
