public class TestData
{
    private string _testTitle = "Title text";

    private int _currentCorrectlyAnswers = 0;
    private int _questionAmount = 0;
    private int _currentScore = 0;
    private int _maxScore = 0;

    private Question _currentQuestion = null;
    private int _currentQuestionID = 0;

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

    public string TestTitle
    { 
        get {  return _testTitle; } 
    }

    public void setTestTitle(string TestTitle)
    {
        _testTitle = TestTitle;
    }

    public void addCorrectlyAnswers() 
    { 
        _currentCorrectlyAnswers++; 
    }

    public int CorrectlyAnswers
    { 
        get{ return _currentCorrectlyAnswers; } 
    }

    public void setQuestionAmount(int num) 
    { 
        _questionAmount = num; 
    }

    public int QuestionAmount
    {
        get { return _questionAmount; }
    }

    public void addCurrentScore(int num) 
    { 
        _currentScore += num; 
    }

    public int CurrentScore 
    { 
        get { return _currentScore; }
    }

    public void setMaxScore(int num) 
    { 
        _maxScore = num; 
    }

    public int MaxScore
    { 
        get { return _maxScore; }
    }

    public void setCurrentQuestion(Question question) 
    { 
        _currentQuestion = question;
    }

    public Question CurrentQuestion 
    { 
        get { return _currentQuestion; } 
    }

    public int CurrentQuestionID
    {
        get { return _currentQuestionID; }
    }

    public void NextQuestionID()
    {
        _currentQuestionID++;
    }

    public void ReturnToFirstQuestion()
    {
        _currentQuestionID = 0;
    }
    public void RestartTest()
    {
        _currentQuestionID = 0;
        _currentScore = 0;
        _currentCorrectlyAnswers = 0;
    }
}
